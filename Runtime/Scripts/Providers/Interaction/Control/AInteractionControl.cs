using HexCS.Core;
using HexUN.Events;
using HexUN.Behaviour;
using UnityEngine;

namespace HexUN.Input
{
    /// <inheritdoc/>
    public abstract class AInteractionControl : HexBehaviour, IInteractionControl
    {
        [Header("State (InteractionProvider)")]
        [SerializeField]
        private bool Interactable = true;

        [Header("Emissions (InteractionProvider)")]
        [SerializeField]
        [Tooltip("If you want to emit event with SO event, add one here")]
        protected BooleanReliableEvent OnInteractionStateEvent = new BooleanReliableEvent();

        private bool _interactable;

        #region API
        /// <inheritdoc />
        public IEventSubscriber<bool> OnInteractionState => OnInteractionStateEvent;

        /// <inheritdoc />
        public bool IsInteractable  => _interactable;
        
        /// <inheritdoc />
        public void SetInteractable(bool state)
        {
            if (_interactable == state) return;
            _interactable = state;
            Interactable = _interactable;
            HandleInteractionStateChange(state);
            OnInteractionStateEvent.Invoke(state);
        }
        #endregion

        #region Protected API
        /// <summary>
        /// Handle the way interactions are enabled and disabled
        /// </summary>
        /// <param name="state"></param>
        protected abstract void HandleInteractionStateChange(bool state);

        /// <inheritdoc />
        protected override void MonoStart()
        {
            CallAfterStart(o => SetInteractable(Interactable));
        }
        #endregion

        private void OnValidate() => SetInteractable(Interactable);
    }
}
