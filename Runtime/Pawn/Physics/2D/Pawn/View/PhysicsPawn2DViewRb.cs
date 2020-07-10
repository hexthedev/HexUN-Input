using System.Collections;
using HexUN.Physics2D;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace HexUN.Pawn
{
    /// <summary>
    /// Drives the physics of a 2D pawn
    /// </summary>
    public class PhysicsPawn2DViewRb : APhysicsPawn2DViewRb
    {
        [Header("Dependencies (PhysicsPawn2DViewRb)")]
        [SerializeField]
        private Rigidbody2D _rigidbody = default;

        [Header("Options")]
        [Tooltip("Scales magnitude of move commands")]
        [SerializeField]
        float MoveMagScale = 1;

        [Tooltip("Scales magnitude of move commands")]
        [SerializeField]
        float ImpulseMagScale = 10;

        [Tooltip("Scales magnitude of move commands")]
        [SerializeField]
        float DashMagScale = 1;

        private bool _isVelocityForced;
        private Vector2 _forceVelocity;

        bool _addImpulse;
        private Vector2 _impulse;

        bool _addForce;
        private Vector2 _force;

        private Coroutine _dashRoutine;
        private float _remainingDashTime = 0;

        private bool _resetVelocity;

        protected override void HandleMove(Vector2 vec)
        {
            _addForce = true;
            _force = vec * MoveMagScale;
        }

        protected override void HandleImpulse(Vector2 vec)
        {
            _addImpulse = true;
            _impulse = vec * ImpulseMagScale;
        }

        protected override void HandleDash(SForce2D vec)
        {
            if(_dashRoutine != null)
            {
                StopCoroutine(_dashRoutine);
            }

            _dashRoutine = StartCoroutine(DashCoroutine(vec.Time, vec.Force * DashMagScale));
        }

        private void FixedUpdate()
        {
            // on forced velocity
            if (_isVelocityForced)
            {
                _rigidbody.velocity = _forceVelocity;
                return;
            }

            if (_resetVelocity)
            {
                _rigidbody.velocity = _rigidbody.velocity.normalized;
                _resetVelocity = false;
            }

            if (_addForce)
            {
                _rigidbody.AddForce(_force, ForceMode2D.Force);
                _addForce = false;
            }

            if (_addImpulse)
            {
                _rigidbody.AddForce(_impulse, ForceMode2D.Impulse);
                _addImpulse = false;
            }
        }

        private IEnumerator DashCoroutine(float time, Vector2 velocity)
        {
            _remainingDashTime = time;
            _forceVelocity = velocity;
            _isVelocityForced = true;

            while(_remainingDashTime >= 0)
            {
                _remainingDashTime -= Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            _resetVelocity = true;
            _isVelocityForced = false;
        }
    }
}