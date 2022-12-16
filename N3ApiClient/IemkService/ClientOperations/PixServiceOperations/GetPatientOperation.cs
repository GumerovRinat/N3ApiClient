using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.PixServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.PixServiceOperations
{
    public class GetPatientOperation : IPixClientOperation
    {
        private GetPatientDto _getPatientDto;

        private OperationResult _getPatientOperationResult;

        public GetPatientOperation(GetPatientDto getPatientDto)
        {
            _getPatientDto = getPatientDto;
            _getPatientOperationResult = new OperationResult();
        }

        public OperationResult Execute(PixServiceClient clientInstance)
        {
            var result = clientInstance.GetPatient(_getPatientDto.Token, _getPatientDto.IdLpu, _getPatientDto.PatientDto, _getPatientDto.idSource);
            if (result != null)
                _getPatientOperationResult.SetResult(result);
            return _getPatientOperationResult;
        }
    }
}
