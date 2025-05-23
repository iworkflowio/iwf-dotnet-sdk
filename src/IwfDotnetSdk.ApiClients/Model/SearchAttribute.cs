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
    /// SearchAttribute
    /// </summary>
    [DataContract(Name = "SearchAttribute")]
    public partial class SearchAttribute : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        public SearchAttributeValueType? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAttribute" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="stringValue">stringValue.</param>
        /// <param name="integerValue">integerValue.</param>
        /// <param name="doubleValue">doubleValue.</param>
        /// <param name="boolValue">boolValue.</param>
        /// <param name="stringArrayValue">stringArrayValue.</param>
        /// <param name="valueType">valueType.</param>
        public SearchAttribute(string key = default(string), string stringValue = default(string), long integerValue = default(long), double doubleValue = default(double), bool boolValue = default(bool), List<string> stringArrayValue = default(List<string>), SearchAttributeValueType? valueType = default(SearchAttributeValueType?))
        {
            this.Key = key;
            this.StringValue = stringValue;
            this.IntegerValue = integerValue;
            this.DoubleValue = doubleValue;
            this.BoolValue = boolValue;
            this.StringArrayValue = stringArrayValue;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets StringValue
        /// </summary>
        [DataMember(Name = "stringValue", EmitDefaultValue = false)]
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or Sets IntegerValue
        /// </summary>
        [DataMember(Name = "integerValue", EmitDefaultValue = false)]
        public long IntegerValue { get; set; }

        /// <summary>
        /// Gets or Sets DoubleValue
        /// </summary>
        [DataMember(Name = "doubleValue", EmitDefaultValue = false)]
        public double DoubleValue { get; set; }

        /// <summary>
        /// Gets or Sets BoolValue
        /// </summary>
        [DataMember(Name = "boolValue", EmitDefaultValue = true)]
        public bool BoolValue { get; set; }

        /// <summary>
        /// Gets or Sets StringArrayValue
        /// </summary>
        [DataMember(Name = "stringArrayValue", EmitDefaultValue = false)]
        public List<string> StringArrayValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchAttribute {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  StringValue: ").Append(StringValue).Append("\n");
            sb.Append("  IntegerValue: ").Append(IntegerValue).Append("\n");
            sb.Append("  DoubleValue: ").Append(DoubleValue).Append("\n");
            sb.Append("  BoolValue: ").Append(BoolValue).Append("\n");
            sb.Append("  StringArrayValue: ").Append(StringArrayValue).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
