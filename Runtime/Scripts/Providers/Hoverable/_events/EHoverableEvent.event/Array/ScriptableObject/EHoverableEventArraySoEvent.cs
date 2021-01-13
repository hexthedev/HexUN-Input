using UnityEngine;
using HexUN.Events;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "EHoverableEventArraySoEvent", menuName = "HexUN/Input/Hover/Events/EHoverableEventArray")]
   public class EHoverableEventArraySoEvent : ScriptableObjectEvent<EHoverableEvent[]>
   {
   }
}