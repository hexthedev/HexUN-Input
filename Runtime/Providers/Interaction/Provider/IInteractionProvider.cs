using HexCS.Core;

namespace HexUN.Input
{
    /// <summary>
    /// Provides basic interaction state info
    /// </summary>
    public interface IInteractionProvider
    {
        /// <summary>
        /// Invoked when the interaction state changes
        /// </summary>
        IEventSubscriber<bool> OnInteractionState { get; }

        /// <summary>
        /// Get or set interactability
        /// </summary>
        bool IsInteractable { get; }
    }
}