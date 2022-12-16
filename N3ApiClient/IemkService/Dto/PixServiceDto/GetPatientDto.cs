using N3ApiClient.IemkService.DataContracts.N3.EMK.Domain.Enums;
using N3ApiClient.IemkService.DataContracts.N3.PixService.Dto;

namespace N3ApiClient.IemkService.Dto.PixServiceDto
{
    public class GetPatientDto : BaseDto
    {
        public PatientDto PatientDto { get; set; }

        public SourceType idSource { get; set; }
    }
}
