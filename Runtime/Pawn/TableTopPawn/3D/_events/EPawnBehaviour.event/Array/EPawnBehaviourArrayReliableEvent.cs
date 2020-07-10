using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [System.Serializable]
   public class EPawnBehaviourArrayReliableEvent : ReliableEvent<EPawnBehaviour[], EPawnBehaviourArrayUnityEvent>
   {
   }
}