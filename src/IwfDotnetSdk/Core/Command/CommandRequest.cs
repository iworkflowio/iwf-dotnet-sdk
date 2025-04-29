using System.Collections.Generic;
using System.Linq;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Request for executing commands in a workflow
    /// </summary>
    public class CommandRequest
    {
        /// <summary>
        /// Gets the commands
        /// </summary>
        public IReadOnlyList<IBaseCommand> Commands { get; }

        /// <summary>
        /// Gets the command combinations
        /// </summary>
        public IReadOnlyList<CommandCombination> CommandCombinations { get; }

        /// <summary>
        /// Gets the command waiting type
        /// </summary>
        public CommandWaitingType CommandWaitingType { get; }

        /// <summary>
        /// Empty command request will jump to decide stage immediately
        /// </summary>
        public static readonly CommandRequest Empty = new(
            commands: new List<IBaseCommand>(),
            commandCombinations: new List<CommandCombination>(),
            commandWaitingType: CommandWaitingType.ALLCOMPLETED);

        private CommandRequest(
            IEnumerable<IBaseCommand> commands,
            IEnumerable<CommandCombination> commandCombinations,
            CommandWaitingType commandWaitingType)
        {
            Commands = commands.ToList();
            CommandCombinations = commandCombinations.ToList();
            CommandWaitingType = commandWaitingType;
        }

        /// <summary>
        /// Creates a command request that waits for all commands to complete
        /// </summary>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        public static CommandRequest ForAllCommandCompleted(params IBaseCommand[] commands)
        {
            return ForAllCommandCompleted(commands.ToList());
        }

        /// <summary>
        /// Creates a command request that waits for all commands to complete
        /// </summary>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        public static CommandRequest ForAllCommandCompleted(IEnumerable<IBaseCommand> commands)
        {
            return new CommandRequest(
                commands: commands,
                commandCombinations: new List<CommandCombination>(),
                commandWaitingType: CommandWaitingType.ALLCOMPLETED);
        }

        /// <summary>
        /// Creates a command request that waits for any command to complete
        /// </summary>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        public static CommandRequest ForAnyCommandCompleted(params IBaseCommand[] commands)
        {
            return ForAnyCommandCompleted(commands.ToList());
        }

        /// <summary>
        /// Creates a command request that waits for any command to complete
        /// </summary>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        public static CommandRequest ForAnyCommandCompleted(IEnumerable<IBaseCommand> commands)
        {
            return new CommandRequest(
                commands: commands,
                commandCombinations: new List<CommandCombination>(),
                commandWaitingType: CommandWaitingType.ANYCOMPLETED);
        }

        /// <summary>
        /// Creates a command request that waits for any command combination to complete
        /// </summary>
        /// <param name="commandCombinationLists">The command combination lists</param>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        /// <remarks>
        /// Using this requires every command to have a commandId when created.
        /// </remarks>
        public static CommandRequest ForAnyCommandCombinationCompleted(
            IEnumerable<IEnumerable<string>> commandCombinationLists,
            params IBaseCommand[] commands)
        {
            return ForAnyCommandCombinationCompleted(commandCombinationLists, commands.ToList());
        }

        /// <summary>
        /// Creates a command request that waits for any command combination to complete
        /// </summary>
        /// <param name="commandCombinationLists">The command combination lists</param>
        /// <param name="commands">The commands</param>
        /// <returns>A new command request</returns>
        /// <remarks>
        /// Using this requires every command to have a commandId when created.
        /// </remarks>
        public static CommandRequest ForAnyCommandCombinationCompleted(
            IEnumerable<IEnumerable<string>> commandCombinationLists,
            IEnumerable<IBaseCommand> commands)
        {
            var commandsList = commands.ToList();
            var allNonEmptyCommandIds = commandsList
                .Where(command => command.CommandId != null)
                .Select(command => command.CommandId)
                .ToList();

            var combinations = new List<CommandCombination>();
            foreach (var commandIds in commandCombinationLists)
            {
                var commandIdsList = commandIds.ToList();
                foreach (var commandId in commandIdsList)
                {
                    if (!allNonEmptyCommandIds.Contains(commandId))
                    {
                        throw new CommandNotFoundException($"Found unknown commandId in the combination list: {commandId}");
                    }
                }
                combinations.Add(new CommandCombination(commandIds: commandIdsList));
            }

            return new CommandRequest(
                commands: commandsList,
                commandCombinations: combinations,
                commandWaitingType: CommandWaitingType.ANYCOMBINATIONCOMPLETED);
        }
    }
}