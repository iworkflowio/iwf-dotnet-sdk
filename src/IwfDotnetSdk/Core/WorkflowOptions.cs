using System.Collections.Generic;
using System.Collections.Immutable;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for workflows
    /// </summary>
    public record WorkflowOptions
    {
        /// <summary>
        /// Gets the workflow ID reuse policy
        /// </summary>
        public IDReusePolicy? WorkflowIdReusePolicy { get; }

        /// <summary>
        /// Gets the cron schedule
        /// </summary>
        public string? CronSchedule { get; }

        /// <summary>
        /// Gets the workflow start delay in seconds
        /// </summary>
        public int? WorkflowStartDelaySeconds { get; }

        /// <summary>
        /// Gets the workflow retry policy
        /// </summary>
        public WorkflowRetryPolicy? WorkflowRetryPolicy { get; }

        /// <summary>
        /// Gets the initial search attributes
        /// </summary>
        public IReadOnlyDictionary<string, object> InitialSearchAttributes { get; }

        /// <summary>
        /// Gets the initial data attributes
        /// </summary>
        public IReadOnlyDictionary<string, object> InitialDataAttributes { get; }

        /// <summary>
        /// Gets the workflow config override
        /// </summary>
        public WorkflowConfig? WorkflowConfigOverride { get; }

        /// <summary>
        /// Gets the state IDs to wait for completion
        /// </summary>
        public IReadOnlyList<string> WaitForCompletionStateIds { get; }

        /// <summary>
        /// Gets the state execution IDs to wait for completion
        /// </summary>
        public IReadOnlyList<string> WaitForCompletionStateExecutionIds { get; }

        /// <summary>
        /// Gets the options for handling already started workflows
        /// </summary>
        public WorkflowAlreadyStartedOptions? WorkflowAlreadyStartedOptions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOptions"/> class
        /// </summary>
        public WorkflowOptions(
            IDReusePolicy? workflowIdReusePolicy = null,
            string? cronSchedule = null,
            int? workflowStartDelaySeconds = null,
            WorkflowRetryPolicy? workflowRetryPolicy = null,
            IDictionary<string, object>? initialSearchAttributes = null,
            IDictionary<string, object>? initialDataAttributes = null,
            WorkflowConfig? workflowConfigOverride = null,
            IEnumerable<string>? waitForCompletionStateIds = null,
            IEnumerable<string>? waitForCompletionStateExecutionIds = null,
            WorkflowAlreadyStartedOptions? workflowAlreadyStartedOptions = null)
        {
            WorkflowIdReusePolicy = workflowIdReusePolicy;
            CronSchedule = cronSchedule;
            WorkflowStartDelaySeconds = workflowStartDelaySeconds;
            WorkflowRetryPolicy = workflowRetryPolicy;
            InitialSearchAttributes = initialSearchAttributes?.ToImmutableDictionary() ?? ImmutableDictionary<string, object>.Empty;
            InitialDataAttributes = initialDataAttributes?.ToImmutableDictionary() ?? ImmutableDictionary<string, object>.Empty;
            WorkflowConfigOverride = workflowConfigOverride;
            WaitForCompletionStateIds = waitForCompletionStateIds?.ToImmutableList() ?? ImmutableList<string>.Empty;
            WaitForCompletionStateExecutionIds = waitForCompletionStateExecutionIds?.ToImmutableList() ?? ImmutableList<string>.Empty;
            WorkflowAlreadyStartedOptions = workflowAlreadyStartedOptions;
        }

        /// <summary>
        /// Creates a builder for building WorkflowOptions
        /// </summary>
        /// <returns>A new builder</returns>
        public static Builder CreateBuilder() => new Builder();

        /// <summary>
        /// Builder for WorkflowOptions
        /// </summary>
        public class Builder
        {
            private IDReusePolicy? _workflowIdReusePolicy;
            private string? _cronSchedule;
            private int? _workflowStartDelaySeconds;
            private WorkflowRetryPolicy? _workflowRetryPolicy;
            private readonly Dictionary<string, object> _initialSearchAttributes = new();
            private readonly Dictionary<string, object> _initialDataAttributes = new();
            private WorkflowConfig? _workflowConfigOverride;
            private readonly List<string> _waitForCompletionStateIds = new();
            private readonly List<string> _waitForCompletionStateExecutionIds = new();
            private WorkflowAlreadyStartedOptions? _workflowAlreadyStartedOptions;

            /// <summary>
            /// Sets the workflow ID reuse policy
            /// </summary>
            public Builder SetWorkflowIdReusePolicy(IDReusePolicy policy)
            {
                _workflowIdReusePolicy = policy;
                return this;
            }

            /// <summary>
            /// Sets the cron schedule
            /// </summary>
            public Builder SetCronSchedule(string cronSchedule)
            {
                _cronSchedule = cronSchedule;
                return this;
            }

            /// <summary>
            /// Sets the workflow start delay in seconds
            /// </summary>
            public Builder SetWorkflowStartDelaySeconds(int delaySeconds)
            {
                _workflowStartDelaySeconds = delaySeconds;
                return this;
            }

            /// <summary>
            /// Sets the workflow retry policy
            /// </summary>
            public Builder SetWorkflowRetryPolicy(WorkflowRetryPolicy retryPolicy)
            {
                _workflowRetryPolicy = retryPolicy;
                return this;
            }

            /// <summary>
            /// Adds an initial search attribute
            /// </summary>
            public Builder AddInitialSearchAttribute(string key, object value)
            {
                _initialSearchAttributes[key] = value;
                return this;
            }

            /// <summary>
            /// Adds an initial data attribute
            /// </summary>
            public Builder AddInitialDataAttribute(string key, object value)
            {
                _initialDataAttributes[key] = value;
                return this;
            }

            /// <summary>
            /// Sets the workflow config override
            /// </summary>
            public Builder SetWorkflowConfigOverride(WorkflowConfig config)
            {
                _workflowConfigOverride = config;
                return this;
            }

            /// <summary>
            /// Adds a state ID to wait for completion
            /// </summary>
            public Builder AddWaitForCompletionStateId(string stateId)
            {
                _waitForCompletionStateIds.Add(stateId);
                return this;
            }

            /// <summary>
            /// Adds a state execution ID to wait for completion
            /// </summary>
            public Builder AddWaitForCompletionStateExecutionId(string stateExecutionId)
            {
                _waitForCompletionStateExecutionIds.Add(stateExecutionId);
                return this;
            }

            /// <summary>
            /// Sets the options for handling already started workflows
            /// </summary>
            public Builder SetWorkflowAlreadyStartedOptions(WorkflowAlreadyStartedOptions options)
            {
                _workflowAlreadyStartedOptions = options;
                return this;
            }

            /// <summary>
            /// Builds the WorkflowOptions
            /// </summary>
            public WorkflowOptions Build()
            {
                return new WorkflowOptions(
                    _workflowIdReusePolicy,
                    _cronSchedule,
                    _workflowStartDelaySeconds,
                    _workflowRetryPolicy,
                    _initialSearchAttributes,
                    _initialDataAttributes,
                    _workflowConfigOverride,
                    _waitForCompletionStateIds,
                    _waitForCompletionStateExecutionIds,
                    _workflowAlreadyStartedOptions);
            }
        }
    }
}