using HexUN.Design;
using HexUN.Input;
using UnityEngine;

namespace HexUN.Systems.Grid
{
    public class PawnViewMaterialAnimator : APawnView
    {
        [Header("Dependencies (PawnViewMaterial)")]
        [SerializeField]
        [Tooltip("The renderer used to show the material of the hex")]
        private Renderer _renderer = default;

        [SerializeField]
        [Tooltip("The animator used to animate behaviours")]
        private Animator _animator = default;

        [SerializeField]
        [Tooltip("Color Scheme (PawnViewMaterial)")]
        private GameColorScheme _colorScheme = default;

        [Header("Options (PawnViewMaterial)")]
        [SerializeField]
        [Tooltip("Scheme when hex is neutral")]
        private ESchemeColor _neutralScheme = ESchemeColor.Primary;

        [SerializeField]
        [Tooltip("Scheme when hex is hightlighted")]
        private ESchemeColor _highlightedScheme = ESchemeColor.Secondary;

        [Header("Debugging (PawnViewMaterial)")]
        [SerializeField]
        private GameColor _neutralColor = default;

        [SerializeField]
        private GameColor _highlightedColor = default;

        private bool _isMaterialChangedSinceLastFrame = false;
        private bool _isAnimatorChangedSinceLastFrame = false;

        protected override void MonoAwake()
        {
            ResolveGameColorReferences();
        }

        protected override void HandlePawnState(EPawnState state)
        {
            _pawnState = state;
            _isMaterialChangedSinceLastFrame = true;
        }

        protected override void HandlePawnBehaviour(EPawnBehaviour behaviour)
        {
            if (_pawnBehaviour == behaviour) return;
            _pawnBehaviour = behaviour;
            _isAnimatorChangedSinceLastFrame = true;
        }

        protected override void HandleHoverableEvent(EHoverableEvent hover)
        {
            _lastHoverEvent = hover;
            _isMaterialChangedSinceLastFrame = true;
        }

        protected override void HandleInteractionState(bool interactionState)
        {
            _isInteractable = interactionState;
            _isMaterialChangedSinceLastFrame = true;
        }

        protected override void OnValidate()
        {
            base.OnValidate();
            ResolveGameColorReferences();
            ResolveMaterials();
        }

        private void LateUpdate()
        {
            if (_isMaterialChangedSinceLastFrame)
            {
                ResolveMaterials();
                _isMaterialChangedSinceLastFrame = false;
            }

            if (_isAnimatorChangedSinceLastFrame)
            {
                ResolveBehaviourAnimations();
                _isAnimatorChangedSinceLastFrame = false;
            }
        }

        private void ResolveBehaviourAnimations()
        {
            _animator.SetTrigger(_pawnBehaviour.ToString());
        }

        private void ResolveGameColorReferences()
        {
            _neutralColor = _colorScheme.GetGameColor(_neutralScheme);
            _highlightedColor = _colorScheme.GetGameColor(_highlightedScheme);
        }

        private void ResolveMaterials()
        {
            _renderer.material = ResolveScheme(_pawnState == EPawnState.Neutral ? _neutralColor : _highlightedColor);
        }

        private Material ResolveScheme(GameColor color)
        {
            if (!_isInteractable)
            {
                return color.GreyedMaterial;
            }

            switch (_lastHoverEvent)
            {
                case EHoverableEvent.Absent: return color.BaseMaterial;
                case EHoverableEvent.Down: return color.LightMaterial;
                case EHoverableEvent.Hovering: return color.DarkMaterial;
            }

            return null; // should never happen
        }
    }
}