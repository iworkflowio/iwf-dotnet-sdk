using System;
using System.Collections.Generic;
using System.Linq;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for workflow states
    /// </summary>
    public class WorkflowStateOptions : ICloneable
    {
        /// <summary>
        /// Gets or sets the loading policy for search attributes, applies to both Wait Until and Execute API
        /// </summary>
        public PersistenceLoadingPolicy? SearchAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the loading policy for search attributes, applies only to Wait Until API
        /// </summary>
        public PersistenceLoadingPolicy? WaitUntilApiSearchAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the loading policy for search attributes, applies only to Execute API
        /// </summary>
        public PersistenceLoadingPolicy? ExecuteApiSearchAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the loading policy for data attributes, applies to both Wait Until and Execute API
        /// </summary>
        public PersistenceLoadingPolicy? DataAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the loading policy for data attributes, applies only to Wait Until API
        /// </summary>
        public PersistenceLoadingPolicy? WaitUntilApiDataAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the loading policy for data attributes, applies only to Execute API
        /// </summary>
        public PersistenceLoadingPolicy? ExecuteApiDataAttributesLoadingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds for the Wait Until API
        /// </summary>
        public int? WaitUntilApiTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or sets the retry policy for the Wait Until API
        /// </summary>
        public RetryPolicy? WaitUntilApiRetryPolicy { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds for the Execute API
        /// </summary>
        public int? ExecuteApiTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or sets the retry policy for the Execute API
        /// </summary>
        public RetryPolicy? ExecuteApiRetryPolicy { get; set; }

        /// <summary>
        /// Gets or sets whether to proceed to the Execute API after Wait Until API has exhausted all retries
        /// </summary>
        public bool? ProceedToExecuteWhenWaitUntilRetryExhausted { get; set; }

        /// <summary>
        /// Gets or sets the type of the state to proceed to when Execute API has exhausted all retries
        /// </summary>
        public Type? ProceedToStateWhenExecuteRetryExhaustedType { get; set; }

        /// <summary>
        /// Gets or sets the options to use when proceeding to the configured state after Execute API retry is exhausted
        /// </summary>
        public WorkflowStateOptions? ProceedToStateWhenExecuteRetryExhaustedStateOptions { get; set; }

        /// <summary>
        /// Sets whether to proceed to the Execute API after Wait Until API has exhausted all retries
        /// </summary>
        /// <param name="proceed">True to proceed to the Execute API, false to fail</param>
        /// <returns>This instance for method chaining</returns>
        /// <remarks>
        /// By default, workflow would fail after waitUntil API retry exhausted.
        /// This policy is to allow proceeding to the execute API after waitUntil API exhausted all retries.
        /// This is useful for some advanced use cases like SAGA pattern.
        /// RetryPolicy is required to be set with maximumAttempts or maximumAttemptsDurationSeconds for waitUntil API.
        /// NOTE: execute API will use commandResults to check whether the waitUntil has succeeded or not.
        /// </remarks>
        public WorkflowStateOptions SetProceedToExecuteWhenWaitUntilRetryExhausted(bool proceed)
        {
            ProceedToExecuteWhenWaitUntilRetryExhausted = proceed;
            return this;
        }

        /// <summary>
        /// Sets the state to proceed to when Execute API has exhausted all retries
        /// </summary>
        /// <param name="stateType">The type of the state</param>
        /// <returns>This instance for method chaining</returns>
        /// <remarks>
        /// By default, workflow would fail after execute API retry exhausted.
        /// Set the state to proceed to the specified state after the execute API exhausted all retries
        /// This is useful for some advanced use cases like SAGA pattern.
        /// RetryPolicy is required to be set with maximumAttempts or maximumAttemptsDurationSeconds for execute API.
        /// Note that the failure handling state will take the same input as the failed from state.
        /// </remarks>
        public WorkflowStateOptions SetProceedToStateWhenExecuteRetryExhausted(Type stateType)
        {
            return SetProceedToStateWhenExecuteRetryExhausted(stateType, null);
        }

        /// <summary>
        /// Sets the state to proceed to when Execute API has exhausted all retries
        /// </summary>
        /// <param name="stateType">The type of the state</param>
        /// <param name="stateOptionsOverride">The state options override to use</param>
        /// <returns>This instance for method chaining</returns>
        /// <remarks>
        /// By default, workflow would fail after execute API retry exhausted.
        /// Set the state to proceed to the specified state after the execute API exhausted all retries
        /// This is useful for some advanced use cases like SAGA pattern.
        /// RetryPolicy is required to be set with maximumAttempts or maximumAttemptsDurationSeconds for execute API.
        /// Note that the failure handling state will take the same input as the failed from state.
        /// </remarks>
        public WorkflowStateOptions SetProceedToStateWhenExecuteRetryExhausted(Type stateType, WorkflowStateOptions? stateOptionsOverride)
        {
            ProceedToStateWhenExecuteRetryExhaustedType = stateType;
            ProceedToStateWhenExecuteRetryExhaustedStateOptions = stateOptionsOverride;
            return this;
        }

        /// <summary>
        /// Creates a deep clone of this instance
        /// </summary>
        /// <returns>A new instance with the same property values</returns>
        public object Clone()
        {
            var clone = new WorkflowStateOptions
            {
                SearchAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(SearchAttributesLoadingPolicy),
                WaitUntilApiSearchAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(WaitUntilApiSearchAttributesLoadingPolicy),
                ExecuteApiSearchAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(ExecuteApiSearchAttributesLoadingPolicy),
                DataAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(DataAttributesLoadingPolicy),
                WaitUntilApiDataAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(WaitUntilApiDataAttributesLoadingPolicy),
                ExecuteApiDataAttributesLoadingPolicy = ClonePersistenceLoadingPolicy(ExecuteApiDataAttributesLoadingPolicy),
                WaitUntilApiTimeoutSeconds = WaitUntilApiTimeoutSeconds,
                ExecuteApiTimeoutSeconds = ExecuteApiTimeoutSeconds,
                WaitUntilApiRetryPolicy = CloneRetryPolicy(WaitUntilApiRetryPolicy),
                ExecuteApiRetryPolicy = CloneRetryPolicy(ExecuteApiRetryPolicy),
                ProceedToExecuteWhenWaitUntilRetryExhausted = ProceedToExecuteWhenWaitUntilRetryExhausted,
                ProceedToStateWhenExecuteRetryExhaustedType = ProceedToStateWhenExecuteRetryExhaustedType,
                ProceedToStateWhenExecuteRetryExhaustedStateOptions = (WorkflowStateOptions?)ProceedToStateWhenExecuteRetryExhaustedStateOptions?.Clone()
            };

            return clone;
        }

        private static PersistenceLoadingPolicy? ClonePersistenceLoadingPolicy(PersistenceLoadingPolicy? policy)
        {
            if (policy == null)
            {
                return null;
            }

            return new PersistenceLoadingPolicy
            {
                PersistenceLoadingType = policy.PersistenceLoadingType,
                PartialLoadingKeys = policy.PartialLoadingKeys?.ToList(),
                LockingKeys = policy.LockingKeys?.ToList(),
                UseKeyAsPrefix = policy.UseKeyAsPrefix
            };
        }

        private static RetryPolicy? CloneRetryPolicy(RetryPolicy? policy)
        {
            if (policy == null)
            {
                return null;
            }

            return new RetryPolicy
            {
                InitialIntervalSeconds = policy.InitialIntervalSeconds,
                BackoffCoefficient = policy.BackoffCoefficient,
                MaximumIntervalSeconds = policy.MaximumIntervalSeconds,
                MaximumAttempts = policy.MaximumAttempts,
                MaximumAttemptsDurationSeconds = policy.MaximumAttemptsDurationSeconds
            };
        }

        /// <summary>
        /// Returns a string representation of this instance
        /// </summary>
        /// <returns>A string representation</returns>
        public override string ToString()
        {
            return $"WorkflowStateOptions {{ ... }}";
        }
    }
}