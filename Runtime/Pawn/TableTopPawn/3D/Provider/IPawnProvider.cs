using TobiasCSStandard.Core;

namespace HexUN.Systems.Grid
{
    /// <summary>
    /// Provides events for a pawn view that dictate what should happen to the pawn
    /// </summary>
    public interface IPawnProvider
    {
        /// <summary>
        /// Invoked when pawn state changes (neutral, highlighted)
        /// </summary>
        IEventSubscriber<EPawnState> OnPawnState { get; }

        /// <summary>
        /// Invoked when a new pawn animation needs to play
        /// </summary>
        IEventSubscriber<EPawnBehaviour> OnPawnBehave { get; }
    }
}