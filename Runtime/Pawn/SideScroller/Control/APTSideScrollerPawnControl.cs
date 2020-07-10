using UnityEngine;
using HexUN.Patterns;
using TobiasCSStandard.Core;
using Vector2 = UnityEngine.Vector2;

namespace HexUN.Pawn
{
   public abstract class APTSideScrollerPawnControl : AControl, IPTSideScrollerPawnControl
   {
      [Header("Emissions (APTSideScrollerPawnControl)")]
      [SerializeField]
      protected CVCommandReliableEvent _onJump = new CVCommandReliableEvent();

      [SerializeField]
      protected CVCommandReliableEvent _onDash = new CVCommandReliableEvent();

      [SerializeField]
      protected CVCommandReliableEvent _onMove = new CVCommandReliableEvent();

      public IEventSubscriber<CVCommand> OnJump => _onJump;

      public IEventSubscriber<CVCommand> OnDash => _onDash;

      public IEventSubscriber<CVCommand> OnMove => _onMove;

      public abstract void Jump();

      public abstract void Dash();

      public abstract void Move(Vector2 move);

   }
}