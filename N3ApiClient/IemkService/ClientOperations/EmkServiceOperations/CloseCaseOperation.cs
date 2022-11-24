using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.OperationDto;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class CloseCaseOperation : IEmkClientOperation
    {
        private CaseDto _closeCasetDto;
        private OperationResult _operationResult;

        public CloseCaseOperation(CaseDto createCasetDto)
        {
            _closeCasetDto = createCasetDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.CloseCase(_closeCasetDto.Token, _closeCasetDto.Case);
            return _operationResult;
        }
    }
}
