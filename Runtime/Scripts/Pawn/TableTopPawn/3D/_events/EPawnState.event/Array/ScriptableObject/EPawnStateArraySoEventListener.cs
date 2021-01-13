using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Systems.Grid
{
   [AddComponentMenu("HexUN/Systems/EPawnState/Events/EPawnStateArray/EPawnStateArraySoEventListener")]
   public class EPawnStateArraySoEventListener : ScriptableObjectEventListener<EPawnState[], EPawnStateArraySoEvent, EPawnStateArrayUnityEvent>
   {
   }
}