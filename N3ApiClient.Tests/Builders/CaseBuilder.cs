using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Case;
using System;

namespace N3ApiClient.Tests.Builders
{
    internal class CaseBuilder
    {
        private CaseAmb _caseAmb;

        public CaseBuilder()
        {
            _caseAmb = new CaseAmb();
        }

        public CaseBuilder WithCreateBaseAmbCase()
        {
            _caseAmb.OpenDate = new DateTime(2022, 11, 23);
            _caseAmb.HistoryNumber = "FA4EE72D-146E-4BCA-A92F-077E7A0CCED0";
            _caseAmb.IdCaseMis = "6F7316EB-429E-4014-89D7-C0592531A38F";
            _caseAmb.IdCaseAidType = 1;                  //Идентификатор вида медицинского обслуживания (Справочник OID: 1.2.643.2.69.1.1.1.16)
            _caseAmb.IdPaymentType = 1;                  //Идентификатор источника финансирования (Справочник OID: 1.2.643.2.69.1.1.1.32)
            _caseAmb.Confidentiality = 1;                //Уровень конфиденциальности передаваемой информации (Справочник OID: 1.2.643.5.1.13.2.7.1.9)
            _caseAmb.DoctorConfidentiality = 1;          //Уровень конфиденциальности передаваемой информации для врача (Справочник OID: 1.2.643.5.1.13.2.7.1.9)
            _caseAmb.CuratorConfidentiality = 1;         //Уровень конфиденциальности передаваемой информации для представителя пациента/опекуна (Справочник OID: 1.2.643.5.1.13.2.7.1.9)
            _caseAmb.IdLpu = Constants.EMK_IDLPU;        //Идентификатор головной МО/ структурного подразделения МО
            _caseAmb.IdPatientMis = "85E747C8-4BB1-4D54-9BAA-9112C2435849";
            _caseAmb.IdCaseType = 2;                     //Идентификатор типа случая обслуживания: амбулаторный, диспансеризация (Справочник OID: 1.2.643.2.69.1.1.1.35)
            _caseAmb.CaseVisitType = 1;                  //Порядок обращения (Справочник OID: 1.2.643.5.1.13.13.11.1007)

            MedicalStaff currentDoctor = new MedicalStaffBuilder().WithAddBaseMedicalStaff().Build();
            //Лицо, подписывающее или визирующее формируемый набор медицинской информации
            Participant participant = new Participant();
            participant.Doctor = currentDoctor;
            participant.IdRole = 3;
            _caseAmb.Authenticator = participant;
            _caseAmb.Author = participant;
            return this;
        }

        public CaseAmb Build()
        {
            return _caseAmb;
        }
    }
}
