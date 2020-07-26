using UnityEngine;
using HexUN.MonoB;
using HexUN.Deps;
using HexUN.Patterns;
using HexCS.Core;

namespace HexUN.Pawn
{
   public class PTSideScrollerPawnProviderEventListener : MonoDependent
   {
      [SerializeField]
      private Object _pTSideScrollerPawnProviderObject = null;

      private IPTSideScrollerPawnProvider _pTSideScrollerPawnProvider;

      [SerializeField]
      private CVCommandUnityEvent _onJumpEvent = null;

      [SerializeField]
      private CVCommandUnityEvent _onDashEvent = null;

      [SerializeField]
      private CVCommandUnityEvent _onMoveEvent = null;

      protected override void ResolveDependencies()
      {
         UTDependency.Resolve(ref _pTSideScrollerPawnProviderObject, out _pTSideScrollerPawnProvider, this, true);
      }

      protected override void ResolveEventBindings(EventBindingGroup ebs)
      {
         if (_pTSideScrollerPawnProvider != null)
         {
         	ebs.Add(_pTSideScrollerPawnProvider.OnJump.Subscribe(_onJumpEvent.Invoke));
         	ebs.Add(_pTSideScrollerPawnProvider.OnDash.Subscribe(_onDashEvent.Invoke));
         	ebs.Add(_pTSideScrollerPawnProvider.OnMove.Subscribe(_onMoveEvent.Invoke));
         }
      }

   }
}