using System;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    public interface IObjectEncoder
    {
        /// <summary>
        /// Encode an object into EncodedObject
        /// </summary>
        /// <typeparam name="T">The type of object to encode</typeparam>
        /// <param name="obj">The object instance to encode</param>
        /// <returns>EncodedObject with encoded data</returns>
        EncodedObject Encode<T>(T obj);

        /// <summary>
        /// Decode an EncodedObject back to the original object type
        /// </summary>
        /// <typeparam name="T">The type to decode to</typeparam>
        /// <param name="encodedObj">The encoded object</param>
        /// <returns>The decoded object instance</returns>
        T Decode<T>(EncodedObject encodedObj);
    }
}