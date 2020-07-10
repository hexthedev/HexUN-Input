using System.Collections;
using System.Collections.Generic;
using TobiasCSStandard.Core;
using HexUN.Events;
using HexUN.MonoB;
using UnityEngine;

namespace HexUN.Input
{
    /// <summary>
    /// Abstract base class for providing proto input commands
    /// </summary>
    public abstract class AProtoInputProvider : MonoEnhanced, IProtoInputProvider
    {
        [Header("Emissions (AProtoInputProvider)")]
        [SerializeField]
        protected Vector2ReliableEvent _onMove = new Vector2ReliableEvent();

        [SerializeField]
        protected Vector2ReliableEvent _onLook = new Vector2ReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onActionSouth = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onActionNorth = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onActionEast = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onActionWest = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onTriggerRight = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onTriggerLeft = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onBumperRight= new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onBumperLeft = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onStart = new SingleReliableEvent();

        [SerializeField]
        protected SingleReliableEvent _onSelect = new SingleReliableEvent();

        /// <inheritdoc />
        public IEventSubscriber<UnityEngine.Vector2> OnMove => OnMove;

        /// <inheritdoc />
        public IEventSubscriber<UnityEngine.Vector2> OnLook => OnLook;

        /// <inheritdoc />
        public IEventSubscriber<float> OnActionSouth => _onActionSouth;

        /// <inheritdoc />
        public IEventSubscriber<float> OnActionNorth => _onActionNorth;

        /// <inheritdoc />
        public IEventSubscriber<float> OnActionEast => _onActionEast;

        /// <inheritdoc />
        public IEventSubscriber<float> OnActionWest => _onActionWest;

        /// <inheritdoc />
        public IEventSubscriber<float> OnTriggerRight => _onTriggerRight;

        /// <inheritdoc />
        public IEventSubscriber<float> OnTriggerLeft => _onTriggerLeft;

        /// <inheritdoc />
        public IEventSubscriber<float> OnBumperRight => _onBumperRight;

        /// <inheritdoc />
        public IEventSubscriber<float> OnBumperLeft => _onBumperLeft;

        /// <inheritdoc />
        public IEventSubscriber<float> OnStart => _onStart;

        /// <inheritdoc />
        public IEventSubscriber<float> OnSelect => _onSelect;
    }
}