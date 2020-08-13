using HexCS.Core;
using HexUN.Events;
using HexUN.MonoB;
using UnityEngine;

namespace HexUN.Input
{
    public class ADragProvider : MonoEnhanced
    {
        [Header("Emissions (ADragProvider)")]
        [SerializeField]
        protected Vector2ReliableEvent OnBeginDragDraggable = null;

        [SerializeField]
        protected Vector2ReliableEvent OnDropDraggable = null;

        [SerializeField]
        protected Vector2ReliableEvent OnDragDraggable = null;

        [Header("Debugging (ADragProvider)")]
        [SerializeField]
        protected EDragState State;

        #region API
        /// <inheritdoc/>
        public IEventSubscriber<UnityEngine.Vector2> OnBeginDragFrame => OnBeginDragDraggable;

        /// <inheritdoc/>
        public IEventSubscriber<UnityEngine.Vector2> OnDropFrame => OnDropDraggable;

        /// <inheritdoc/>
        public IEventSubscriber<UnityEngine.Vector2> OnDragFrame => OnDragDraggable;

        /// <inheritdoc/>
        public EDragState LastDragState => State;
        #endregion
    }
}