using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Common;
using N3ApiClient.IemkService.Dto;
using System;

namespace N3ApiClient.IemkService.ClientFactory
{
    /// <summary>
    /// Клиент сервиса ИЭМК
    /// </summary>
    public class EmkClient : IEmkClient
    {
        private EmkServiceClient _clientInstance;

        public const string ServiceBinding = "BasicHttpBinding_IEmkService";

        /// <summary>
        /// Клиент сервиса ИЭМК
        /// </summary>
        /// <param name="serviceBinding">Данные эндпоинта</param>
        public EmkClient(string serviceBinding = ServiceBinding)
        {
            _clientInstance = new EmkServiceClient(serviceBinding);
        }

        /// <inheritdoc />
        public IOperationResult ExecuteOperation(IEmkClientOperation operation)
        {
            try
            {
                var operationResult = operation.Execute(_clientInstance);
                operationResult.SetSuccess(true);
                return operationResult;
            }
            catch (System.ServiceModel.FaultException<RequestFault[]> ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(false);
            }
            catch (System.ServiceModel.FaultException<RequestFault> ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(false);
            }
            catch (System.ServiceModel.FaultException<RequestWarning[]> ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(true);
            }
            catch (System.ServiceModel.FaultException<RequestWarning> ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(true);
            }
            catch (Exception ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(false);
            }
        }
    }
}
