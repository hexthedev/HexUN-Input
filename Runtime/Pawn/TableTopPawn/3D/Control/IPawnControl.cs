using HexUN.Events;
using HexUN.Input;

namespace HexUN.Systems.Grid
{
    /// <summary>
    /// Defines requirements of a Pawn Control
    /// </summary>
    public interface IPawnControl : IInteractionProvider, IClickProvider, IPawnProvider
    {
        /// <summary>
        /// The stat eof the current pawn
        /// </summary>
        EPawnState PawnState { get; }

        /// <summary>
        /// The behaviour of the current pawn
        /// </summary>
        EPawnBehaviour PawnBehaviour { get; }

        /// <summary>
        /// Set the state of the current pawn
        /// </summary>
        /// <param name="state"></param>
        void SetPawnState(EPawnState state);

        /// <summary>
        /// Set the behaviour of the current pawn
        /// </summary>
        /// <param name="state"></param>
        void SetPawnBehaviour(EPawnBehaviour state);
    }
}