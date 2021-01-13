using HexUN.Events;
using UnityEngine;
using UnityEngine.Events;

namespace HexUN.Systems.Grid
{
   [AddComponentMenu("HexUN/Systems/EPawnBehaviour/Events/EPawnBehaviour/EPawnBehaviourSoEventListener")]
   public class EPawnBehaviourSoEventListener : ScriptableObjectEventListener<EPawnBehaviour, EPawnBehaviourSoEvent, EPawnBehaviourUnityEvent>
   {
   }
}