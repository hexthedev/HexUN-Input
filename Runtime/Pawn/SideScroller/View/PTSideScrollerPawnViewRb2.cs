using System.Collections;
using HexUN.Patterns;
using HexUN.Physics2D;
using HexUN.Temporal;
using UnityEngine;

namespace HexUN.Pawn
{
    /// <summary>
    /// Controls a SideScrollerPawn with a Rigidbody2D
    /// </summary>
    public class PTSideScrollerPawnViewRb2 : MonoBehaviour
    {
        [Header("Dependencies (PTSideScrollerPawnViewRb2)")]
        [SerializeField]
        private Rigidbody2D _rb2d = default;
        
        [Header("Sensors (PTSideScrollerPawnViewRb2)")]
        [SerializeField]
        Raycast2DSensor[] _leftWallSensor = null;

        [SerializeField]
        Raycast2DSensor[] _rightWallSensor = null;

        [SerializeField]
        Raycast2DSensor[] _groundSensors = null;

        [Header("Options")]
        [SerializeField]
        private float _moveAcceleration = 0.2f;
        [SerializeField]
        private float _moveMaxVelocity = 2;
        [SerializeField]
        [Tooltip("multiple move result. Can be used to remove y axis from move")]
        private Vector3 _moveMask;
        [SerializeField]
        private float _dashForce = 100;
        [SerializeField]
        private float _jumpForce = 100;
        [SerializeField]
        private int _jumpNumber = 2;
        [SerializeField]
        private float _jumpCooldown = 0.3f;

        [Header("Debugging")]
        [SerializeField]
        private bool _isOnGround = false;
        [SerializeField]
        private bool _isOnRightWall = false;
        [SerializeField]
        private bool _isOnLeftWall = false;

        [SerializeField]
        private int _currentJumps = 0;
        [SerializeField]
        private bool _jumpBlocked = false;
        [SerializeField]
        private Coroutine _jumpTimer = null;

        [SerializeField]
        private Vector2 _lastMove;

        private bool _isOnWall => _isOnLeftWall || _isOnRightWall;

        public void HandleDash()
        {
            ResolveSensors();
            _rb2d.AddForce(new Vector2(Mathf.Sign(_lastMove.x), 0) * _dashForce, ForceMode2D.Force );
        }

        public void HandleJump()
        {
            ResolveSensors();

            if (_jumpBlocked || _currentJumps >= _jumpNumber) return;

            Vector2 vec = Vector2.up;
            if (_isOnLeftWall) vec = new Vector2(0.4f, 0.8f);
            if (_isOnRightWall) vec = new Vector2(-0.4f, 0.8f);

            _rb2d.AddForce(vec * _jumpForce, ForceMode2D.Force);
            _currentJumps++;

            if (_jumpTimer != null) StopCoroutine(_jumpTimer);
            _jumpTimer = StartCoroutine(JumpTimer());
        }

        public void HandleMove(Vector2 move)
        {
            ResolveSensors();

            Vector2 newVelo = _rb2d.velocity + (move * _moveAcceleration * Time.deltaTime * _moveMask);
            if (newVelo.magnitude > _moveMaxVelocity) newVelo = newVelo.normalized * _moveMaxVelocity;

            _rb2d.velocity = newVelo;
            _lastMove = move;
        }

        private void ResolveSensors()
        {
            OneSensor(ref _leftWallSensor, ref _isOnLeftWall);
            OneSensor(ref _rightWallSensor, ref _isOnRightWall);
            OneSensor(ref _groundSensors, ref _isOnGround);

            if (_isOnGround || _isOnWall)
            {
                _jumpBlocked = false;
                _currentJumps = 0;
            }
        }

        private void OneSensor(ref Raycast2DSensor[] sensors, ref bool flag)
        {
            foreach (Raycast2DSensor s in sensors)
            {
                RaycastHit2D[] hit = s.Sense();
                if (hit.Length != 0)
                {
                    flag = true;
                    return;
                }
            }

            flag = false;
        }

        private IEnumerator JumpTimer()
        {
            float time = 0;

            while(_jumpBlocked != false && time < _jumpCooldown)
            {
                time += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            _jumpBlocked = false;
        }
    }
}