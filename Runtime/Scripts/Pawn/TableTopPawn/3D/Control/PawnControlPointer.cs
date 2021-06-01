using HexUN.Deps;
using HexUN.Input;
using UnityEngine;

namespace HexUN.Systems.Grid
{
    [SelectionBase]
    public class PawnControlPointer : APawnControl
    {
        [Header("Dependencies (PawnControlPointer)")]
        [SerializeField]
        private Object _pointerProvider = null;

        protected IPointerProvider PointerProivder;

        protected override void HexAwake()
        {
            ResolveDependencies();
            EventBindings.Add(PointerProivder.OnPointer.Subscribe(HandlePointerEvent));
        }

        private void ResolveDependencies()
        {
            UTDependency.Resolve(ref _pointerProvider, out PointerProivder, this);
        }

        private void HandlePointerEvent(EPointerEvent evt)
        {
            if (evt == EPointerEvent.Click) _onClick.Invoke();
        }
    }
}