using UnityEngine;
using HexUN.Events;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "EPointerEventSoEvent", menuName = "HexUN/Systems/Input/Pointer/Events/EPointerEvent")]
   public class EPointerEventSoEvent : ScriptableObjectEvent<EPointerEvent>
   {
   }
}