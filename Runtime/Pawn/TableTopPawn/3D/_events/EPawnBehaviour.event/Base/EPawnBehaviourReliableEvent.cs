using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [System.Serializable]
   public class EPawnBehaviourReliableEvent : ReliableEvent<EPawnBehaviour, EPawnBehaviourUnityEvent>
   {
   }
}