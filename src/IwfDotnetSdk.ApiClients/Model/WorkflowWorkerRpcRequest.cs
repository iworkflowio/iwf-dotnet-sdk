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
    /// WorkflowWorkerRpcRequest
    /// </summary>
    [DataContract(Name = "WorkflowWorkerRpcRequest")]
    public partial class WorkflowWorkerRpcRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWorkerRpcRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkflowWorkerRpcRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWorkerRpcRequest" /> class.
        /// </summary>
        /// <param name="context">context (required).</param>
        /// <param name="workflowType">workflowType (required).</param>
        /// <param name="rpcName">rpcName (required).</param>
        /// <param name="input">input.</param>
        /// <param name="searchAttributes">searchAttributes.</param>
        /// <param name="dataAttributes">dataAttributes.</param>
        /// <param name="signalChannelInfos">signalChannelInfos.</param>
        /// <param name="internalChannelInfos">internalChannelInfos.</param>
        public WorkflowWorkerRpcRequest(Context context = default(Context), string workflowType = default(string), string rpcName = default(string), EncodedObject input = default(EncodedObject), List<SearchAttribute> searchAttributes = default(List<SearchAttribute>), List<KeyValue> dataAttributes = default(List<KeyValue>), Dictionary<string, ChannelInfo> signalChannelInfos = default(Dictionary<string, ChannelInfo>), Dictionary<string, ChannelInfo> internalChannelInfos = default(Dictionary<string, ChannelInfo>))
        {
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new ArgumentNullException("context is a required property for WorkflowWorkerRpcRequest and cannot be null");
            }
            this.Context = context;
            // to ensure "workflowType" is required (not null)
            if (workflowType == null)
            {
                throw new ArgumentNullException("workflowType is a required property for WorkflowWorkerRpcRequest and cannot be null");
            }
            this.WorkflowType = workflowType;
            // to ensure "rpcName" is required (not null)
            if (rpcName == null)
            {
                throw new ArgumentNullException("rpcName is a required property for WorkflowWorkerRpcRequest and cannot be null");
            }
            this.RpcName = rpcName;
            this.Input = input;
            this.SearchAttributes = searchAttributes;
            this.DataAttributes = dataAttributes;
            this.SignalChannelInfos = signalChannelInfos;
            this.InternalChannelInfos = internalChannelInfos;
        }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", IsRequired = true, EmitDefaultValue = true)]
        public Context Context { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowType
        /// </summary>
        [DataMember(Name = "workflowType", IsRequired = true, EmitDefaultValue = true)]
        public string WorkflowType { get; set; }

        /// <summary>
        /// Gets or Sets RpcName
        /// </summary>
        [DataMember(Name = "rpcName", IsRequired = true, EmitDefaultValue = true)]
        public string RpcName { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public EncodedObject Input { get; set; }

        /// <summary>
        /// Gets or Sets SearchAttributes
        /// </summary>
        [DataMember(Name = "searchAttributes", EmitDefaultValue = false)]
        public List<SearchAttribute> SearchAttributes { get; set; }

        /// <summary>
        /// Gets or Sets DataAttributes
        /// </summary>
        [DataMember(Name = "dataAttributes", EmitDefaultValue = false)]
        public List<KeyValue> DataAttributes { get; set; }

        /// <summary>
        /// Gets or Sets SignalChannelInfos
        /// </summary>
        [DataMember(Name = "signalChannelInfos", EmitDefaultValue = false)]
        public Dictionary<string, ChannelInfo> SignalChannelInfos { get; set; }

        /// <summary>
        /// Gets or Sets InternalChannelInfos
        /// </summary>
        [DataMember(Name = "internalChannelInfos", EmitDefaultValue = false)]
        public Dictionary<string, ChannelInfo> InternalChannelInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowWorkerRpcRequest {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  WorkflowType: ").Append(WorkflowType).Append("\n");
            sb.Append("  RpcName: ").Append(RpcName).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  SearchAttributes: ").Append(SearchAttributes).Append("\n");
            sb.Append("  DataAttributes: ").Append(DataAttributes).Append("\n");
            sb.Append("  SignalChannelInfos: ").Append(SignalChannelInfos).Append("\n");
            sb.Append("  InternalChannelInfos: ").Append(InternalChannelInfos).Append("\n");
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
