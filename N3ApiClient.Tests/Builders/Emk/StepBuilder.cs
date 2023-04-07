using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Step;
using System.Collections.Generic;

namespace N3ApiClient.Tests.Builders.Emk
{
    public class StepBuilder
    {
        private List<StepAmb> _ambSteps;

        public StepBuilder()
        {
            _ambSteps = new List<StepAmb>();
        }

        public StepBuilder WithAddAmbStep()
        {
            //Информация об эпизоде случая медицинского обслуживания
            StepAmb stepAmb = new StepAmb();
            stepAmb.DateStart = new System.DateTime(2022, 11, 10);
            stepAmb.DateEnd = new System.DateTime(2022, 11, 10);
            stepAmb.IdStepMis = "deae7494-fc19-4838-9adc-3b8d3e04c625";
            stepAmb.IdVisitPlace = 1;           //Идентификатор места посещения (Классификатор мест обслуживания, Справочник OID: 1.2.643.2.69.1.1.1.18)
            stepAmb.IdVisitPurpose = 1;         //Идентификатор цели посещения (Классификатор целей посещения амбулаторно-поликлинической организации, Справочник OID: 1.2.643.2.69.1.1.1.19)
            stepAmb.Doctor = new MedicalStaffBuilder().WithAddBaseMedicalStaff().Build();
            _ambSteps.Add(stepAmb);

            return this;
        }

        public StepAmb[] BuildAmbStep()
        {
            return _ambSteps.ToArray();
        }
    }
}
