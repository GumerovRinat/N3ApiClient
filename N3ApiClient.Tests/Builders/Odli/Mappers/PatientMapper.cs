using Hl7.Fhir.Model;
using N3ApiClient.OdliService.Dto;
using System.Collections.Generic;

namespace N3ApiClient.OdliService.Mappers
{
    public static class PatientMapper
    {
        public static Patient MapPatientFromDto(PatientDto patientDto)
        {
            var _patient = new Patient();

            _patient.Name = new List<HumanName>()
            {
                new HumanName()
                {
                    Family = new List<string>() { patientDto.Family, patientDto.Patronymic },
                    Given = new List<string>() { patientDto.Name }
                }
            };

            _patient.Identifier.Add(
                new Identifier()
                {
                    System = "urn:oid:1.2.643.5.1.13.2.7.100.5",
                    Value = patientDto.PatientId,
                    Assigner = new ResourceReference() { Display = $"Organization/{patientDto.OrganisationId}" }
                }
            );

            if(!string.IsNullOrEmpty(patientDto.Snils))
            {
                _patient.Identifier.Add(new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                    Value = patientDto.Snils,
                    Assigner = new ResourceReference { Display = "ПФР" } 
                });
            }

            if(patientDto.Policy != null)
            {
                _patient.Identifier.Add(new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.228",
                    Value = patientDto.Policy.Number,
                    Period = new Period { Start = patientDto.Policy.StartDate.ToString("yyyy-MM-dd") },
                    Assigner = new ResourceReference
                    {
                        Display = $"1.2.643.5.1.13.2.1.1.635.{patientDto.Policy.SmoCode}"
                    }
                });
            }

            _patient.BirthDate = patientDto.BirthDate.ToString("yyyy-MM-dd");
            _patient.Gender = patientDto.Gender == 0 ? AdministrativeGender.Female : AdministrativeGender.Male;

            _patient.ManagingOrganization = new ResourceReference { Reference = $"Organization/{patientDto.OrganisationId}" };

            return _patient;
        }
    }
}
