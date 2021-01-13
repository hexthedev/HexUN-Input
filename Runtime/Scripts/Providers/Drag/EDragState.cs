namespace HexUN.Input
{
    public enum EDragState
    {
        /// <summary>
        /// The draggable is not being dragged
        /// </summary>
        Idle = 0,

        /// <summary>
        /// The draggable is being dragged
        /// </summary>
        Dragging = 1,

        /// <summary>
        /// The frame that the first drag occurs
        /// </summary>
        Begin = 2
    }
}
