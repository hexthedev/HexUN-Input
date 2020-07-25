using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Pointer/Events/EHoverableEventArray/EHoverableEventArraySoEventListener")]
   public class EHoverableEventArraySoEventListener : ScriptableObjectEventListener<EHoverableEvent[], EHoverableEventArraySoEvent, EHoverableEventArrayUnityEvent>
   {
   }
}