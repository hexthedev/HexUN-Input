using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Drag/Events/PointerEventDataArray/PointerEventDataArraySoEventListener")]
   public class PointerEventDataArraySoEventListener : ScriptableObjectEventListener<PointerEventData[], PointerEventDataArraySoEvent, PointerEventDataArrayUnityEvent>
   {
   }
}