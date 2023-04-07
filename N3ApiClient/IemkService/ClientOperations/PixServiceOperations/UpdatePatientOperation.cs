using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.PixServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class UpdatePatientOperation : IPixClientOperation
    {
        private UpdatePatientDto _uddPatientDto;
        private OperationResult _operationResult;

        public UpdatePatientOperation(UpdatePatientDto updatePatientDto)
        {
            _uddPatientDto = updatePatientDto;
            _operationResult = new OperationResult();
        }

        public IOperationResult Execute(PixServiceClient clientInstance)
        {
            clientInstance.UpdatePatient(_uddPatientDto.Token, _uddPatientDto.IdLpu, _uddPatientDto.PatientDto);
            return _operationResult;
        }
    }
}
