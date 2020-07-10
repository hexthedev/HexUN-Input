using UnityEngine;

namespace HexUN.Input
{
    /// <summary>
    /// Provides interaction event using a collider to catch interactions
    /// </summary>
    public class InteractionControlCollider : AInteractionControl
    {
        [SerializeField]
        [Tooltip("Collider used to catch interactions")]
        private Collider _collider = null;

        /// <inheritdoc />
        protected override void HandleInteractionStateChange(bool state) => _collider.enabled = state;
    }
}
