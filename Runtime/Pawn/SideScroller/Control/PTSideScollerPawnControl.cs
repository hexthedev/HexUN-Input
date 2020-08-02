using UnityEngine;

namespace HexUN.Pawn
{
    public class PTSideScollerPawnControl: MonoBehaviour
    {
        [Header("View")]
        [SerializeField]
        private PTSideScrollerPawnViewRb2 _view;

        private Vector2 _moveVector;

        public void Dash() => _view.HandleDash();
        public void Jump() => _view.HandleJump();
        public void Move(Vector2 move) => _view.HandleMove(move);

        private void FixedUpdate()
        {
            if (_moveVector != Vector2.zero) Move(_moveVector * Time.fixedDeltaTime);
        }
    }
}