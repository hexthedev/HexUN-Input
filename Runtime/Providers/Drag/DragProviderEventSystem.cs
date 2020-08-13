using UnityEngine.EventSystems;

namespace HexUN.Input
{
    public class DragProviderEventSystem : ADragProvider, IDragHandler, IEndDragHandler, IBeginDragHandler
    {
        public void OnBeginDrag(PointerEventData eventData)
        {
            OnBeginDragDraggable.Invoke(eventData.position);
            State = EDragState.Begin;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.dragging)
            {
                OnDragDraggable.Invoke(eventData.position);
                State = EDragState.Dragging;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            OnDropDraggable.Invoke(eventData.position);
            State = EDragState.Idle;
        }
    }
}