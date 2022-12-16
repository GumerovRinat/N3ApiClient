using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto.PixServiceDto;
using N3ApiClient.IemkService.Dto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class AddPatientOperation : IPixClientOperation
    {
        private AddPatientDto _addPatientDto;
        private OperationResult _operationResult;

        public AddPatientOperation(AddPatientDto addPatientDto)
        {
            _addPatientDto = addPatientDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(PixServiceClient clientInstance)
        {
            clientInstance.AddPatient(_addPatientDto.Token, _addPatientDto.IdLpu, _addPatientDto.PatientDto);
            return _operationResult;
        }
    }
}
