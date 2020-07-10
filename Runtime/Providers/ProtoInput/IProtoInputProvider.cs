using TobiasCSStandard.Core;
using UnityEngine;

using Vector2 = UnityEngine.Vector2;

namespace HexUN.Input
{
    /// <summary>
    /// Provides events that follow the proto input event set
    /// </summary>
    public interface IProtoInputProvider
    {
        /// <summary>
        /// Invoked when new move input is recieved
        /// </summary>
        IEventSubscriber<Vector2> OnMove { get; }

        /// <summary>
        /// Invoked when new look input is recieved
        /// </summary>
        IEventSubscriber<Vector2> OnLook { get; }

        /// <summary>
        /// Invoked when south action button is down
        /// </summary>
        IEventSubscriber<float> OnActionSouth { get; }

        /// <summary>
        /// Invoked when north action button is down
        /// </summary>
        IEventSubscriber<float> OnActionNorth { get; }

        /// <summary>
        /// Invoked when east action button is down
        /// </summary>
        IEventSubscriber<float> OnActionEast { get; }

        /// <summary>
        /// Invoked when west action button is down
        /// </summary>
        IEventSubscriber<float> OnActionWest { get; }

        /// <summary>
        /// Invoked when east action button is down
        /// </summary>
        IEventSubscriber<float> OnTriggerRight { get; }

        /// <summary>
        /// Invoked when west action button is down
        /// </summary>
        IEventSubscriber<float> OnTriggerLeft { get; }

        /// <summary>
        /// Invoked when east action button is down
        /// </summary>
        IEventSubscriber<float> OnBumperRight { get; }

        /// <summary>
        /// Invoked when west action button is down
        /// </summary>
        IEventSubscriber<float> OnBumperLeft { get; }

        /// <summary>
        /// Invoked when east action button is down
        /// </summary>
        IEventSubscriber<float> OnStart { get; }

        /// <summary>
        /// Invoked when west action button is down
        /// </summary>
        IEventSubscriber<float> OnSelect { get; }
    }
}