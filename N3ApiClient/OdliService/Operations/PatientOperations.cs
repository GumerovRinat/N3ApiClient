using Hl7.Fhir.Model;
using N3ApiClient.Base.Abstractions;
using N3ApiClient.N3RestClient.Exceptions;

namespace N3ApiClient.OdliService.Operations
{
    public class PatientOperations
    {
        private readonly N3RestClient.N3RestClient _client;

        public PatientOperations()
        {
            _client = new N3RestClient.N3RestClient();
        }

        /// <summary>
        /// Добавления пациента
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="patient"></param>
        /// <returns></returns>
        public IOperationResult AddPatient(Resource patient)
        {
            try
            {
                var result = _client.Post<Resource>("Patient?_format=json", patient);
                return new OdliOperationResult().SetSuccess(true).SetResult(result.Id);
            }
            catch (System.Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Обновление пациента
        /// </summary>
        /// <param name="patient"></param>
        /// <exception cref="N3RestClientException"></exception>
        public IOperationResult UpdatePatient(Resource patient)
        {
            try
            {
                if (!string.IsNullOrEmpty(patient.Id))
                {
                    _client.Put($"Patient/{patient.Id}?_format=json", patient);
                    return new OdliOperationResult().SetSuccess(true);
                }
                else
                    throw new N3RestClientException(System.Net.HttpStatusCode.BadRequest, "Не заполнено поле PatientId", null, null);
            }
            catch (System.Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }
    }
}
