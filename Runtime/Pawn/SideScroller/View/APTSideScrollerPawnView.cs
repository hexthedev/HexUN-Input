using UnityEngine;
using HexUN.MonoB;
using HexUN.Patterns;
using HexUN.Deps;
using TobiasCSStandard.Core;

namespace HexUN.Pawn
{
   public abstract class APTSideScrollerPawnView : MonoDependent
   {
      [Header("Dependencies (APTSideScrollerPawnView)")]
      [SerializeField]
      private Object _pTSideScrollerPawnProviderGeneric = null;

      private IPTSideScrollerPawnProvider _pTSideScrollerPawnProvider;

      protected override void ResolveDependencies()
      {
         UTDependency.Resolve(ref _pTSideScrollerPawnProviderGeneric, out _pTSideScrollerPawnProvider, this);
      }

      protected override void ResolveEventBindings(EventBindingGroup ebs)
      {
         ebs.Add(_pTSideScrollerPawnProvider.OnJump.Subscribe(HandleJump));
         ebs.Add(_pTSideScrollerPawnProvider.OnDash.Subscribe(HandleDash));
         ebs.Add(_pTSideScrollerPawnProvider.OnMove.Subscribe(HandleMove));
      }

      public abstract void HandleJump(CVCommand command);

      public abstract void HandleDash(CVCommand command);

      public abstract void HandleMove(CVCommand command);

   }
}