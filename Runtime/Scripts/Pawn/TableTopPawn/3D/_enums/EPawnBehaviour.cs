using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexUN.Systems.Grid {
    /// <summary>
    /// Sets the behaviour of the current pawn. This normally triggers the running
    /// of an animation, or particles effect. or something.
    /// </summary>
    public enum EPawnBehaviour
    {
        /// <summary>
        /// No visual movement plays 
        /// </summary>
        None, 

        /// <summary>
        /// The pawn is idling
        /// </summary>
        Idle,

        /// <summary>
        /// The pawn is moving
        /// </summary>
        Moving,

        /// <summary>
        /// The pawn is attacking
        /// </summary>
        Attacking,

        /// <summary>
        /// The pawn is dieing
        /// </summary>
        Dieing,

        /// <summary>
        /// Custom 1
        /// </summary>
        Custom1,

        /// <summary>
        /// Custom 2
        /// </summary>
        Custom2,

        /// <summary>
        /// Custom 3
        /// </summary>
        Custom3,

        /// <summary>
        /// Custom 4
        /// </summary>
        Custom4,

        /// <summary>
        /// Custom 5
        /// </summary>
        Custom5,
    }
}