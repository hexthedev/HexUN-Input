using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Systems/Input/Pointer/Events/EPointerEvent/EPointerEventSoEventListener")]
   public class EPointerEventSoEventListener : ScriptableObjectEventListener<EPointerEvent, EPointerEventSoEvent, EPointerEventUnityEvent>
   {
   }
}