﻿using TobiasCSStandard.Core;
using HexUN.MonoB;
using UnityEngine;

namespace HexUN.Input
{
    /// <inheritdoc />
    public abstract class AHoverableProvider : MonoEnhanced, IHoverableProvider
    {
        [Header("Emissions")]
        [SerializeField]
        protected EHoverableEventReliableEvent HoverableEvent = null;

        [Header("Debug (HoverableProvider)")]
        [SerializeField]
        private EHoverableEvent _lastHoverableEvent = EHoverableEvent.Absent;

        protected override void MonoAwake()
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