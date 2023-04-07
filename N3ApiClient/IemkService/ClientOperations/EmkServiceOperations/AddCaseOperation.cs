using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.EmkServiceOperations
{
    public class AddCaseOperation : IEmkClientOperation
    {
        private CaseDto _addCaseDto;
        private OperationResult _operationResult;

        public AddCaseOperation(CaseDto addCaseDto)
        {
            _addCaseDto = addCaseDto;
            _operationResult = new OperationResult();
        }

        public IOperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.AddCase(_addCaseDto.Token, _addCaseDto.Case);
            return _operationResult;
        }
    }
}
