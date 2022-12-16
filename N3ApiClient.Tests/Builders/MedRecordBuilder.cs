
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.MedRec;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.MedRec.Diag;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace N3ApiClient.Tests.Builders
{
    public class MedRecordBuilder
    {
        private List<MedRecord> _medRecords;

        public MedRecordBuilder()
        {
            _medRecords = new List<MedRecord>();
        }


        public MedRecordBuilder AddMainDiagnosis()
        {
            ClinicMainDiagnosis mainDiagnosis = CreateDiagnosis();
            mainDiagnosis.DiagnosisInfo.IdDiagnosisType = 1;
            mainDiagnosis.DiagnosisInfo.Comment = "Основной диагноз";
            _medRecords.Add(mainDiagnosis);
            return this;
        }

        public MedRecordBuilder AddComplicationDiagnosis()
        {
            ClinicMainDiagnosis complicationDiagnosis = CreateDiagnosis();
            complicationDiagnosis.DiagnosisInfo.IdDiagnosisType = 3;
            complicationDiagnosis.DiagnosisInfo.Comment = "Осложнение основного диагноза";
            _medRecords.Add(complicationDiagnosis);
            return this;
        }

        public MedRecord[] Build()
        {
            return _medRecords.ToArray();
        }

        private ClinicMainDiagnosis CreateDiagnosis()
        {
            ClinicMainDiagnosis mainDiagnosis = new ClinicMainDiagnosis();
            mainDiagnosis.Doctor = new MedicalStaffBuilder().WithAddBaseMedicalStaff().Build();
            DiagnosisInfo diagnosisInfo = new DiagnosisInfo();
            //diagnosisInfo.DiagnosedDate = new System.DateTime(2022,11,10);
            //diagnosisInfo.MkbCode = "I11.9";
            mainDiagnosis.DiagnosisInfo = diagnosisInfo;
            return mainDiagnosis;
        }
    }
}
