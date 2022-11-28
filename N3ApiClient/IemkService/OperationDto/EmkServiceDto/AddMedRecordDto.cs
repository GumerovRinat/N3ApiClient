using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.MedRec;

namespace N3ApiClient.IemkService.OperationDto.EmkServiceDto
{
    public class AddMedRecordDto : BaseDto
    {
        public string IdPatientMis { get; set; }

        public string IdCaseMis { get; set; }

        public MedRecord MedRecord { get; set; }

        public byte? Confidentiality { get; set; }
    }
}
