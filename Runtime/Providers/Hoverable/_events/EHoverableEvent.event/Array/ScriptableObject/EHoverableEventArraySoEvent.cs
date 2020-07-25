using UnityEngine;
using HexUN.Events;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "EHoverableEventArraySoEvent", menuName = "HexUN/Input/Pointer/Events/EHoverableEventArray")]
   public class EHoverableEventArraySoEvent : ScriptableObjectEvent<EHoverableEvent[]>
   {
   }
}