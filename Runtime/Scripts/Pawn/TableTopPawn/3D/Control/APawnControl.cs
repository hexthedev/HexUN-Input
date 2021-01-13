using HexCS.Core;
using HexUN.Deps;
using HexUN.Events;
using HexUN.Input;
using UnityEngine;

namespace HexUN.Systems.Grid
{
    /// <summary>
    /// Base class for Pawn Controls. Pawn controls assums that apwns need
    /// states (like hihglighted, neutral) and behaviours (like, idle, move, etc.)
    /// </summary>
    public abstract class APawnControl : AClickInteractor, IPawnControl
    {
        [Header("Emissions (PawnControl)")]
        [SerializeField]
        protected EPawnStateReliableEvent _onPawnState = new EPawnStateReliableEvent();

        [SerializeField]
        protected EPawnBehaviourReliableEvent _onPawnBehaviour = new EPawnBehaviourReliableEvent();

        [Header("Debugging (PawnControl)")]
        [SerializeField]
        [Tooltip("The state of the hex")]
        private EPawnState _state = EPawnState.Neutral;

        [SerializeField]
        [Tooltip("The state of the hex")]
        private EPawnBehaviour _behaviour = EPawnBehaviour.None;

        private EPawnState _pawnState;
        private EPawnBehaviour _pawnBehaviour;

        #region API
        /// <inheritdoc />
        public EPawnState PawnState => _pawnState;

        /// <inheritdoc />
        public EPawnBehaviour PawnBehaviour => _pawnBehaviour;

        /// <inheritdoc />
        public IEventSubscriber<EPawnState> OnPawnState => _onPawnState;

        /// <inheritdoc />
        public IEventSubscriber<EPawnBehaviour> OnPawnBehave => _onPawnBehaviour;

        /// <summary>
        /// Set the state of the current pawn
        /// </summary>
        /// <param name="state"></param>
        public void SetPawnState(EPawnState state)
        {
            _state = state;
            _pawnState = state;
            _onPawnState.Invoke(_state);
        }

        /// <summary>
        /// Set the behaviour of the current pawn
        /// </summary>
        /// <param name="behaviour"></param>
        public void SetPawnBehaviour(EPawnBehaviour behaviour)
        {
            _behaviour = behaviour;
            _pawnBehaviour = behaviour;
            _onPawnBehaviour.Invoke(_behaviour);
        }
        #endregion

        protected override void MonoStart()
        {
            ResolveStates();
        }

        protected override void OnValidate()
        {
            base.OnValidate();
            ResolveStates();
        }

        private void ResolveStates()
        {
            SetPawnState(_state);
            SetPawnBehaviour(_behaviour);
        }
    }
}