using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.DataContracts.N3.PixService.Dto;
using N3ApiClient.IemkService.Dto.PixServiceDto;
using N3ApiClient.Tests.Builders;
using System;
using Xunit;

namespace N3ApiClient.Tests.PixService
{
    public class GetPatientTests
    {
        [Fact]
        public void GetPatient_ResultIsSuccess()
        {
            //Arrange
            PatientTestsBuilder patientTestsBuilder = new PatientTestsBuilder();

            GetPatientDto getPatientDto = new GetPatientDto();
            getPatientDto.IdLpu = Constants.EMK_IDLPU;
            getPatientDto.Token = Constants.EMK_TOKEN;
            getPatientDto.idSource = IemkService.DataContracts.N3.EMK.Domain.Enums.SourceType.Reg;
            getPatientDto.PatientDto = patientTestsBuilder
                .WithCreateBasePatient()
                .AddSnils()
                .Build();

            var operation = new GetPatientOperation(getPatientDto);
            var creator = new PixClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
            Assert.NotNull(result.GetResult<PatientDto[]>());
        }
    }
}
