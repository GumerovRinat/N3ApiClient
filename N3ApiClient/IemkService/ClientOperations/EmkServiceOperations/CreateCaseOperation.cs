using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.EmkServiceOperations
{
    public class CreateCaseOperation : IEmkClientOperation
    {
        private CaseDto _createCaseDto;
        private OperationResult _operationResult;

        public CreateCaseOperation(CaseDto createCasetDto)
        {
            _createCaseDto = createCasetDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.CreateCase(_createCaseDto.Token, _createCaseDto.Case);
            return _operationResult;
        }
    }
}
