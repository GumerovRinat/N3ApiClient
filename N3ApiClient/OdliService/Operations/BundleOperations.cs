using Hl7.Fhir.Model;
using N3ApiClient.AppointmentService.DataContract.HubService2.ContractsClasses.PostAppointment;
using N3ApiClient.Base.Abstractions;
using N3ApiClient.N3RestClient.Exceptions;
using N3ApiClient.OdliService.Dto;
using System;
using System.Net;

namespace N3ApiClient.OdliService.Operations
{
    public class BundleOperations
    {
        private readonly N3RestClient.N3RestClient _client;

        public BundleOperations()
        {
            _client = new N3RestClient.N3RestClient();
        }

        /// <summary>
        /// Добавление заявки
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bundleDto"></param>
        /// <returns></returns>
        public IOperationResult AddBundle(Bundle bundleDto)
        {
            try
            {
                var result = _client.Post<Resource>("?_format=json", bundleDto);
                return new OdliOperationResult().SetSuccess(true).SetResult(result.Id);
            }
            catch (Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Обновление заявки
        /// </summary>
        /// <param name="bundleDto">Заявка</param>
        public IOperationResult UpdateBundle(Bundle bundleDto)
        {
            try
            {
                if (!string.IsNullOrEmpty(bundleDto.Id))
                {
                    _client.Put($"{bundleDto.Id}?_format=json", bundleDto);
                    return new OdliOperationResult().SetSuccess(true);
                }
                else
                    throw new N3RestClientException(HttpStatusCode.BadRequest, "Не заполнено поле PracticionerId", null, null);
            }
            catch (Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Получение списка заказов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public IOperationResult GetOrders(Parameters parameters)
        {
            try
            {
                var result = _client.Post<Parameters>("$getorders?_format=json", parameters);
                return new OdliOperationResult().SetSuccess(true).SetResult(result);
            }
            catch(Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Получение заказа по ИД в МИС или Штрих-коду
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public IOperationResult GetOrder(Parameters request)
        {
            try
            {
                var result = _client.Post<Parameters>("$getorder?_format=json", request);
                return new OdliOperationResult().SetSuccess(true).SetResult(result);
            }
            catch (Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }

        /// <summary>
        /// Получение результатов исследований
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public IOperationResult GetResults(Parameters request)
        {
            try
            {
                var result = _client.Post<Parameters>("$getresults?_format=json", request);
                return new OdliOperationResult().SetSuccess(true).SetResult(result);
            }
            catch (Exception ex)
            {
                return new OdliOperationResult().SetSuccess(false).SetException(ex);
            }
        }
    }
}
