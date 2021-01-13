using UnityEngine.EventSystems;

namespace HexUN.Input
{
    /// <summary>
    /// Provides pointer events by listening to UNity Pointer interfaces
    /// </summary>
    public class PointerProviderUpointer : APointerProvider, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerClickHandler
    {
        /// <summary>
        /// IPointerDownHandler function
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerDown(PointerEventData eventData) => OnPointerEvent?.Invoke(EPointerEvent.Down);

        /// <summary>
        /// IPointerEnterHandler function
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerEnter(PointerEventData eventData) => OnPointerEvent?.Invoke(EPointerEvent.Enter);

        /// <summary>
        /// IPointerExitHandler function
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerExit(PointerEventData eventData) => OnPointerEvent?.Invoke(EPointerEvent.Exit);

        /// <summary>
        /// IPointerUpHandler function
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerUp(PointerEventData eventData) => OnPointerEvent?.Invoke(EPointerEvent.Up);

        /// <summary>
        /// THe pointer has clicked the element
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerClick(PointerEventData eventData){
            OnPointerEvent?.Invoke(EPointerEvent.Click);
            OnClickEvent?.Invoke();
        }
    }
}
