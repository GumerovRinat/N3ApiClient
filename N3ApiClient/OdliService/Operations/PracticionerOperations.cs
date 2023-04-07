using Hl7.Fhir.Model;
using N3ApiClient.Base.Abstractions;
using N3ApiClient.N3RestClient.Exceptions;
using System.IO;

namespace N3ApiClient.OdliService.Operations
{
    public class PracticionerOperations
    {
        private readonly N3RestClient.N3RestClient _client;

        public PracticionerOperations()
        {
            _client = new N3RestClient.N3RestClient();
        }

        /// <summary>
        /// Добавление врача
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="practitionerDto"></param>
        /// <returns></returns>
        public IOperationResult AddPracticioner(Practitioner practitionerDto)
        {
            try
            {
                var result = _client.Post<Resource>("Practitioner?_format=json", practitionerDto);
                return new OdliOperationResult().SetSuccess(true).SetResult(result.Id);
            }
            catch (System.Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Обновление врача
        /// </summary>
        /// <param name="practitionerDto"></param>
        /// <exception cref="N3RestClientException"></exception>
        public IOperationResult UpdatePracticioner(Practitioner practitionerDto)
        {
            try
            {
                if (!string.IsNullOrEmpty(practitionerDto.Id))
                {
                    _client.Put($"Practitioner/{practitionerDto.Id}?_format=json", practitionerDto);
                    return new OdliOperationResult().SetSuccess(true);
                }
                else
                    throw new N3RestClientException(System.Net.HttpStatusCode.BadRequest, "Не заполнено поле PracticionerId", null, null);
            }
            catch (System.Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }
    }
}
