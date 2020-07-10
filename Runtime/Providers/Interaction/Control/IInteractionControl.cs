namespace HexUN.Input
{
    /// <summary>
    /// Provides basic interaction state info
    /// </summary>
    public interface IInteractionControl : IInteractionProvider
    {
        /// <summary>
        /// Set the interactability of the interaction control
        /// </summary>
        /// <param name="isInteractable"></param>
        void SetInteractable(bool isInteractable);
    }
}