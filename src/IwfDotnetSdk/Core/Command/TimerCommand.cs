using System;

namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Command for a timer in a workflow
    /// </summary>
    public class TimerCommand : IBaseCommand
    {
        /// <summary>
        /// Gets the command ID
        /// </summary>
        public string? CommandId { get; }

        /// <summary>
        /// Gets the duration in seconds
        /// </summary>
        public long DurationSeconds { get; }

        private TimerCommand(string? commandId, long durationSeconds)
        {
            CommandId = commandId;
            DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Creates a timer command with the specified duration and command ID
        /// </summary>
        /// <param name="commandId">The command ID</param>
        /// <param name="duration">The duration</param>
        /// <returns>A new timer command</returns>
        public static TimerCommand CreateByDuration(string commandId, TimeSpan duration)
        {
            return new TimerCommand(commandId, (long)duration.TotalSeconds);
        }

        /// <summary>
        /// Creates a timer command with the specified duration
        /// </summary>
        /// <param name="duration">The duration</param>
        /// <returns>A new timer command</returns>
        public static TimerCommand CreateByDuration(TimeSpan duration)
        {
            return new TimerCommand(null, (long)duration.TotalSeconds);
        }

        /// <summary>
        /// Creates a timer command with the specified duration in seconds and command ID
        /// </summary>
        /// <param name="commandId">The command ID</param>
        /// <param name="durationSeconds">The duration in seconds</param>
        /// <returns>A new timer command</returns>
        public static TimerCommand CreateByDurationSeconds(string commandId, long durationSeconds)
        {
            return new TimerCommand(commandId, durationSeconds);
        }

        /// <summary>
        /// Creates a timer command with the specified duration in seconds
        /// </summary>
        /// <param name="durationSeconds">The duration in seconds</param>
        /// <returns>A new timer command</returns>
        public static TimerCommand CreateByDurationSeconds(long durationSeconds)
        {
            return new TimerCommand(null, durationSeconds);
        }
    }
}