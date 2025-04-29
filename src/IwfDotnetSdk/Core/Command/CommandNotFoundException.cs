using System;

namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Exception thrown when a command is not found
    /// </summary>
    public class CommandNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandNotFoundException"/> class
        /// </summary>
        /// <param name="message">The error message</param>
        public CommandNotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandNotFoundException"/> class
        /// </summary>
        /// <param name="message">The error message</param>
        /// <param name="innerException">The inner exception</param>
        public CommandNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}