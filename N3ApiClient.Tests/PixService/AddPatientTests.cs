using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.Dto.PixServiceDto;
using N3ApiClient.Tests.Builders.Emk;
using System;
using Xunit;

namespace N3ApiClient.Tests.PixService
{
    public class AddPatientTests
    {
        [Fact]
        public void AddPatient_ResultSuccess()
        {
            //Arrange
            PatientTestsBuilder patientTestsBuilder = new PatientTestsBuilder();

            AddPatientDto addPatientDto = new AddPatientDto();
            addPatientDto.IdLpu = Constants.EMK_IDLPU;
            addPatientDto.Token = Constants.EMK_TOKEN;
            addPatientDto.PatientDto = patientTestsBuilder
                .WithCreateBasePatient()
                .AddSnils()
                .Build();

            var operation = new AddPatientOperation(addPatientDto);
            var creator = new PixClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
