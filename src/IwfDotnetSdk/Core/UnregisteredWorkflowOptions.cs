using System.Collections.Generic;
using System.Collections.Immutable;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for unregistered workflows
    /// </summary>
    public record UnregisteredWorkflowOptions
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
        /// Gets the start state options
        /// </summary>
        public WorkflowStateOptions? StartStateOptions { get; }

        /// <summary>
        /// Gets the initial search attributes
        /// </summary>
        public IReadOnlyList<SearchAttribute> InitialSearchAttributes { get; }

        /// <summary>
        /// Gets the initial data attributes
        /// </summary>
        public IReadOnlyDictionary<string, object> InitialDataAttributes { get; }

        /// <summary>
        /// Gets the workflow config override
        /// </summary>
        public WorkflowConfig? WorkflowConfigOverride { get; }

        /// <summary>
        /// Gets whether to use memo for data attributes
        /// </summary>
        public bool? UseMemoForDataAttributes { get; }

        /// <summary>
        /// Gets the state execution IDs to wait for completion
        /// </summary>
        public IReadOnlyList<string> WaitForCompletionStateExecutionIds { get; }

        /// <summary>
        /// Gets the state IDs to wait for completion
        /// </summary>
        public IReadOnlyList<string> WaitForCompletionStateIds { get; }

        /// <summary>
        /// Gets the options for handling already started workflows
        /// </summary>
        public WorkflowAlreadyStartedOptions? WorkflowAlreadyStartedOptions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnregisteredWorkflowOptions"/> class
        /// </summary>
        public UnregisteredWorkflowOptions(
            IDReusePolicy? workflowIdReusePolicy = null,
            string? cronSchedule = null,
            int? workflowStartDelaySeconds = null,
            WorkflowRetryPolicy? workflowRetryPolicy = null,
            WorkflowStateOptions? startStateOptions = null,
            IEnumerable<SearchAttribute>? initialSearchAttributes = null,
            IDictionary<string, object>? initialDataAttributes = null,
            WorkflowConfig? workflowConfigOverride = null,
            bool? useMemoForDataAttributes = null,
            IEnumerable<string>? waitForCompletionStateExecutionIds = null,
            IEnumerable<string>? waitForCompletionStateIds = null,
            WorkflowAlreadyStartedOptions? workflowAlreadyStartedOptions = null)
        {
            WorkflowIdReusePolicy = workflowIdReusePolicy;
            CronSchedule = cronSchedule;
            WorkflowStartDelaySeconds = workflowStartDelaySeconds;
            WorkflowRetryPolicy = workflowRetryPolicy;
            StartStateOptions = startStateOptions;
            InitialSearchAttributes = initialSearchAttributes?.ToImmutableList() ?? ImmutableList<SearchAttribute>.Empty;
            InitialDataAttributes = initialDataAttributes?.ToImmutableDictionary() ?? ImmutableDictionary<string, object>.Empty;
            WorkflowConfigOverride = workflowConfigOverride;
            UseMemoForDataAttributes = useMemoForDataAttributes;
            WaitForCompletionStateExecutionIds = waitForCompletionStateExecutionIds?.ToImmutableList() ?? ImmutableList<string>.Empty;
            WaitForCompletionStateIds = waitForCompletionStateIds?.ToImmutableList() ?? ImmutableList<string>.Empty;
            WorkflowAlreadyStartedOptions = workflowAlreadyStartedOptions;
        }

        /// <summary>
        /// Creates a builder for building UnregisteredWorkflowOptions
        /// </summary>
        /// <returns>A new builder</returns>
        public static Builder CreateBuilder() => new Builder();

        /// <summary>
        /// Builder for UnregisteredWorkflowOptions
        /// </summary>
        public class Builder
        {
            private IDReusePolicy? _workflowIdReusePolicy;
            private string? _cronSchedule;
            private int? _workflowStartDelaySeconds;
            private WorkflowRetryPolicy? _workflowRetryPolicy;
            private WorkflowStateOptions? _startStateOptions;
            private readonly List<SearchAttribute> _initialSearchAttributes = new();
            private readonly Dictionary<string, object> _initialDataAttributes = new();
            private WorkflowConfig? _workflowConfigOverride;
            private bool? _useMemoForDataAttributes;
            private readonly List<string> _waitForCompletionStateExecutionIds = new();
            private readonly List<string> _waitForCompletionStateIds = new();
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
            /// Sets the start state options
            /// </summary>
            public Builder SetStartStateOptions(WorkflowStateOptions stateOptions)
            {
                _startStateOptions = stateOptions;
                return this;
            }

            /// <summary>
            /// Adds an initial search attribute
            /// </summary>
            public Builder AddInitialSearchAttribute(SearchAttribute searchAttribute)
            {
                _initialSearchAttributes.Add(searchAttribute);
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
            /// Sets whether to use memo for data attributes
            /// </summary>
            public Builder SetUseMemoForDataAttributes(bool useMemo)
            {
                _useMemoForDataAttributes = useMemo;
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
            /// Adds a state ID to wait for completion
            /// </summary>
            public Builder AddWaitForCompletionStateId(string stateId)
            {
                _waitForCompletionStateIds.Add(stateId);
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
            /// Builds the UnregisteredWorkflowOptions
            /// </summary>
            public UnregisteredWorkflowOptions Build()
            {
                return new UnregisteredWorkflowOptions(
                    _workflowIdReusePolicy,
                    _cronSchedule,
                    _workflowStartDelaySeconds,
                    _workflowRetryPolicy,
                    _startStateOptions,
                    _initialSearchAttributes,
                    _initialDataAttributes,
                    _workflowConfigOverride,
                    _useMemoForDataAttributes,
                    _waitForCompletionStateExecutionIds,
                    _waitForCompletionStateIds,
                    _workflowAlreadyStartedOptions);
            }
        }
    }
}