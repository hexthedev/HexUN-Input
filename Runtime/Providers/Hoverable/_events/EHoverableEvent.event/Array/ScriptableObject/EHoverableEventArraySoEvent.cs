using UnityEngine;
using HexUN.Events;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "EHoverableEventArraySoEvent", menuName = "HexUN/Systems/Input/Pointer/Events/EHoverableEventArray")]
   public class EHoverableEventArraySoEvent : ScriptableObjectEvent<EHoverableEvent[]>
   {
   }
}