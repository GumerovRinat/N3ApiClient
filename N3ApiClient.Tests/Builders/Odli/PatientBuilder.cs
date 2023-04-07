using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace N3ApiClient.Tests.Builders.Odli
{
    internal class PatientBuilder
    {

        private readonly Patient _patient;

        public PatientBuilder()
        {
            _patient = new Patient();
        }

        public PatientBuilder AddBasePatient()
        {
            _patient.Identifier.Add(
                new Identifier() 
                { 
                    System = "urn:oid:1.2.643.5.1.13.2.7.100.5", 
                    Value = "6D60B4CE-C28D-421D-9508-E02373BC1CC0",
                    Assigner = new ResourceReference() { Display = Constants.SYSTEM_ID }
                }
            );
            
            var name = new HumanName();
            name.Family = new List<string>()
            {
                "Тимофеенко", "Николаевич"
            };
            name.Given = new List<string>() { "Сергей" };
            _patient.Name = new List<HumanName>() { name };

            _patient.BirthDate = "1979-02-12";
            _patient.Gender = AdministrativeGender.Male;

            _patient.ManagingOrganization = new ResourceReference { Reference = Constants.ASSIGNER_RESOURCE };

            return this;
        }

        public PatientBuilder WithAddSnils()
        {
            _patient.Identifier.Add(new Identifier
            {
                System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                Value = "13877203988",
                Assigner = new ResourceReference
                {
                    Display = "ПФР"
                }
            });
            return this;
        }

        public PatientBuilder WithAddPolicy()
        {
            _patient.Identifier.Add(new Identifier
            {
                System = "urn:oid:1.2.643.2.69.1.1.1.6.228",
                Value = "2657020837000348",
                Period = new Period { Start = "2014-04-28" },
                Assigner = new ResourceReference
                {
                    Display = "1.2.643.5.1.13.2.1.1.635.26008"
                }
            });
            return this;
        }

        public PatientBuilder WithEmptyFamily()
        {
            if(_patient.Name != null && _patient.Name.Count > 0)
            {
                _patient.Name.Clear();
            }
            return this;
        }

        public PatientBuilder WithEmptyBirthDate()
        {
            if (!string.IsNullOrEmpty(_patient.BirthDate))
            {
                _patient.BirthDate = null;
            }
            return this;
        }

        public Patient Build()
        {

            return _patient;
        }
    }
}
