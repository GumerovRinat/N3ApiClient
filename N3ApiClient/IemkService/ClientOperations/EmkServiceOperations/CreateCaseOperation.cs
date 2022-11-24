using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.OperationDto;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class CreateCaseOperation : IEmkClientOperation
    {
        private CaseDto _createCasetDto;
        private OperationResult _operationResult;

        public CreateCaseOperation(CaseDto createCasetDto)
        {
            _createCasetDto = createCasetDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.CreateCase(_createCasetDto.Token, _createCasetDto.Case);
            return _operationResult;
        }
    }
}
