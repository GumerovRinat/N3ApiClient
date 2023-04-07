using Hl7.Fhir.Model;
using System.Collections.Generic;
using static Hl7.Fhir.Model.Practitioner;

namespace N3ApiClient.Tests.Builders.Odli
{
    internal class PractitionerBuilder
    {
        Practitioner _practitionerDto;
        public PractitionerBuilder()
        {
            _practitionerDto = new Practitioner();
        }

        public PractitionerBuilder CreateBasePractitioner()
        {
            _practitionerDto = new Practitioner
            {
                Identifier = new List<Identifier>
                {
                    new Identifier
                    {
                        System = "urn:oid:1.2.643.5.1.13.2.7.100.5",
                        Value = "B3817A0C-3A81-4131-9E50-D6E1105867A9",
                        Assigner = new ResourceReference
                        {
                            Display = "1.2.643.2.69.1.2.243"
                        }
                    },
                },
                Name = new HumanName
                {
                    Family = new List<string>
                    {
                        "Сватковская",
                        "Николаевна"
                    },
                    Given = new List<string>
                    {
                        "Галина"
                    }
                },
                PractitionerRole = new List<PractitionerRoleComponent>
                {
                    new PractitionerRoleComponent
                    {
                        ManagingOrganization = new ResourceReference
                        {
                            Reference = "Organization/089beabb-b402-4318-afce-cc155d0e7ca8"
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
                                    Code = "35"
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
                                        Code = "13"
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return this;
        }

        public PractitionerBuilder AddSnils()
        {
            _practitionerDto.Identifier.Add(
                new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                    Value = "02191798759",
                    Assigner = new ResourceReference
                    {
                        Display = "ПФР"
                    }
                });
            return this;
        }

        public Practitioner Build()
        {
            return _practitionerDto;
        }
    }
}
