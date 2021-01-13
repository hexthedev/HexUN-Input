using HexUN.Events;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
   [System.Serializable]
   public class PointerEventDataReliableEvent : ReliableEvent<PointerEventData, PointerEventDataUnityEvent>
   {
   }
}