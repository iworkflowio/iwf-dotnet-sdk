using System.Net;
using System.Net.Http;

namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// This indicates something went wrong in the iwf application
    /// </summary>
    public class ClientSideException : IwfHttpException
    {
        public ClientSideException(HttpStatusCode statusCode, string responseContent)
            : base(statusCode, responseContent)
        {
        }

        public ClientSideException(HttpResponseMessage response, string responseContent)
            : base(response, responseContent)
        {
        }

        public ClientSideException(IwfHttpException exception)
            : base(exception)
        {
        }
    }
}