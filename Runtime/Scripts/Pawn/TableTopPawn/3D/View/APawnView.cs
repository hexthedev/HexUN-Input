using HexUN.Deps;
using HexUN.Behaviour;
using HexUN.Input;
using UnityEngine;

namespace HexUN.Systems.Grid
{
    /// <summary>
    /// Uses Hoverable events and PawnModel events to determine the visualization of the pawn
    /// </summary>
    public abstract class APawnView : HexBehaviour
    {
        [Header("Dependencies (PawnView)")]
        [SerializeField]
        private Object _pawnControl = null;

        [SerializeField]
        private Object _hoverableEventProvider = null;

        [Header("Debugging (PawnView)")]
        [SerializeField]
        protected bool _isInteractable;

        [SerializeField]
        protected EPawnState _pawnState;

        [SerializeField]
        protected EPawnBehaviour _pawnBehaviour;

        [SerializeField]
        protected EHoverableEvent _lastHoverEvent;

        protected IPawnControl PawnControl;
        protected IHoverableProvider HoverableProvider;

        protected override void HexAwake()
        {
            ResolveDependencies();
            EventBindings.Add(PawnControl.OnPawnState.Subscribe(HandlePawnState));
            EventBindings.Add(PawnControl.OnPawnBehave.Subscribe(HandlePawnBehaviour));
            EventBindings.Add(HoverableProvider.OnHoverableEvent.Subscribe(HandleHoverableEvent));
            EventBindings.Add(PawnControl.OnInteractionState.Subscribe(HandleInteractionState));
        }

        protected virtual void OnValidate()
        {
            ResolveDependencies();
            ResolveState();
        }

        /// <summary>
        /// Handle visual changes that occur when the state of the toggle changes
        /// </summary>
        /// <param name="state"></param>
        protected abstract void HandlePawnState(EPawnState state);

        /// <summary>
        /// Handle visual changes that occur when the behaviour of the pawn changes
        /// </summary>
        /// <param name="state"></param>
        protected abstract void HandlePawnBehaviour(EPawnBehaviour state);

        /// <summary>
        /// Handle visual changes that occur when the state of the interactablility changes
        /// </summary>
        /// <param name="interactionState"></param>
        protected abstract void HandleInteractionState(bool interactionState);

        /// <summary>
        /// Handle visual changes that occur when hover events are fired
        /// </summary>
        /// <param name="interactionState"></param>
        protected abstract void HandleHoverableEvent(EHoverableEvent hover);

        private void ResolveDependencies()
        {
            UTDependency.Resolve(ref _pawnControl, out PawnControl, this);
            UTDependency.Resolve(ref _hoverableEventProvider, out HoverableProvider, this);
        }

        private void ResolveState()
        {
            _isInteractable = PawnControl.IsInteractable;
            _lastHoverEvent = HoverableProvider.LastHoverableEvent;
            _pawnState = PawnControl.PawnState;
            _pawnBehaviour = PawnControl.PawnBehaviour;
        }
    }
}
