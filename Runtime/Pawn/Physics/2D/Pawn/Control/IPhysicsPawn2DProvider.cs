using TobiasCSStandard.Core;
using HexUN.Physics2D;
using Vector2 = UnityEngine.Vector2;

namespace HexUN.Pawn
{
    public interface IPhysicsPawn2DProvider
    {
        /// <summary>
        /// Invoked on move action
        /// </summary>
        IEventSubscriber<Vector2> OnMove { get; }

        /// <summary>
        /// Invoked on impulse action
        /// </summary>
        IEventSubscriber<Vector2> OnImpulse { get; }

        /// <summary>
        /// Invoked on dash action
        /// </summary>
        IEventSubscriber<SForce2D> OnDash { get; }
    }
}
