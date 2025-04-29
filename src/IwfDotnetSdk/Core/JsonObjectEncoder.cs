using System;
using Newtonsoft.Json;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    public class JsonObjectEncoder : IObjectEncoder
    {
        private readonly JsonSerializerSettings _jsonSettings;

        public JsonObjectEncoder() : this(new JsonSerializerSettings 
        { 
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat
        })
        {
        }

        public JsonObjectEncoder(JsonSerializerSettings jsonSettings)
        {
            _jsonSettings = jsonSettings ?? throw new ArgumentNullException(nameof(jsonSettings));
        }

        public EncodedObject Encode<T>(T obj)
        {
            if (obj == null)
            {
                return null;
            }

            try
            {
                string json = JsonConvert.SerializeObject(obj, _jsonSettings);
                return new EncodedObject
                {
                    Encoding = "json",
                    Data = json
                };
            }
            catch (Exception ex)
            {
                throw new ObjectEncoderException($"Failed to encode object of type {typeof(T).Name}", ex);
            }
        }

        public T Decode<T>(EncodedObject encodedObj)
        {
            if (encodedObj == null)
            {
                return default;
            }

            if (!"json".Equals(encodedObj.Encoding, StringComparison.OrdinalIgnoreCase))
            {
                throw new ObjectEncoderException($"Unsupported encoding: {encodedObj.Encoding}");
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(encodedObj.Data, _jsonSettings);
            }
            catch (Exception ex)
            {
                throw new ObjectEncoderException($"Failed to decode to type {typeof(T).Name}", ex);
            }
        }
    }
}