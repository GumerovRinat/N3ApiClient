using Hl7.Fhir.Model;
using N3ApiClient.OdliService.Dto;
using System.Collections.Generic;
using static Hl7.Fhir.Model.Practitioner;

namespace N3ApiClient.OdliService.Mappers
{
    public static class PracticionerMapper
    {
        public static Practitioner MapPracticionerFromDto(PracticionerDto practicionerDto)
        {
            Practitioner practitioner = new Practitioner();
            practitioner.Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = "urn:oid:1.2.643.5.1.13.2.7.100.5",
                    Value = practicionerDto.PracticionerId,
                    Assigner = new ResourceReference
                    {
                        Display = practicionerDto.SystemId
                    }
                },
            };

            practitioner.Name = new HumanName
            {
                Family = new List<string>
                {
                    practicionerDto.SecondName,
                    practicionerDto.Patronymic
                },
                Given = new List<string> { practicionerDto.FirstName }
            };

            practitioner.PractitionerRole = new List<PractitionerRoleComponent>
            {
                new PractitionerRoleComponent
                {
                    ManagingOrganization = new ResourceReference
                    {
                        Reference = $"Organization/{practicionerDto.OrganisationId}"
                    },
                    //Должность
                    Role = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding
                            {
                                System = "urn:oid:1.2.643.5.1.13.13.11.1002",
                                Version = "7.6",
                                Code = practicionerDto.PositionId
                            }
                        }
                    },
                    //Специальность
                    Specialty = new List<CodeableConcept>
                    {
                        new CodeableConcept
                        {
                            Coding = new List<Coding>
                            {
                                new Coding
                                {
                                    System = "urn:oid:1.2.643.5.1.13.13.11.1066",
                                    Version = "5.4",
                                    Code = practicionerDto.SpecialityId
                                }
                            }
                        }
                    }
                }
            };

            if(!string.IsNullOrEmpty(practicionerDto.Snils))
            {
                practitioner.Identifier.Add(
                new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                    Value = practicionerDto.Snils,
                    Assigner = new ResourceReference
                    {
                        Display = "ПФР"
                    }
                });
            }

            return practitioner;
        }
    }
}
