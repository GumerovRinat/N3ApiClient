using Hl7.Fhir.Model;
using N3ApiClient.Base.Exceptions;
using System;
using System.Net;
using System.Runtime.Serialization;
namespace N3ApiClient.N3RestClient.Exceptions
{
    /// <summary>
    /// Netrika REST API Exception.
    /// </summary>
    [Serializable]
    public class N3RestClientException : NetrikaException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="N3RestClientException"/> class.
        /// </summary>
        /// <param name="code">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorResponse"><see cref="OperationOutcome"/> instance, if available.</param>
        /// <param name="innerException">Inner <see cref="Exception"/> instance.</param>
        public N3RestClientException(HttpStatusCode code, string message, Resource errorResponse, Exception innerException)
            : base(GetMessage(code, message), innerException)
        {
            StatusCode = code;
            OperationOutcome = errorResponse;
            InnerException = innerException;
        }

        public N3RestClientException(Exception innerException)
        {
            StatusCode = HttpStatusCode.Forbidden;
            InnerException = innerException;
        }

        public N3RestClientException(string message)
        {
            StatusCode = HttpStatusCode.Forbidden;
            InnerException = new Exception(message);
        }


        private static string GetMessage(HttpStatusCode code, string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                return message;
            }

            return code.ToString();
        }

        /// <inheritdoc/>
        protected N3RestClientException(SerializationInfo info, StreamingContext context)
        {
            StatusCode = (HttpStatusCode)info.GetInt32("Code");
            
        }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// <see cref="OperationOutcome"/> instance returned by server.
        /// </summary>
        public Resource OperationOutcome { get; set; }

        /// <summary>
        /// Inner exception
        /// </summary>
        public Exception InnerException { get; set; }

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
