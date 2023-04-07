using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.FhirPath.Sprache;
using N3ApiClient.OdliService.Operations;
using N3ApiClient.Tests.Builders.Odli;
using System;
using System.Linq;
using Xunit;

namespace N3ApiClient.Tests.Odli
{
    public class PatientTests
    {
        [Fact]
        public void AddFhirPatient_PatientDto_ReturnIdPatient()
        {
            // Arrange
            var patient = new PatientBuilder()
                .AddBasePatient()
                .WithAddSnils()
                .WithAddPolicy()
                .Build();

            // Act
            var result = new PatientOperations().AddPatient(patient);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.GetResult<string>());
        }

        [Fact]
        public void AddFhirPatient_PatientDto_ReturnError()
        {
            // Arrange
            var patient = new PatientBuilder()
                .AddBasePatient()
                .WithAddSnils()
                .WithEmptyFamily()
                .WithEmptyBirthDate()
                .Build();

            // Act
            var result = new PatientOperations().AddPatient(patient);

            // Assert
            Assert.False(result.IsSuccess());
            Assert.NotNull(result.GetException());
            Assert.NotEmpty(result.GetException().Message);
        }

        [Fact]
        public void UpdatePatient_PatientDto_ReturnIdPatient()
        {
            // Arrange
            var patient = new PatientBuilder()
                .AddBasePatient()
                .Build();

            // Act
            var result = new PatientOperations().AddPatient(patient);

            var patientToUpdate = new ResourceOperations().GetResource("Patient", result.GetResult<string>()).GetResult<Patient>();
            if (patientToUpdate != null)
            {
                patientToUpdate.Identifier.Add(new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                    Value = "43997827412",
                    Assigner = new ResourceReference
                    {
                        Display = "ПФР"
                    }
                });
                var updateResult = new PatientOperations().UpdatePatient(patientToUpdate);
            }

            var updatedPatient = new ResourceOperations().GetResource("Patient", result.GetResult<string>());

            // Assert
            Assert.NotNull(updatedPatient);
            Assert.NotNull(updatedPatient.GetResult<Patient>().Id);
            Assert.NotEmpty(updatedPatient.GetResult<Patient>().Id);
            Assert.NotNull(updatedPatient.GetResult<Patient>().Identifier.Where(x => x.System == "urn:oid:1.2.643.2.69.1.1.1.6.223").First());
        }

        [Fact]
        public void GetPatient_PatientDto_ReturnIdPatient()
        {
            // Arrange
            string patientId = "abae7c44-9898-4f03-9213-6ecedd874e7f";

            // Act
            var result = new ResourceOperations().GetResource("Patient", patientId);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.GetResult<Patient>().Id);
        }
    }
}
