using UnityEngine;

namespace HexUN.Pawn
{
   public interface IPTSideScrollerPawnControl : IPTSideScrollerPawnProvider
   {
      void Jump();

      void Dash();

      void Move(Vector2 move);
   }
}