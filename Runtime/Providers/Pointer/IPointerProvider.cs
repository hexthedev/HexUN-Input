using HexCS.Core;

namespace HexUN.Input
{
    /// <summary>
    /// Provides interaction state info and pointer events
    /// </summary>
    public interface IPointerProvider
    {
        /// <summary>
        /// What was the last pointer event
        /// </summary>
        EPointerEvent LastPointerEvent { get; }

        /// <summary>
        /// Invoked when a pointer event occurs
        /// </summary>
        IEventSubscriber<EPointerEvent> OnPointer { get; }
    }
}
