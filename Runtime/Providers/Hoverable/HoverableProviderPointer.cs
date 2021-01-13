using HexUN.Deps;
using UnityEngine;

namespace HexUN.Input.Hoverable
{
    /// <summary>
    /// Provides hoverable events via interpretation of Pointer Events from an IPointerProvider
    /// </summary>
    public class HoverableProviderPointer : AHoverableProvider
    {
        [Header("Dependencies (HoverableProviderPointer)")]
        [SerializeField]
        private Object _pointerProviderObject = null;
        
        private IPointerProvider _pointerProvider;
        private bool _isPointerOver = false;

        /// <inheritdoc />
        protected override void MonoAwake()
        {
            base.MonoAwake();
            ResolveDependencies();
            if (_pointerProvider != null) EventBindings.Add(_pointerProvider.OnPointer.Subscribe(HandlePointerEvent));
        }

        protected override void OnValidate()
        {
            base.OnValidate();
            ResolveDependencies();
        }

        private void ResolveDependencies()
        {
            UTDependency.Resolve(ref _pointerProviderObject, out _pointerProvider, this);
        }

        private void HandlePointerEvent(EPointerEvent pointerEvent)
        {
#if HEXDB
            if (Log != null) Log.Invoke($"Hoverable on gameobject {gameObject} logged event {pointerEvent}");
#endif

            switch (pointerEvent)
            {
                case EPointerEvent.Down:
                    HoverableEvent.Invoke(EHoverableEvent.Down);
                    break;
                case EPointerEvent.Enter:
                    _isPointerOver = true;
                    HoverableEvent.Invoke(EHoverableEvent.Hovering);
                    break;
                case EPointerEvent.Exit:
                    _isPointerOver = false;
                    HoverableEvent.Invoke(EHoverableEvent.Absent);
                    break;
                case EPointerEvent.Up:
                    HoverableEvent.Invoke(_isPointerOver ? EHoverableEvent.Hovering : EHoverableEvent.Absent);
                    break;
            }
        }
    }
}
