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
    /// Defines WorkflowErrorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowErrorType
    {
        /// <summary>
        /// Enum STATEDECISIONFAILINGWORKFLOWERRORTYPE for value: STATE_DECISION_FAILING_WORKFLOW_ERROR_TYPE
        /// </summary>
        [EnumMember(Value = "STATE_DECISION_FAILING_WORKFLOW_ERROR_TYPE")]
        STATEDECISIONFAILINGWORKFLOWERRORTYPE = 1,

        /// <summary>
        /// Enum CLIENTAPIFAILINGWORKFLOWERRORTYPE for value: CLIENT_API_FAILING_WORKFLOW_ERROR_TYPE
        /// </summary>
        [EnumMember(Value = "CLIENT_API_FAILING_WORKFLOW_ERROR_TYPE")]
        CLIENTAPIFAILINGWORKFLOWERRORTYPE = 2,

        /// <summary>
        /// Enum STATEAPIFAILERRORTYPE for value: STATE_API_FAIL_ERROR_TYPE
        /// </summary>
        [EnumMember(Value = "STATE_API_FAIL_ERROR_TYPE")]
        STATEAPIFAILERRORTYPE = 3,

        /// <summary>
        /// Enum INVALIDUSERWORKFLOWCODEERRORTYPE for value: INVALID_USER_WORKFLOW_CODE_ERROR_TYPE
        /// </summary>
        [EnumMember(Value = "INVALID_USER_WORKFLOW_CODE_ERROR_TYPE")]
        INVALIDUSERWORKFLOWCODEERRORTYPE = 4,

        /// <summary>
        /// Enum RPCACQUIRELOCKFAILURE for value: RPC_ACQUIRE_LOCK_FAILURE
        /// </summary>
        [EnumMember(Value = "RPC_ACQUIRE_LOCK_FAILURE")]
        RPCACQUIRELOCKFAILURE = 5,

        /// <summary>
        /// Enum SERVERINTERNALERRORTYPE for value: SERVER_INTERNAL_ERROR_TYPE
        /// </summary>
        [EnumMember(Value = "SERVER_INTERNAL_ERROR_TYPE")]
        SERVERINTERNALERRORTYPE = 6
    }

}
