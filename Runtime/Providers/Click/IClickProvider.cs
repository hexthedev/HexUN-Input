using TobiasCSStandard.Core;

namespace HexUN.Input
{
    /// <summary>
    /// Provides a lcik event
    /// </summary>
    public interface IClickProvider
    {
        /// <summary>
        /// Invoked when the provider is clicked
        /// </summary>
        IEventSubscriber OnClick { get; }
    }
}