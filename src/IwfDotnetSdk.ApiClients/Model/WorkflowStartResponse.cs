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
    /// WorkflowStartResponse
    /// </summary>
    [DataContract(Name = "WorkflowStartResponse")]
    public partial class WorkflowStartResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartResponse" /> class.
        /// </summary>
        /// <param name="workflowRunId">workflowRunId.</param>
        public WorkflowStartResponse(string workflowRunId = default(string))
        {
            this.WorkflowRunId = workflowRunId;
        }

        /// <summary>
        /// Gets or Sets WorkflowRunId
        /// </summary>
        [DataMember(Name = "workflowRunId", EmitDefaultValue = false)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowStartResponse {\n");
            sb.Append("  WorkflowRunId: ").Append(WorkflowRunId).Append("\n");
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
