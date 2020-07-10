using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [System.Serializable]
   public class EPawnStateReliableEvent : ReliableEvent<EPawnState, EPawnStateUnityEvent>
   {
   }
}