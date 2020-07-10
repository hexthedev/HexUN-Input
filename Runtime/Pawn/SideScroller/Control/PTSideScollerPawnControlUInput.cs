using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace HexUN.Pawn
{
    public class PTSideScollerPawnControlUInput : APTSideScrollerPawnControl
    {
        private const int cJumpWork = 0;
        private const int cDashWork = 1;
        private const int cMoveWork = 2;

        private Vector2 _moveVector;

        public void OnDashInput(CallbackContext context)
        {
            if (context.started) Dash();
        }

        public void OnJumpInput(CallbackContext context)
        {
            if (context.started) Jump();
        }

        public void OnMoveInput(CallbackContext context)
        {
            if (context.canceled) _moveVector = Vector2.zero;
            if (context.started || context.performed) _moveVector = context.ReadValue<Vector2>();
        }

        public override void Dash() => SendCommandIfIdle(ref _onDash, cDashWork, null);
        public override void Jump() => SendCommandIfIdle(ref _onJump, cJumpWork, null);
        public override void Move(Vector2 move) => SendCommandIfIdle(ref _onMove, cMoveWork, move);

        private void FixedUpdate()
        {
            if (_moveVector != Vector2.zero) Move(_moveVector * Time.fixedDeltaTime);
        }
    }
}