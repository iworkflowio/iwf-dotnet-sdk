using System;
using System.Collections.Generic;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Exception thrown when a workflow is not completed
    /// </summary>
    public class WorkflowUncompletedException : Exception
    {
        /// <summary>
        /// Gets the workflow run ID
        /// </summary>
        public string RunId { get; }

        /// <summary>
        /// Gets the workflow status
        /// </summary>
        public WorkflowStatus ClosedStatus { get; }

        /// <summary>
        /// Gets the error type
        /// Today, this only applies to FAILED as closedStatus to differentiate different failed types
        /// </summary>
        public WorkflowErrorType? ErrorSubType { get; }

        /// <summary>
        /// Gets the error message
        /// </summary>
        public string? ErrorMessage { get; }

        /// <summary>
        /// Gets the state results
        /// </summary>
        private readonly List<StateCompletionOutput> _stateResults;

        /// <summary>
        /// Gets the object encoder
        /// </summary>
        private readonly IObjectEncoder _encoder;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUncompletedException"/> class
        /// </summary>
        /// <param name="runId">The workflow run ID</param>
        /// <param name="closedStatus">The workflow status</param>
        /// <param name="errorType">The error type</param>
        /// <param name="errorMessage">The error message</param>
        /// <param name="stateResults">The state results</param>
        /// <param name="encoder">The object encoder</param>
        public WorkflowUncompletedException(
            string runId,
            WorkflowStatus closedStatus,
            WorkflowErrorType? errorType,
            string? errorMessage,
            List<StateCompletionOutput>? stateResults,
            IObjectEncoder encoder)
            : base($"Workflow with runId {runId} is not completed, status: {closedStatus}")
        {
            RunId = runId;
            ClosedStatus = closedStatus;
            ErrorSubType = errorType;
            ErrorMessage = errorMessage;
            _stateResults = stateResults ?? new List<StateCompletionOutput>();
            _encoder = encoder;
        }

        /// <summary>
        /// Gets the number of state results
        /// </summary>
        public int StateResultsCount => _stateResults.Count;

        /// <summary>
        /// Gets a state result at the specified index
        /// </summary>
        /// <typeparam name="T">The type to deserialize to</typeparam>
        /// <param name="index">The index</param>
        /// <returns>The deserialized state result</returns>
        public T? GetStateResult<T>(int index)
        {
            if (index < 0 || index >= _stateResults.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var output = _stateResults[index];
            if (output.CompletedStateOutput == null)
            {
                return default;
            }

            return _encoder.Decode<T>(output.CompletedStateOutput);
        }
    }
}