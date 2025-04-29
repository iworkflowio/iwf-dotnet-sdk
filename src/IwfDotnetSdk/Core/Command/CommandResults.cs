using System;
using System.Collections.Generic;
using System.Linq;

namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Container for all requested commands' results/statuses
    /// </summary>
    public class CommandResults
    {
        /// <summary>
        /// Gets all signal command results
        /// </summary>
        public IReadOnlyList<SignalCommandResult> AllSignalCommandResults { get; }

        /// <summary>
        /// Gets all timer command results
        /// </summary>
        public IReadOnlyList<TimerCommandResult> AllTimerCommandResults { get; }

        /// <summary>
        /// Gets all internal channel command results
        /// </summary>
        public IReadOnlyList<InternalChannelCommandResult> AllInternalChannelCommandResults { get; }

        /// <summary>
        /// Gets whether the wait until API succeeded
        /// </summary>
        public bool? WaitUntilApiSucceeded { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandResults"/> class
        /// </summary>
        /// <param name="signalCommandResults">The signal command results</param>
        /// <param name="timerCommandResults">The timer command results</param>
        /// <param name="internalChannelCommandResults">The internal channel command results</param>
        /// <param name="waitUntilApiSucceeded">Whether the wait until API succeeded</param>
        public CommandResults(
            IEnumerable<SignalCommandResult>? signalCommandResults = null,
            IEnumerable<TimerCommandResult>? timerCommandResults = null,
            IEnumerable<InternalChannelCommandResult>? internalChannelCommandResults = null,
            bool? waitUntilApiSucceeded = null)
        {
            AllSignalCommandResults = signalCommandResults?.ToList() ?? new List<SignalCommandResult>();
            AllTimerCommandResults = timerCommandResults?.ToList() ?? new List<TimerCommandResult>();
            AllInternalChannelCommandResults = internalChannelCommandResults?.ToList() ?? new List<InternalChannelCommandResult>();
            WaitUntilApiSucceeded = waitUntilApiSucceeded;
        }

        /// <summary>
        /// Gets a signal value by index
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="index">The index</param>
        /// <returns>The signal value</returns>
        public T GetSignalValueByIndex<T>(int index)
        {
            if (index < 0 || index >= AllSignalCommandResults.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var result = AllSignalCommandResults[index];
            if (result.SignalValue == null)
            {
                return default!;
            }

            return (T)result.SignalValue;
        }

        /// <summary>
        /// Gets a signal value by command ID
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="commandId">The command ID</param>
        /// <returns>The signal value</returns>
        public T GetSignalValueById<T>(string commandId)
        {
            foreach (var result in AllSignalCommandResults)
            {
                if (result.CommandId.Equals(commandId, StringComparison.Ordinal))
                {
                    if (result.SignalValue == null)
                    {
                        return default!;
                    }

                    return (T)result.SignalValue;
                }
            }

            throw new CommandNotFoundException($"Command ID not found: {commandId}");
        }

        /// <summary>
        /// Gets an internal channel value by index
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="index">The index</param>
        /// <returns>The channel value</returns>
        public T GetInternalChannelValueByIndex<T>(int index)
        {
            if (index < 0 || index >= AllInternalChannelCommandResults.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var result = AllInternalChannelCommandResults[index];
            if (result.ChannelValue == null)
            {
                return default!;
            }

            return (T)result.ChannelValue;
        }

        /// <summary>
        /// Gets an internal channel value by command ID
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="commandId">The command ID</param>
        /// <returns>The channel value</returns>
        public T GetInternalChannelValueById<T>(string commandId)
        {
            foreach (var result in AllInternalChannelCommandResults)
            {
                if (result.CommandId.Equals(commandId, StringComparison.Ordinal))
                {
                    if (result.ChannelValue == null)
                    {
                        return default!;
                    }

                    return (T)result.ChannelValue;
                }
            }

            throw new CommandNotFoundException($"Command ID not found: {commandId}");
        }
    }
}