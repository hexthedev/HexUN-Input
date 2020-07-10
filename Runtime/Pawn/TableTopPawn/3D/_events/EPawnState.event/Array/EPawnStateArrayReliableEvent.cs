using HexUN.Events;

namespace HexUN.Systems.Grid
{
   [System.Serializable]
   public class EPawnStateArrayReliableEvent : ReliableEvent<EPawnState[], EPawnStateArrayUnityEvent>
   {
   }
}