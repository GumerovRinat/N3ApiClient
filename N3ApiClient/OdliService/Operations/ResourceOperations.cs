using Hl7.Fhir.Model;
using N3ApiClient.Base.Abstractions;
using System;

namespace N3ApiClient.OdliService.Operations
{
    public class ResourceOperations
    {
        private readonly N3RestClient.N3RestClient _client;

        public ResourceOperations()
        {
            _client = new N3RestClient.N3RestClient();
        }

        /// <summary>
        /// Получение ресурса
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public IOperationResult GetResource(string resourceType, string resourceId)
        {
            try
            {
                var result = _client.Get<Resource>($"{resourceType}/{resourceId}?_format=json");
                return new OdliOperationResult().SetSuccess(true).SetResult(result);
            }
            catch (Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }
    }
}
