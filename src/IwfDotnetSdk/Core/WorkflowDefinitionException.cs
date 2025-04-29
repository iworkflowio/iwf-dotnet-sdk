using System;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// This indicates something goes wrong in the workflow definition
    /// </summary>
    public class WorkflowDefinitionException : Exception
    {
        public WorkflowDefinitionException(Exception cause) 
            : base("Workflow definition error", cause)
        {
        }

        public WorkflowDefinitionException(string message) 
            : base(message)
        {
        }
    }
}