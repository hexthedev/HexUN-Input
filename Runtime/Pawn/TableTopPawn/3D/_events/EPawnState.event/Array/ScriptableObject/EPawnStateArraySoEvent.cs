using UnityEngine;
using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [CreateAssetMenu(fileName = "EPawnStateArraySoEvent", menuName = "HexUN/Systems/EPawnState/Events/EPawnStateArray")]
   public class EPawnStateArraySoEvent : ScriptableObjectEvent<EPawnState[]>
   {
   }
}