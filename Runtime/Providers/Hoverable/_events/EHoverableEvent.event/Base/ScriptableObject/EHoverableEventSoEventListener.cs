using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Systems/Input/Pointer/Events/EHoverableEvent/EHoverableEventSoEventListener")]
   public class EHoverableEventSoEventListener : ScriptableObjectEventListener<EHoverableEvent, EHoverableEventSoEvent, EHoverableEventUnityEvent>
   {
   }
}