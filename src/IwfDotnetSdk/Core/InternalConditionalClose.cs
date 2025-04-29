using System;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Represents a conditional close operation for a workflow
    /// </summary>
    public record InternalConditionalClose
    {
        /// <summary>
        /// Gets the conditional close type
        /// </summary>
        public WorkflowConditionalCloseType WorkflowConditionalCloseType { get; }

        /// <summary>
        /// Gets the channel name
        /// </summary>
        public string ChannelName { get; }

        /// <summary>
        /// Gets the close input, if any
        /// </summary>
        public object? CloseInput { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalConditionalClose"/> class
        /// </summary>
        /// <param name="workflowConditionalCloseType">The conditional close type</param>
        /// <param name="channelName">The channel name</param>
        /// <param name="closeInput">Optional close input</param>
        public InternalConditionalClose(
            WorkflowConditionalCloseType workflowConditionalCloseType,
            string channelName,
            object? closeInput = null)
        {
            WorkflowConditionalCloseType = workflowConditionalCloseType;
            ChannelName = channelName ?? throw new ArgumentNullException(nameof(channelName));
            CloseInput = closeInput;
        }
    }
}