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
    /// Defines PersistenceLoadingType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersistenceLoadingType
    {
        /// <summary>
        /// Enum ALLWITHOUTLOCKING for value: LOAD_ALL_WITHOUT_LOCKING
        /// </summary>
        [EnumMember(Value = "LOAD_ALL_WITHOUT_LOCKING")]
        ALLWITHOUTLOCKING = 1,

        /// <summary>
        /// Enum PARTIALWITHOUTLOCKING for value: LOAD_PARTIAL_WITHOUT_LOCKING
        /// </summary>
        [EnumMember(Value = "LOAD_PARTIAL_WITHOUT_LOCKING")]
        PARTIALWITHOUTLOCKING = 2,

        /// <summary>
        /// Enum PARTIALWITHEXCLUSIVELOCK for value: LOAD_PARTIAL_WITH_EXCLUSIVE_LOCK
        /// </summary>
        [EnumMember(Value = "LOAD_PARTIAL_WITH_EXCLUSIVE_LOCK")]
        PARTIALWITHEXCLUSIVELOCK = 3,

        /// <summary>
        /// Enum NONE for value: LOAD_NONE
        /// </summary>
        [EnumMember(Value = "LOAD_NONE")]
        NONE = 4,

        /// <summary>
        /// Enum ALLWITHPARTIALLOCK for value: LOAD_ALL_WITH_PARTIAL_LOCK
        /// </summary>
        [EnumMember(Value = "LOAD_ALL_WITH_PARTIAL_LOCK")]
        ALLWITHPARTIALLOCK = 5
    }

}
