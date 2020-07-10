using TobiasCSStandard.Core;
using HexUN.Events;
using HexUN.Physics2D;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace HexUN.Pawn
{
    public class PhysicsPawn2DControl : MonoBehaviour, IPhysicsPawn2DControl
    {
        [Header("Emissions (PhysicsPawn2DControl)")]
        [SerializeField]
        private Vector2ReliableEvent _onMove = new Vector2ReliableEvent();

        [SerializeField]
        private Vector2ReliableEvent _onImpulse = new Vector2ReliableEvent();

        [SerializeField]
        private SForce2DReliableEvent _onDash = new SForce2DReliableEvent();
        
        /// <inheritdoc />
        public IEventSubscriber<Vector2> OnMove => _onMove;

        /// <inheritdoc />
        public IEventSubscriber<Vector2> OnImpulse => _onImpulse;

        /// <inheritdoc />
        public IEventSubscriber<SForce2D> OnDash => _onDash;

        /// <inheritdoc />
        public void Move(Vector2 directionMagnitude)
        {
            _onMove?.Invoke(directionMagnitude);
        }

        /// <inheritdoc />
        public void Impluse(Vector2 direction, float force)
        {
            _onImpulse?.Invoke(direction.normalized * force);
        }

        /// <inheritdoc />
        public void Dash(Vector2 direction, float velocity, float time)
        {
            _onDash?.Invoke(new SForce2D(direction.normalized * velocity, time));
        }

#if UNITY_EDITOR
        [ContextMenu("Move")]
        public void CMMove()
        {
            Move(Vector2.one);
        }

        [ContextMenu("Impulse")]
        public void CMImpulse()
        {
            Impluse(Vector2.one, 1);
        }

        [ContextMenu("Dash")]
        public void CMDash()
        {
            Dash(Vector2.one, 1, 1);
        }
#endif
    }
}