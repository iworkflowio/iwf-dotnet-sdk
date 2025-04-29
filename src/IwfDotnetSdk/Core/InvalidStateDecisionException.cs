using System;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// This indicates something goes wrong in the state decision return.
    /// </summary>
    public class InvalidStateDecisionException : WorkflowDefinitionException
    {
        public InvalidStateDecisionException(Exception cause) 
            : base(cause)
        {
        }

        public InvalidStateDecisionException(string message) 
            : base(message)
        {
        }
    }
}