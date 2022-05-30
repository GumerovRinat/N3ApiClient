using N3ApiClient.AppointmentService.Svip.DataContract;
using N3ApiClient.AppointmentService.Svip.Tools;
using RestSharp;
using RestSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace N3ApiClient.AppointmentService.Svip
{
    public partial class SvipClient
    {
        private const string TEST_URL = "http://r26-rc.zdrav.netrika.ru/authorization/api/";
        private const string PRODUCTION_URL = "http://172.29.29.44/authorization/api/";


        /// <summary>
        /// Gets the <see cref="IRestClient"/> instance.
        /// </summary>
        public IRestClient Client { get; private set; }

        private IRestSerializer Serializer { get; set; }

        public SvipClient(IRestClient client)
        {
            Client = client;

            Client.Encoding = Encoding.UTF8;
            Client.ThrowOnDeserializationError = false;
            Client.AddHandler("application/json", () => new RestSharp.Serializers.Newtonsoft.Json.NewtonsoftJsonSerializer());
        }

        /// <summary>
        /// Initializes a new instance of the MDLP REST API client.
        /// </summary>
        /// <param name="credentials">Credentials used for authentication.</param>
        /// <param name="baseUrl">Base URL of the API endpoint.</param>
        public SvipClient(string baseUrl = PRODUCTION_URL)
            : this(new RestClient(baseUrl ?? PRODUCTION_URL))
        {
        }

        private void PrepareRequest(IRestRequest request, string apiMethodName)
        {
            //use request parameters to store additional properties, not really used by the requests
            request.AddParameter(ApiTimestampParameterName, DateTime.Now.Ticks, ParameterType.UrlSegment);
            request.AddParameter(ApiTickCountParameterName, Environment.TickCount.ToString(), ParameterType.UrlSegment);
            if (!string.IsNullOrWhiteSpace(apiMethodName))
            {
                request.AddHeader(ApiMethodNameHeaderName, apiMethodName);
            }

            // trace requests and responses
            if (Tracer != null)
            {
                request.OnBeforeRequest = http => Trace(http, request);
                request.OnBeforeDeserialization = resp => Trace(resp);
            }
        }

        /// <summary>
        /// Executes the given request and checks the result.
        /// </summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="request">The request to execute.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        internal T Execute<T>(IRestRequest request, string apiMethodName)
        {
            PrepareRequest(request, apiMethodName);
            var response = Client.Execute<T>(request);
            ThrowOnFailure(response);
            return response.Data;
        }


        /// <summary>
        /// Executes the given request and checks the result.
        /// </summary>
        /// <param name="request">The request to execute.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        internal void Execute(IRestRequest request, string apiMethodName)
        {
            PrepareRequest(request, apiMethodName);
            var response = Client.Execute(request);

            // there is no body deserialization step, so we need to trace
            Trace(response);
            ThrowOnFailure(response);
        }

        /// <summary>
        /// Executes the given request and checks the result.
        /// </summary>
        /// <param name="request">The request to execute.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        internal string ExecuteString(IRestRequest request, string apiMethodName)
        {
            PrepareRequest(request, apiMethodName);
            var response = Client.Execute(request);

            // there is no body deserialization step, so we need to trace
            Trace(response);
            ThrowOnFailure(response);
            return response.Content;
        }

        /// <summary>
        /// Performs GET request.
        /// </summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="url">Resource url.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public T Get<T>(string url, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.GET, DataFormat.Json);
            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            return Execute<T>(request, apiMethodName);
        }

        /// <summary>
        /// Performs GET request and returns a string.
        /// </summary>
        /// <param name="url">Resource url.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public string Get(string url, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.GET, DataFormat.Json);
            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            return ExecuteString(request, apiMethodName);
        }

        /// <summary>
        /// Performs POST request.
        /// </summary>
        /// <typeparam name="T">Response type.</typeparam>
        /// <param name="url">Resource url.</param>
        /// <param name="body">Request body, to be serialized as JSON.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public T Post<T>(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.POST, DataFormat.Json);
            request.AddJsonBody(body);
            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            return Execute<T>(request, apiMethodName);
        }

        /// <summary>
        /// Performs POST request.
        /// </summary>
        /// <param name="url">Resource url.</param>
        /// <param name="body">Request body, to be serialized as JSON.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public void Post(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.POST, DataFormat.Json);
            request.AddJsonBody(body);
            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            Execute(request, apiMethodName);
        }

        /// <summary>
        /// Performs PUT request.
        /// </summary>
        /// <param name="url">Resource url.</param>
        /// <param name="body">Request body, to be serialized as JSON.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public void Put(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.PUT, DataFormat.Json);
            request.AddJsonBody(body);
            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            Execute(request, apiMethodName);
        }

        /// <summary>
        /// Performs PUT request.
        /// </summary>
        /// <param name="url">Resource url.</param>
        /// <param name="body">Request body, serialized as string.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public void Put(string url, string body, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.PUT, DataFormat.None);
            request.AddParameter(string.Empty, body, ParameterType.RequestBody);
            Execute(request, apiMethodName);
        }

        /// <summary>
        /// Performs DELETE request.
        /// </summary>
        /// <param name="url">Resource url.</param>
        /// <param name="body">Request body, serialized as string.</param>
        /// <param name="parameters">IRestRequest parameters.</param>
        /// <param name="apiMethodName">Strong-typed REST API method name, for tracing.</param>
        public void Delete(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null)
        {
            var request = new RestRequest(url, Method.DELETE, DataFormat.Json);
            if (body != null)
            {
                request.AddJsonBody(body);
            }

            if (!parameters.IsNullOrEmpty())
            {
                request.AddOrUpdateParameters(parameters);
            }

            Execute(request, apiMethodName);
        }

        private void ThrowOnFailure(IRestResponse response)
        {
            if (!response.IsSuccessful)
            {
                // try to find the non-empty error message
                var errorMessage = response.ErrorMessage;
                var contentMessage = response.Content;
                var errorResponse = default(ErrorResponse);
                if (response.ContentType != null)
                {
                    // Text/plain;charset=UTF-8 => text/plain
                    var contentType = response.ContentType.ToLower().Trim();
                    var semicolonIndex = contentType.IndexOf(';');
                    if (semicolonIndex >= 0)
                    {
                        contentType = contentType.Substring(0, semicolonIndex).Trim();
                    }

                    // Try to deserialize error response DTO
                    if (Serializer.SupportedContentTypes.Contains(contentType))
                    {
                        errorResponse = Serializer.Deserialize<ErrorResponse>(response);
                        contentMessage = string.Join(". ", new[]
                        {
                            errorResponse.Error,
                            errorResponse.Message,
                            errorResponse.Description,
                        }
                        .Distinct()
                        .Where(m => !string.IsNullOrWhiteSpace(m)));
                    }
                    else if (response.ContentType.ToLower().Contains("html"))
                    {
                        // Try to parse HTML
                        contentMessage = HtmlHelper.ExtractText(response.Content);
                    }
                    else
                    {
                        // Return as is assuming text/plain content
                        contentMessage = response.Content;
                    }
                }

                // HTML->XML deserialization errors are meaningless
                if (response.ErrorException is XmlException && errorMessage == response.ErrorException.Message)
                {
                    errorMessage = contentMessage;
                }

                // empty error message is meaningless
                if (string.IsNullOrWhiteSpace(errorMessage))
                {
                    errorMessage = contentMessage;
                }

                // finally, throw it
                throw new SvipException(response.StatusCode, errorMessage, errorResponse, response.ErrorException);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
