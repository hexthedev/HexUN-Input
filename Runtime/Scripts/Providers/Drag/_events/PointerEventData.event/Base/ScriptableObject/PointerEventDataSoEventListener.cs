using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Drag/Events/PointerEventData/PointerEventDataSoEventListener")]
   public class PointerEventDataSoEventListener : ScriptableObjectEventListener<PointerEventData, PointerEventDataSoEvent, PointerEventDataUnityEvent>
   {
   }
}