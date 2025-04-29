using System;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for resetting a workflow
    /// </summary>
    public record ResetWorkflowTypeAndOptions
    {
        /// <summary>
        /// Gets the reset type
        /// </summary>
        public WorkflowResetType ResetType { get; }

        /// <summary>
        /// Gets the history event ID, if applicable
        /// </summary>
        public int? HistoryEventId { get; }

        /// <summary>
        /// Gets the reason for the reset
        /// </summary>
        public string Reason { get; }

        /// <summary>
        /// Gets the history event time, if applicable
        /// </summary>
        public string? HistoryEventTime { get; }

        /// <summary>
        /// Gets the state ID, if applicable
        /// </summary>
        public string? StateId { get; }

        /// <summary>
        /// Gets the state execution ID, if applicable
        /// </summary>
        public string? StateExecutionId { get; }

        /// <summary>
        /// Gets whether to skip signal reapply
        /// </summary>
        public bool? SkipSignalReapply { get; }

        /// <summary>
        /// Gets whether to skip update reapply
        /// </summary>
        public bool? SkipUpdateReapply { get; }

        private ResetWorkflowTypeAndOptions(
            WorkflowResetType resetType,
            string reason,
            int? historyEventId = null,
            string? historyEventTime = null,
            string? stateId = null,
            string? stateExecutionId = null,
            bool? skipSignalReapply = null,
            bool? skipUpdateReapply = null)
        {
            ResetType = resetType;
            Reason = reason ?? throw new ArgumentNullException(nameof(reason));
            HistoryEventId = historyEventId;
            HistoryEventTime = historyEventTime;
            StateId = stateId;
            StateExecutionId = stateExecutionId;
            SkipSignalReapply = skipSignalReapply;
            SkipUpdateReapply = skipUpdateReapply;
        }

        /// <summary>
        /// Creates a reset option to reset to the beginning of the workflow
        /// </summary>
        /// <param name="reason">The reason for the reset</param>
        /// <returns>Reset options</returns>
        public static ResetWorkflowTypeAndOptions ResetToBeginning(string reason)
        {
            return new ResetWorkflowTypeAndOptions(
                resetType: WorkflowResetType.BEGINNING,
                reason: reason
            );
        }

        /// <summary>
        /// Creates a reset option to reset to a specific history event ID
        /// </summary>
        /// <param name="historyEventId">The history event ID</param>
        /// <param name="reason">The reason for the reset</param>
        /// <returns>Reset options</returns>
        public static ResetWorkflowTypeAndOptions ResetToHistoryEventId(int historyEventId, string reason)
        {
            return new ResetWorkflowTypeAndOptions(
                resetType: WorkflowResetType.HISTORYEVENTID,
                reason: reason,
                historyEventId: historyEventId
            );
        }

        /// <summary>
        /// Creates a reset option to reset to a specific history event time
        /// </summary>
        /// <param name="historyEventTime">The history event time</param>
        /// <param name="reason">The reason for the reset</param>
        /// <returns>Reset options</returns>
        public static ResetWorkflowTypeAndOptions ResetToHistoryEventTime(string historyEventTime, string reason)
        {
            return new ResetWorkflowTypeAndOptions(
                resetType: WorkflowResetType.HISTORYEVENTTIME,
                reason: reason,
                historyEventTime: historyEventTime
            );
        }

        /// <summary>
        /// Creates a reset option to reset to a specific state ID
        /// </summary>
        /// <param name="stateId">The state ID</param>
        /// <param name="reason">The reason for the reset</param>
        /// <returns>Reset options</returns>
        public static ResetWorkflowTypeAndOptions ResetToStateId(string stateId, string reason)
        {
            return new ResetWorkflowTypeAndOptions(
                resetType: WorkflowResetType.STATEID,
                reason: reason,
                stateId: stateId
            );
        }

        /// <summary>
        /// Creates a reset option to reset to a specific state execution ID
        /// </summary>
        /// <param name="stateExecutionId">The state execution ID</param>
        /// <param name="reason">The reason for the reset</param>
        /// <returns>Reset options</returns>
        public static ResetWorkflowTypeAndOptions ResetToStateExecutionId(string stateExecutionId, string reason)
        {
            return new ResetWorkflowTypeAndOptions(
                resetType: WorkflowResetType.STATEEXECUTIONID,
                reason: reason,
                stateExecutionId: stateExecutionId
            );
        }

        /// <summary>
        /// Creates a builder for creating a custom reset option
        /// </summary>
        /// <returns>A builder</returns>
        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        /// <summary>
        /// Builder for ResetWorkflowTypeAndOptions
        /// </summary>
        public class Builder
        {
            private WorkflowResetType _resetType;
            private int? _historyEventId;
            private string _reason = string.Empty;
            private string? _historyEventTime;
            private string? _stateId;
            private string? _stateExecutionId;
            private bool? _skipSignalReapply;
            private bool? _skipUpdateReapply;

            /// <summary>
            /// Sets the reset type
            /// </summary>
            /// <param name="resetType">The reset type</param>
            /// <returns>This builder</returns>
            public Builder SetResetType(WorkflowResetType resetType)
            {
                _resetType = resetType;
                return this;
            }

            /// <summary>
            /// Sets the history event ID
            /// </summary>
            /// <param name="historyEventId">The history event ID</param>
            /// <returns>This builder</returns>
            public Builder SetHistoryEventId(int historyEventId)
            {
                _historyEventId = historyEventId;
                return this;
            }

            /// <summary>
            /// Sets the reason for the reset
            /// </summary>
            /// <param name="reason">The reason</param>
            /// <returns>This builder</returns>
            public Builder SetReason(string reason)
            {
                _reason = reason;
                return this;
            }

            /// <summary>
            /// Sets the history event time
            /// </summary>
            /// <param name="historyEventTime">The history event time</param>
            /// <returns>This builder</returns>
            public Builder SetHistoryEventTime(string historyEventTime)
            {
                _historyEventTime = historyEventTime;
                return this;
            }

            /// <summary>
            /// Sets the state ID
            /// </summary>
            /// <param name="stateId">The state ID</param>
            /// <returns>This builder</returns>
            public Builder SetStateId(string stateId)
            {
                _stateId = stateId;
                return this;
            }

            /// <summary>
            /// Sets the state execution ID
            /// </summary>
            /// <param name="stateExecutionId">The state execution ID</param>
            /// <returns>This builder</returns>
            public Builder SetStateExecutionId(string stateExecutionId)
            {
                _stateExecutionId = stateExecutionId;
                return this;
            }

            /// <summary>
            /// Sets whether to skip signal reapply
            /// </summary>
            /// <param name="skipSignalReapply">True to skip signal reapply</param>
            /// <returns>This builder</returns>
            public Builder SetSkipSignalReapply(bool skipSignalReapply)
            {
                _skipSignalReapply = skipSignalReapply;
                return this;
            }

            /// <summary>
            /// Sets whether to skip update reapply
            /// </summary>
            /// <param name="skipUpdateReapply">True to skip update reapply</param>
            /// <returns>This builder</returns>
            public Builder SetSkipUpdateReapply(bool skipUpdateReapply)
            {
                _skipUpdateReapply = skipUpdateReapply;
                return this;
            }

            /// <summary>
            /// Builds the ResetWorkflowTypeAndOptions
            /// </summary>
            /// <returns>A new ResetWorkflowTypeAndOptions instance</returns>
            public ResetWorkflowTypeAndOptions Build()
            {
                return new ResetWorkflowTypeAndOptions(
                    resetType: _resetType,
                    reason: _reason,
                    historyEventId: _historyEventId,
                    historyEventTime: _historyEventTime,
                    stateId: _stateId,
                    stateExecutionId: _stateExecutionId,
                    skipSignalReapply: _skipSignalReapply,
                    skipUpdateReapply: _skipUpdateReapply
                );
            }
        }
    }
}