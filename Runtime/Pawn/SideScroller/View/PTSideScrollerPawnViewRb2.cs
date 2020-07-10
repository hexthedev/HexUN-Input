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
    public class PTSideScrollerPawnViewRb2 : APTSideScrollerPawnView
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
        private float _moveSpeed = 10;
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

        public override void HandleDash(CVCommand command)
        {
            ResolveSensors();
            _rb2d.AddForce(new Vector2(Mathf.Sign(_lastMove.x), 0) * _dashForce, ForceMode2D.Force );
        }

        public override void HandleJump(CVCommand command)
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

        public override void HandleMove(CVCommand command)
        {
            if (!command.TryGet(out Vector2 vec)) return;
            ResolveSensors();
            _rb2d.velocity += vec * _moveSpeed;
            _lastMove = vec;
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
                RaycastHit2D hit = s.Sense();
                if (hit.collider != null)
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