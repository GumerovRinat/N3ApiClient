using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Common;
using N3ApiClient.IemkService.OperationDto;
using System;

namespace N3ApiClient.IemkService.ClientFactory
{
    public class PixClient : IPixClient
    {
        private PixServiceClient _clientInstance;

        public const string ServiceBinding = "BasicHttpBinding_IPixService";

        public PixClient(string serviceBinding = ServiceBinding)
        {
            _clientInstance = new PixServiceClient(serviceBinding);
        }

        public IOperationResult ExecuteOperation(IPixClientOperation operation)
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
                return new OperationResult().SetException(ex).SetSuccess(false);
            }
            catch (System.ServiceModel.FaultException<RequestWarning> ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(false);
            }
            catch (Exception ex)
            {
                return new OperationResult().SetException(ex).SetSuccess(false);
            }

        }
    }
}
