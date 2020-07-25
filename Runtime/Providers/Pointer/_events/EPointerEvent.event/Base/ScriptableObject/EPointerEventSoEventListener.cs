using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Pointer/Events/EPointerEvent/EPointerEventSoEventListener")]
   public class EPointerEventSoEventListener : ScriptableObjectEventListener<EPointerEvent, EPointerEventSoEvent, EPointerEventUnityEvent>
   {
   }
}