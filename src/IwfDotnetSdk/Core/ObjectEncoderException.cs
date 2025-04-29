using System;

namespace IwfDotnetSdk.Core
{
    public class ObjectEncoderException : Exception
    {
        public ObjectEncoderException(string message) : base(message)
        {
        }

        public ObjectEncoderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}