using System.Net;
using System.Net.Http;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// This indicates something went wrong in the iwf server
    /// </summary>
    public class ServerSideException : IwfHttpException
    {
        public ServerSideException(HttpStatusCode statusCode, string responseContent)
            : base(statusCode, responseContent)
        {
        }

        public ServerSideException(HttpResponseMessage response, string responseContent)
            : base(response, responseContent)
        {
        }

        public ServerSideException(IwfHttpException exception)
            : base(exception)
        {
        }
    }
}