using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Hover/Events/EHoverableEventArray/EHoverableEventArraySoEventListener")]
   public class EHoverableEventArraySoEventListener : ScriptableObjectEventListener<EHoverableEvent[], EHoverableEventArraySoEvent, EHoverableEventArrayUnityEvent>
   {
   }
}