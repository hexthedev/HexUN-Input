using UnityEngine;
using HexUN.Events;
using UnityEngine.EventSystems;

namespace HexUN.Input
{
   [CreateAssetMenu(fileName = "PointerEventDataSoEvent", menuName = "HexUN/Input/Drag/Events/PointerEventData")]
   public class PointerEventDataSoEvent : ScriptableObjectEvent<PointerEventData>
   {
   }
}