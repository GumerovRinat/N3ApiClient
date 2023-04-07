using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization;
using System.IO;
using System.Text;

namespace N3ApiClient.N3RestClient.Tools
{
    public class NewtonsoftJsonSerializer : IRestSerializer
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        public NewtonsoftJsonSerializer()
        {
            _jsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yyyy-MM-ddThh:mm:ss.000+hh:mm"
            };
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, _jsonSerializerSettings);
        }

        public string Serialize(Parameter parameter)
        {
            return JsonConvert.SerializeObject(parameter.Value, _jsonSerializerSettings);
        }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public string[] SupportedContentTypes { get; } =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public string ContentType { get; set; } = "application/json";

        public DataFormat DataFormat { get; } = DataFormat.Json;

        public void SerializeRequest(IRestRequest request, Stream stream, Encoding encoding)
        {
            var json = Serialize(request.Parameters);
            var bytes = encoding.GetBytes(json);
            stream.Write(bytes, 0, bytes.Length);
        }

        public T Deserialize<T>(Stream content)
        {
            using (var reader = new StreamReader(content))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}

