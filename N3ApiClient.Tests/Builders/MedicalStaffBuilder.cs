using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto;
using System;

namespace N3ApiClient.Tests.Builders
{
    public class MedicalStaffBuilder
    {
        private MedicalStaff _medicalStaff;
        public MedicalStaffBuilder() 
        {
            _medicalStaff = new MedicalStaff();
        }

        public MedicalStaffBuilder WithAddBaseMedicalStaff()
        {
            _medicalStaff.IdSpeciality = 14;
            _medicalStaff.IdLpu = "";
            _medicalStaff.IdPosition = 45;
            //Информация о персоне
            PersonWithIdentity person = new PersonWithIdentity();
            person.HumanName = new HumanName()
            {
                FamilyName = "Алиева",
                GivenName = "Жанна",
                MiddleName = "Алиевна"
            };
            person.IdPersonMis = "4";
            IdentityDocument document = new IdentityDocument()
            {
                IdDocumentType = 223,
                DocN = "15765836414",
                ProviderName = "ПФР",
                DocumentName = "СНИЛС"
            };
            person.Documents = new IdentityDocument[] { document };
            _medicalStaff.Person = person;

            return this;
        }


        public MedicalStaff Build()
        {
            return _medicalStaff;
        }
    }
}
