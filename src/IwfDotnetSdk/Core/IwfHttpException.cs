using System;
using System.Net;
using System.Net.Http;
using IwfDotnetSdk.ApiClients.Model;

namespace IwfDotnetSdk.Core
{
    public class IwfHttpException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string ResponseContent { get; }
        public ErrorResponse ErrorResponse { get; }

        public IwfHttpException(HttpStatusCode statusCode, string responseContent, string message = null)
            : base(message ?? $"HTTP error with status code {(int)statusCode}")
        {
            StatusCode = statusCode;
            ResponseContent = responseContent;
            
            try
            {
                if (!string.IsNullOrEmpty(responseContent))
                {
                    ErrorResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                }
            }
            catch
            {
                // If we can't deserialize the error response, just ignore it
            }
        }

        public IwfHttpException(HttpResponseMessage response, string responseContent)
            : this(response.StatusCode, responseContent, $"HTTP error with status code {(int)response.StatusCode}")
        {
        }

        public IwfHttpException(IwfHttpException exception)
            : base(exception.Message, exception)
        {
            StatusCode = exception.StatusCode;
            ResponseContent = exception.ResponseContent;
            ErrorResponse = exception.ErrorResponse;
        }
    }
}