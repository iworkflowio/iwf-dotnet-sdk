namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Result of a signal command
    /// </summary>
    public class SignalCommandResult
    {
        /// <summary>
        /// Gets the command ID
        /// </summary>
        public string CommandId { get; }

        /// <summary>
        /// Gets the signal value
        /// </summary>
        public object? SignalValue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCommandResult"/> class
        /// </summary>
        /// <param name="commandId">The command ID</param>
        /// <param name="signalValue">The signal value</param>
        public SignalCommandResult(string commandId, object? signalValue)
        {
            CommandId = commandId;
            SignalValue = signalValue;
        }
    }
}