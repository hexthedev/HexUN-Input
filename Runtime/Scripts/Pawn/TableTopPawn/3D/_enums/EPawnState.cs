using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexUN.Systems.Grid
{
    /// <summary>
    /// Enumerates possible states of pawns
    /// </summary>
    public enum EPawnState
    {
        /// <summary>
        /// The pawn is in a neutral state
        /// </summary>
        Neutral,

        /// <summary>
        /// The pawn is being highlighted for some reason
        /// </summary>
        Highlighted
    }
}