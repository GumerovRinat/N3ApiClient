using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Step;

namespace N3ApiClient.IemkService.Dto.EmkServiceDto
{
    public class AddStepToCaseDto : BaseDto
    {
        public string IdPatientMis { get; set; }

        public string IdCaseMis { get; set; }

        public StepBase Step { get; set; }
    }
}
