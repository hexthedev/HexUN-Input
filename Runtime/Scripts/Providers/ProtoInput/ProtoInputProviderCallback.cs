using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace HexUN.Input
{
    /// <summary>
    /// Provides input by exposing public functions that can recieve
    /// callbacks from a unity input system player input
    /// </summary>
    public class ProtoInputProviderCallback : AProtoInputProvider
    {
        private byte[] _moveBuffer = new byte[sizeof(float)];

        public void HandleMove(CallbackContext context)
        {
            Vector2 move = context.ReadValue<Vector2>();
            Debug.Log(move);
        }
    }
}