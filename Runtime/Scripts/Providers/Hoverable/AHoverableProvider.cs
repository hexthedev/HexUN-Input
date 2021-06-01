using HexCS.Core;
using HexUN.Behaviour;
using UnityEngine;

namespace HexUN.Input
{
    /// <inheritdoc />
    public abstract class AHoverableProvider : HexBehaviour, IHoverableProvider
    {
        [Header("Emissions")]
        [SerializeField]
        protected EHoverableEventReliableEvent HoverableEvent = null;

        [Header("Debug (HoverableProvider)")]
        [SerializeField]
        private EHoverableEvent _lastHoverableEvent = EHoverableEvent.Absent;

        protected override void HexAwake()
        {
            EventBindings.Add(HoverableEvent.Subscribe(HandleHoverableEvent));
        }

        /// <inheritdoc />
        public IEventSubscriber<EHoverableEvent> OnHoverableEvent => HoverableEvent;

        public EHoverableEvent LastHoverableEvent => _lastHoverableEvent;

        private void HandleHoverableEvent(EHoverableEvent evt)
        {
            _lastHoverableEvent = evt;
        }

        protected virtual void OnValidate()
        {
            HoverableEvent.Invoke(_lastHoverableEvent);
        }
    }
}
