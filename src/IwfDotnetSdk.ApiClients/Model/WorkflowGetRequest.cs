/*
 * Workflow APIs
 *
 * This APIs for iwf SDKs to operate workflows
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IwfDotnetSdk.ApiClients.Client.OpenAPIDateConverter;

namespace IwfDotnetSdk.ApiClients.Model
{
    /// <summary>
    /// WorkflowGetRequest
    /// </summary>
    [DataContract(Name = "WorkflowGetRequest")]
    public partial class WorkflowGetRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowGetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkflowGetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowGetRequest" /> class.
        /// </summary>
        /// <param name="workflowId">workflowId (required).</param>
        /// <param name="workflowRunId">workflowRunId.</param>
        /// <param name="needsResults">needsResults.</param>
        /// <param name="waitTimeSeconds">waitTimeSeconds.</param>
        public WorkflowGetRequest(string workflowId = default(string), string workflowRunId = default(string), bool needsResults = default(bool), int waitTimeSeconds = default(int))
        {
            // to ensure "workflowId" is required (not null)
            if (workflowId == null)
            {
                throw new ArgumentNullException("workflowId is a required property for WorkflowGetRequest and cannot be null");
            }
            this.WorkflowId = workflowId;
            this.WorkflowRunId = workflowRunId;
            this.NeedsResults = needsResults;
            this.WaitTimeSeconds = waitTimeSeconds;
        }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name = "workflowId", IsRequired = true, EmitDefaultValue = true)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowRunId
        /// </summary>
        [DataMember(Name = "workflowRunId", EmitDefaultValue = false)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Gets or Sets NeedsResults
        /// </summary>
        [DataMember(Name = "needsResults", EmitDefaultValue = true)]
        public bool NeedsResults { get; set; }

        /// <summary>
        /// Gets or Sets WaitTimeSeconds
        /// </summary>
        [DataMember(Name = "waitTimeSeconds", EmitDefaultValue = false)]
        public int WaitTimeSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowGetRequest {\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowRunId: ").Append(WorkflowRunId).Append("\n");
            sb.Append("  NeedsResults: ").Append(NeedsResults).Append("\n");
            sb.Append("  WaitTimeSeconds: ").Append(WaitTimeSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
