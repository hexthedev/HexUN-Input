using HexCS.Core;
using HexUN.MonoB;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
    public class ADragProvider : MonoEnhanced
    {
        [Header("Emissions (ADragProvider)")]
        [SerializeField]
        protected PointerEventDataReliableEvent OnBeginDragDraggable = null;

        [SerializeField]
        protected PointerEventDataReliableEvent OnDropDraggable = null;

        [SerializeField]
        protected PointerEventDataReliableEvent OnDragDraggable = null;

        [Header("Debugging (ADragProvider)")]
        [SerializeField]
        protected EDragState State;

        #region API
        /// <inheritdoc/>
        public IEventSubscriber<PointerEventData> OnBeginDragFrame => OnBeginDragDraggable;

        /// <inheritdoc/>
        public IEventSubscriber<PointerEventData> OnDropFrame => OnDropDraggable;

        /// <inheritdoc/>
        public IEventSubscriber<PointerEventData> OnDragFrame => OnDragDraggable;

        /// <inheritdoc/>
        public EDragState LastDragState => State;
        #endregion
    }
}