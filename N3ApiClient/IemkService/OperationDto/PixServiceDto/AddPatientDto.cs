using N3ApiClient.IemkService.DataContracts.N3.PixService.Dto;

namespace N3ApiClient.IemkService.OperationDto.PixServiceDto
{
    public class AddPatientDto : BaseDto
    {
        public PatientDto PatientDto { get; set; }
    }
}
