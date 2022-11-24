﻿using N3ApiClient.AppointmentService.Svip.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.Svip
{
    /// <summary>
    /// SVIP REST API Exception.
    /// </summary>
    [Serializable]
    public class SvipException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrieException"/> class.
        /// </summary>
        /// <param name="code">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorResponse"><see cref="ErrorResponse"/> instance, if available.</param>
        /// <param name="innerException">Inner <see cref="Exception"/> instance.</param>
        public SvipException(HttpStatusCode code, string message, ErrorResponse errorResponse, Exception innerException)
            : base(GetMessage(code, message), innerException)
        {
            StatusCode = code;
            ErrorResponse = errorResponse;
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
        protected SvipException(SerializationInfo info, StreamingContext context)
        {
            StatusCode = (HttpStatusCode)info.GetInt32("Code");
            if (info.GetString("Path") != null)
            {
                ErrorResponse = new ErrorResponse
                {
                    TimeStamp = info.GetDateTime("TimeStamp"),
                    StatusCode = info.GetInt32("StatusCode"),
                    Error = info.GetString("Error"),
                    Message = info.GetString("Message"),
                    Path = info.GetString("Path"),
                    Description = info.GetString("Description"),
                };
            }
        }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// <see cref="ErrorResponse"/> instance returned by server.
        /// </summary>
        public ErrorResponse ErrorResponse { get; set; }

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("Code", (int)StatusCode);
            if (ErrorResponse != null)
            {
                info.AddValue("TimeStamp", ErrorResponse.TimeStamp);
                info.AddValue("StatusCode", ErrorResponse.StatusCode);
                info.AddValue("Error", ErrorResponse.Error);
                info.AddValue("Message", ErrorResponse.Message);
                info.AddValue("Path", ErrorResponse.Path);
                info.AddValue("Description", ErrorResponse.Description);
            }
        }
    }
}
