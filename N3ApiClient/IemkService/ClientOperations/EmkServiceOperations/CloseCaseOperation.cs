using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.EmkServiceOperations
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

        public IOperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.CloseCase(_closeCasetDto.Token, _closeCasetDto.Case);
            return _operationResult;
        }
    }
}
