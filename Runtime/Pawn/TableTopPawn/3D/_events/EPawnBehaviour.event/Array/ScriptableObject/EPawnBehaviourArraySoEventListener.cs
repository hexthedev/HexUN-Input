using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Systems.Grid
{
   [AddComponentMenu("HexUN/Systems/EPawnBehaviour/Events/EPawnBehaviourArray/EPawnBehaviourArraySoEventListener")]
   public class EPawnBehaviourArraySoEventListener : ScriptableObjectEventListener<EPawnBehaviour[], EPawnBehaviourArraySoEvent, EPawnBehaviourArrayUnityEvent>
   {
   }
}