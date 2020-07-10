using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Systems.Grid
{
   [AddComponentMenu("HexUN/Systems/EPawnState/Events/EPawnState/EPawnStateSoEventListener")]
   public class EPawnStateSoEventListener : ScriptableObjectEventListener<EPawnState, EPawnStateSoEvent, EPawnStateUnityEvent>
   {
   }
}