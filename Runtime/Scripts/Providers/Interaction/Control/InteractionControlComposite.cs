using UnityEngine;

namespace HexUN.Input
{
    /// <summary>
    /// Manages interaction by enabling and disabling MonoBehaviours that provide input events
    /// </summary>
    public class InteractionControlComposite : AInteractionControl
    {
        [Header("Interactable Components")]
        [SerializeField]
        [Tooltip("Array of providers that provide interaction to child components")]
        private AInteractionControl[] _providers = default;

        /// <inheritdoc />
        protected override void HandleInteractionStateChange(bool state)
        {
            if (_providers == null) return;
            foreach (AInteractionControl pro in _providers) {
                if(pro != null) pro.SetInteractable(state);
            }
        }
    }
}
