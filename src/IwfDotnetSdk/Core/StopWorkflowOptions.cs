using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for stopping a workflow
    /// </summary>
    public record StopWorkflowOptions
    {
        /// <summary>
        /// Gets the workflow stop type
        /// </summary>
        public WorkflowStopType? WorkflowStopType { get; }

        /// <summary>
        /// Gets the reason for stopping the workflow
        /// </summary>
        public string? Reason { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopWorkflowOptions"/> class
        /// </summary>
        /// <param name="workflowStopType">The workflow stop type</param>
        /// <param name="reason">The reason for stopping the workflow</param>
        public StopWorkflowOptions(WorkflowStopType? workflowStopType = null, string? reason = null)
        {
            WorkflowStopType = workflowStopType;
            Reason = reason;
        }
    }
}