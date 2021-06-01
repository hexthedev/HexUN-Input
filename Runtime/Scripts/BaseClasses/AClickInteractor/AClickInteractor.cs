using HexCS.Core;
using HexUN.Deps;
using HexUN.Events;
using HexUN.Behaviour;
using UnityEngine;

namespace HexUN.Input
{
    public abstract class AClickInteractor : HexBehaviour, IInteractionProvider, IClickProvider
    {
        [Header("Dependencies (ClickInteractor)")]
        [SerializeField]
        private Object _interactionProvider = null;

        [Header("Emissions (ClickInteractor)")]
        [SerializeField]
        protected BooleanReliableEvent _onInteractionState = new BooleanReliableEvent();

        [SerializeField]
        protected VoidReliableEvent _onClick = new VoidReliableEvent();

        [Header("Debugging (ClickInteractor)")]
        [SerializeField]
        [Tooltip("The interactable state of the hex")]
        private bool _interactable = true;

        protected IInteractionControl InteractionProvider;

        #region API
        /// <inheritdoc />
        public bool IsInteractable
        {
            get => _interactable;
            set => SetInteractable(value);
        }

        /// <inheritdoc />
        public IEventSubscriber<bool> OnInteractionState => _onInteractionState;

        /// <inheritdoc />
        public IEventSubscriber OnClick => _onClick;
        #endregion

        protected override void HexAwake()
        {
            ResolveDependencies();
            CallAfterAwake((o) => EventBindings.Add(InteractionProvider.OnInteractionState.Subscribe(HandleInteractionState)));
        }

        protected override void HexStart()
        {
            SetInteractable(_interactable);
        }

        protected virtual void OnValidate()
        {
            ResolveDependencies();
            SetInteractable(_interactable);
        }

        private void ResolveDependencies()
        {
            UTDependency.Resolve(ref _interactionProvider, out InteractionProvider, this);
        }

        private void HandleInteractionState(bool state)
        {
            SetInteractable(state);
        }

        private void SetInteractable(bool interactable)
        {
            _interactable = interactable;
            InteractionProvider.SetInteractable(_interactable);
            _onInteractionState.Invoke(_interactable);
        }
    }
}