using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexUN.Input
{
    /// <summary>
    /// Describes an interaction that can happen with a pointer.
    /// This is like a mouse cursor for example
    /// </summary>
    public enum EPointerEvent
    {
        /// <summary>
        /// The pointer has clicked the 
        /// </summary>
        Click = 0,

        /// <summary>
        /// The pointer has entered the interactable area
        /// </summary>
        Enter = 1,

        /// <summary>
        /// The pointer is presssed down
        /// </summary>
        Down = 2,

        /// <summary>
        /// The pointer press has been released
        /// </summary>
        Up = 3,

        /// <summary>
        /// The pointer has exited the interactable area
        /// </summary>
        Exit = 4
    }
}