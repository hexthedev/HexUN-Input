using HexCS.Core;
using HexUN.Events;
using HexUN.MonoB;
using UnityEngine;

namespace HexUN.Input
{
    /// <inheritdoc/>
    public abstract class APointerProvider : HexBehaviour, IPointerProvider
    {
        [Header("Emissions (APointerProvider)")]
        [SerializeField]
        protected VoidReliableEvent OnClickEvent = null;

        [SerializeField]
        protected EPointerEventReliableEvent OnPointerEvent = null;


        [Header("Debugging (PointerProvider)")]
        [SerializeField]
        private EPointerEvent _lastEvent = EPointerEvent.Exit;

        #region API
        /// <inheritdoc/>
        public IEventSubscriber<EPointerEvent> OnPointer => OnPointerEvent;

        /// <inheritdoc/>
        public IEventSubscriber OnClick => OnClickEvent;

        /// <inheritdoc/>
        public EPointerEvent LastPointerEvent => _lastEvent;
        #endregion

        #region Protected API

        protected override void MonoAwake()
        {
            EventBindings.Add(OnPointerEvent.Subscribe(HandlePointerEvent));
        }
        #endregion

        private void HandlePointerEvent(EPointerEvent evt)
        {
            _lastEvent = evt;
        }

        protected virtual void OnValidate()
        {
            OnPointerEvent.Invoke(_lastEvent);
            if (_lastEvent == EPointerEvent.Click) OnClickEvent.Invoke();
        }
    }
}
