using UnityEngine;
using HexUN.Events;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "PointerEventDataArraySoEvent", menuName = "HexUN/Input/Drag/Events/PointerEventDataArray")]
   public class PointerEventDataArraySoEvent : ScriptableObjectEvent<PointerEventData[]>
   {
   }
}