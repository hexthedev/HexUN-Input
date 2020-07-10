using UnityEngine;
using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [CreateAssetMenu(fileName = "EPawnStateSoEvent", menuName = "HexUN/Systems/EPawnState/Events/EPawnState")]
   public class EPawnStateSoEvent : ScriptableObjectEvent<EPawnState>
   {
   }
}