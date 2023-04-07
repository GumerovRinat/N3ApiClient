using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using RestSharp;
using RestSharp.Serialization;
using System.IO;

namespace N3ApiClient.N3RestClient.Tools
{
    internal class FhirSerializer : IRestSerializer
    {
        private readonly FhirJsonSerializer _serializer = new FhirJsonSerializer();
        private readonly FhirJsonParser _parser = new FhirJsonParser();

        public string[] SupportedContentTypes { get; } =
                {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public string ContentType { get; set; } = "application/json";

        public DataFormat DataFormat { get; } = DataFormat.Json;

        public T Deserialize<T>(IRestResponse response)
        {
            return (T)DeserializeFhirModel(response.Content);
        }

        public string Serialize(Parameter parameter)
        {
            return SerializeFhirModel((Resource)parameter.Value);
        }

        public string Serialize(object obj)
        {
            return SerializeFhirModel((Resource)obj);
        }

        private string SerializeFhirModel(Resource resource)
        {
            return _serializer.SerializeToString(resource);
        }

        public T Deserialize<T>(Stream content)
        {
            using (var reader = new StreamReader(content))
            {
                var json = reader.ReadToEnd();
                return (T)DeserializeFhirModel(json);
            }
        }

        private object DeserializeFhirModel(string json)
        {
            return _parser.Parse<Resource>(json);
        }
    }
}
