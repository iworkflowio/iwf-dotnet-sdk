using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Result of a timer command
    /// </summary>
    public class TimerCommandResult
    {
        /// <summary>
        /// Gets the timer status
        /// </summary>
        public TimerStatus TimerStatus { get; }

        /// <summary>
        /// Gets the command ID
        /// </summary>
        public string CommandId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerCommandResult"/> class
        /// </summary>
        /// <param name="timerStatus">The timer status</param>
        /// <param name="commandId">The command ID</param>
        public TimerCommandResult(TimerStatus timerStatus, string commandId)
        {
            TimerStatus = timerStatus;
            CommandId = commandId;
        }
    }
}