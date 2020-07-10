namespace HexUN.Input
{
    /// <summary>
    /// Events defining type of cursor interactions
    /// </summary>
    public enum EHoverableEvent
    {
        /// <summary>
        /// The cursor is hovering over the element
        /// </summary>
        Hovering = 0,

        /// <summary>
        /// The cursor is clicking, or down, on the element
        /// </summary>
        Down = 1,

        /// <summary>
        /// The cursor is not over the element
        /// </summary>
        Absent = 2,
    }
}