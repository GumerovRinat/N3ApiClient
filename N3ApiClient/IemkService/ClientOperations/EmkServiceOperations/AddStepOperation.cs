using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.OperationDto;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class AddStepOperation : IEmkClientOperation
    {
        private AddStepToCaseDto _addStepToCasetDto;
        private OperationResult _operationResult;

        public AddStepOperation(AddStepToCaseDto addStepToCasetDto)
        {
            _addStepToCasetDto = addStepToCasetDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.AddStepToCase(_addStepToCasetDto.Token, _addStepToCasetDto.IdLpu, _addStepToCasetDto.IdPatientMis,
                _addStepToCasetDto.IdCaseMis, _addStepToCasetDto.Step);
            return _operationResult;
        }
    }
}
