using UnityEngine;

namespace HexUN.Input
{
    /// <summary>
    /// Manages interaction by enabling and disabling MonoBehaviours that provide input events
    /// </summary>
    public class InteractionControlMono : AInteractionControl
    {
        [Header("Interactable Components (InteractionProviderMono)")]
        [SerializeField]
        [Tooltip("Array of monobehaviours that provide interaction")]
        private MonoBehaviour[] _monobehaviours = default;

        /// <inheritdoc />
        protected override void HandleInteractionStateChange(bool state)
        {    
            foreach (MonoBehaviour mono in _monobehaviours) mono.enabled = state;
        }
    }
}
