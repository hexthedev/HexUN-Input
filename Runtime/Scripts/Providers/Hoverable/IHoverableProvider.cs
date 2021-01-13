using HexCS.Core;

namespace HexUN.Input
{
    /// <summary>
    /// Provides events that dictate the behaviour of a hoverable 
    /// ui element
    /// </summary>
    public interface IHoverableProvider
    {
        /// <summary>
        /// The Last hoverable event invoked by the provider
        /// </summary>
        EHoverableEvent LastHoverableEvent { get; }

        /// <summary>
        /// Invoked when a hoverable event occurs
        /// </summary>
        IEventSubscriber<EHoverableEvent> OnHoverableEvent { get; }
    }
}