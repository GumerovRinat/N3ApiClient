using System;

namespace N3ApiClient.Base.Exceptions
{
    public abstract class NetrikaException : Exception
    {
        public NetrikaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public NetrikaException() { }
    }
}
