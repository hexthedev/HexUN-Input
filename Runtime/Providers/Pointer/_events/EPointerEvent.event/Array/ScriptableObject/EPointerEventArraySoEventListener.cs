using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Input
{
   [AddComponentMenu("HexUN/Input/Pointer/Events/EPointerEventArray/EPointerEventArraySoEventListener")]
   public class EPointerEventArraySoEventListener : ScriptableObjectEventListener<EPointerEvent[], EPointerEventArraySoEvent, EPointerEventArrayUnityEvent>
   {
   }
}