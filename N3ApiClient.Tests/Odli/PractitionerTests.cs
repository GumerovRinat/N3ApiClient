using Hl7.Fhir.Model;
using N3ApiClient.OdliService.Operations;
using N3ApiClient.Tests.Builders.Odli;
using System.Linq;
using Xunit;

namespace N3ApiClient.Tests.Odli
{
    public class PractitionerTests
    {
        [Fact]
        public void AddPractitioner_Practitioner_ReturnIdPractitioner()
        {
            // Arrange
            Practitioner practitioner = OdliService.Mappers.PracticionerMapper.MapPracticionerFromDto(
                new OdliService.Dto.PracticionerDto
                {
                    PracticionerId = "B3817A0C-3A81-4131-9E50-D6E1105867A9",
                    OrganisationId = "089beabb-b402-4318-afce-cc155d0e7ca8",
                    SystemId = "1.2.643.2.69.1.2.243",
                    SecondName = "Сватковская",
                    FirstName = "Галина",
                    Patronymic = "Николаевна",
                    PositionId = "35",
                    SpecialityId = "13",
                    Snils = "02191798759"
                });

            var operation = new PracticionerOperations();

            // Act
            var result = operation.AddPracticioner(practitioner);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.GetResult<string>());
        }

        [Fact]
        public void UpdatePractitioner_PractitionerDto_ReturnIdPractitioner()
        {
            // Arrange
            Practitioner practitioner = new PractitionerBuilder().CreateBasePractitioner().Build();
            var operation = new PracticionerOperations();

            // Act
            //Добавим врача
            var result = operation.AddPracticioner(practitioner);

            //Получим обратно
            var getPractitionerResult = new ResourceOperations().GetResource("Practitioner", result.GetResult<string>());
            var practitionerToUpdate = getPractitionerResult.GetResult<Practitioner>();

            if (practitionerToUpdate != null)
            {
                practitionerToUpdate.Identifier.Add(new Identifier
                {
                    System = "urn:oid:1.2.643.2.69.1.1.1.6.223",
                    Value = "01521621597",
                    Assigner = new ResourceReference
                    {
                        Display = "ПФР"
                    }
                });
                var updateResult = operation.UpdatePracticioner(practitionerToUpdate);
            }

            var getPractitionerResult2 = new ResourceOperations().GetResource("Practitioner", result.GetResult<string>());

            // Assert
            Assert.NotNull(getPractitionerResult2);
            Assert.NotNull(getPractitionerResult2.GetResult<Practitioner>().Id);
            Assert.NotNull(getPractitionerResult2.GetResult<Practitioner>().Identifier.Where(x => x.System == "urn:oid:1.2.643.2.69.1.1.1.6.223").First());
        }
    }
}
