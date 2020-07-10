using UnityEngine;
using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [CreateAssetMenu(fileName = "EPawnBehaviourArraySoEvent", menuName = "HexUN/Systems/EPawnBehaviour/Events/EPawnBehaviourArray")]
   public class EPawnBehaviourArraySoEvent : ScriptableObjectEvent<EPawnBehaviour[]>
   {
   }
}