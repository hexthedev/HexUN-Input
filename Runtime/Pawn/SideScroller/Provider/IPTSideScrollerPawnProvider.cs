using TobiasCSStandard.Core;
using HexUN.Patterns;
using UnityEngine;

namespace HexUN.Pawn
{
   public interface IPTSideScrollerPawnProvider
   {
      IEventSubscriber<CVCommand> OnJump { get; }

      IEventSubscriber<CVCommand> OnDash { get; }

      IEventSubscriber<CVCommand> OnMove { get; }
   }
}