using System;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// A wrapper around the generated API Context class that provides more convenient accessors
    /// and additional functionality.
    /// </summary>
    public class WorkflowContext
    {
        private readonly Context _context;

        public WorkflowContext(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Gets the workflow start timestamp in seconds since epoch.
        /// </summary>
        public long WorkflowStartTimestampSeconds => _context.WorkflowStartedTimestamp;

        /// <summary>
        /// Gets the state execution ID, if available.
        /// Only applicable for state methods (waitUntil or execute)
        /// </summary>
        public string StateExecutionId => _context.StateExecutionId;

        /// <summary>
        /// Checks if the StateExecutionId is available.
        /// </summary>
        public bool HasStateExecutionId => !string.IsNullOrEmpty(_context.StateExecutionId);

        /// <summary>
        /// Gets the workflow run ID.
        /// </summary>
        public string WorkflowRunId => _context.WorkflowRunId;

        /// <summary>
        /// Gets the workflow ID.
        /// </summary>
        public string WorkflowId => _context.WorkflowId;

        /// <summary>
        /// Gets the first attempt timestamp in seconds since epoch, if available.
        /// Only applicable for state methods (waitUntil or execute)
        /// </summary>
        public long FirstAttemptTimestampSeconds => _context.FirstAttemptTimestamp;

        /// <summary>
        /// Checks if the FirstAttemptTimestamp is available.
        /// </summary>
        public bool HasFirstAttemptTimestamp => _context.FirstAttemptTimestamp > 0;

        /// <summary>
        /// Gets the attempt number.
        /// Attempt starts from 1, and increased by 1 for every retry if retry policy is specified.
        /// </summary>
        public int Attempt => _context.Attempt;

        /// <summary>
        /// Checks if the Attempt is available.
        /// </summary>
        public bool HasAttempt => _context.Attempt > 0;

        /// <summary>
        /// Provides access to the underlying API Context object.
        /// </summary>
        public Context ApiContext => _context;
    }
}