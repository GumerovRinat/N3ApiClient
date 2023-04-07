using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.DataContracts.N3.PixService.Dto;
using N3ApiClient.IemkService.Dto.PixServiceDto;
using N3ApiClient.Tests.Builders.Emk;
using System;
using Xunit;

namespace N3ApiClient.Tests.PixService
{
    public class UpdatePatientTests
    {
        [Fact]
        public void UpdatePatient_ResultIsSuccess()
        {
            //Arrange
            PatientTestsBuilder patientTestsBuilder = new PatientTestsBuilder();
            string newIdMis = Guid.NewGuid().ToString();


            GetPatientDto getPatientDto = new GetPatientDto();
            getPatientDto.IdLpu = Constants.EMK_IDLPU;
            getPatientDto.Token = Constants.EMK_TOKEN;
            getPatientDto.PatientDto = patientTestsBuilder
                .WithCreateBasePatient()
                .AddSnils()
                .Build();
            getPatientDto.PatientDto.FamilyName += "���";
            //getPatientDto.PatientDto.IdPatientMIS = newIdMis;

            UpdatePatientDto updatePatientDto = new UpdatePatientDto();
            updatePatientDto.IdLpu = Constants.EMK_IDLPU;
            updatePatientDto.Token = Constants.EMK_TOKEN;
            updatePatientDto.PatientDto = patientTestsBuilder
                .WithCreateBasePatient()
                .Build();
            updatePatientDto.PatientDto.FamilyName += "���";
            //updatePatientDto.PatientDto.IdPatientMIS = newIdMis;

            var updateOperation = new UpdatePatientOperation(updatePatientDto);
            var getOperation = new GetPatientOperation(getPatientDto);
            var creator = new PixClientCreator();

            //Act
            var updateResult = creator.ExecuteOperation(updateOperation);
            var getResult = creator.ExecuteOperation(getOperation);

            //Assert
            Assert.NotNull(updateResult);
            Assert.NotNull(getResult);
            Assert.True(updateResult.IsSuccess());
            Assert.True(getResult.IsSuccess());
            var patients = getResult.GetResult<PatientDto[]>();
            Assert.True(patients.Length > 0);
        }
    }
}
