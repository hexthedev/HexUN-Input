using System.Collections;
using System.Collections.Generic;
using HexUN.Events;
using HexUN.Behaviour;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace HexUN.Input
{
    /// <summary>
    /// Represents a button that can be toggled on an off. Handled interpretation of button context from the input system
    /// </summary>
    public class InputToggleButton : HexBehaviour
    {
        [Header("Emissions")]
        [SerializeField]
        BooleanUnityEvent _onToggleState = new BooleanUnityEvent();

        [Header("Debugging")]
        [SerializeField]
        bool _currentState = false;

        public void RecieveButtonInput(CallbackContext context)
        {
            if (context.started)
            {
                _currentState = !_currentState;
                _onToggleState.Invoke(_currentState);
            }
        }
    }
}