namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Result of an internal channel command
    /// </summary>
    public class InternalChannelCommandResult
    {
        /// <summary>
        /// Gets the command ID
        /// </summary>
        public string CommandId { get; }

        /// <summary>
        /// Gets the channel value
        /// </summary>
        public object? ChannelValue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalChannelCommandResult"/> class
        /// </summary>
        /// <param name="commandId">The command ID</param>
        /// <param name="channelValue">The channel value</param>
        public InternalChannelCommandResult(string commandId, object? channelValue)
        {
            CommandId = commandId;
            ChannelValue = channelValue;
        }
    }
}