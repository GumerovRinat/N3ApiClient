using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.EmkServiceOperations
{
    public class AddMedRecordOperation : IEmkClientOperation
    {
        private AddMedRecordDto _addMedRecordDto;
        private OperationResult _operationResult;

        public AddMedRecordOperation(AddMedRecordDto addMedRecordDto)
        {
            _addMedRecordDto = addMedRecordDto;
            _operationResult = new OperationResult();
        }

        public OperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.AddMedRecord(_addMedRecordDto.Token, _addMedRecordDto.IdLpu, _addMedRecordDto.IdPatientMis,
                _addMedRecordDto.IdCaseMis, _addMedRecordDto.MedRecord, _addMedRecordDto.Confidentiality);
            return _operationResult;
        }
    }
}
