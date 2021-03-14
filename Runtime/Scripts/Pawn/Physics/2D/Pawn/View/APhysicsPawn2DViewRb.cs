using HexCS.Core;
using HexUN.Deps;
using HexUN.Behaviour;
using HexUN.Physics2D;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace HexUN.Pawn
{
    /// <summary>
    /// Drives the physics of a 2D pawn
    /// </summary>
    public abstract class APhysicsPawn2DViewRb : DependentBehaviour
    {
        [Header("Dependencies (PhysicsPawnViewRb2D)")]
        [SerializeField]
        private Object _physicsPawn2DProvider = null;

        private IPhysicsPawn2DProvider _physicsPawnProvider = null;

        /// <inheritdoc />
        protected override void ResolveDependencies()
        {
            UTDependency.Resolve(ref _physicsPawn2DProvider, out _physicsPawnProvider, this);
        }

        /// <inheritdoc />
        protected override void ResolveEventBindings(EventBindingGroup ebs)
        {
            ebs.Add(_physicsPawnProvider.OnMove.Subscribe(HandleMove));
            ebs.Add(_physicsPawnProvider.OnImpulse.Subscribe(HandleImpulse));
            ebs.Add(_physicsPawnProvider.OnDash.Subscribe(HandleDash));
        }

        protected abstract void HandleMove(Vector2 vec);

        protected abstract void HandleImpulse(Vector2 vec);

        protected abstract void HandleDash(SForce2D vec);
    }
}