using UnityEngine;
using HexUN.Events;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "EPointerEventArraySoEvent", menuName = "HexUN/Systems/Input/Pointer/Events/EPointerEventArray")]
   public class EPointerEventArraySoEvent : ScriptableObjectEvent<EPointerEvent[]>
   {
   }
}