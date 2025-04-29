using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Information about a workflow
    /// </summary>
    public record WorkflowInfo
    {
        /// <summary>
        /// Gets the workflow status
        /// </summary>
        public WorkflowStatus WorkflowStatus { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo"/> class
        /// </summary>
        /// <param name="workflowStatus">The workflow status</param>
        public WorkflowInfo(WorkflowStatus workflowStatus)
        {
            WorkflowStatus = workflowStatus;
        }

        /// <summary>
        /// Creates a builder for building a WorkflowInfo
        /// </summary>
        /// <returns>A new builder</returns>
        public static Builder CreateBuilder() => new Builder();

        /// <summary>
        /// Builder for WorkflowInfo
        /// </summary>
        public class Builder
        {
            private WorkflowStatus _workflowStatus;

            /// <summary>
            /// Sets the workflow status
            /// </summary>
            public Builder SetWorkflowStatus(WorkflowStatus status)
            {
                _workflowStatus = status;
                return this;
            }

            /// <summary>
            /// Builds the WorkflowInfo
            /// </summary>
            public WorkflowInfo Build()
            {
                return new WorkflowInfo(_workflowStatus);
            }
        }
    }
}