using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.EmkServiceOperations;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Case;
using N3ApiClient.IemkService.Dto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using N3ApiClient.Tests.Builders.Emk;
using Xunit;

namespace N3ApiClient.Tests.EmkService
{
    public class CloseCaseTests
    {
        [Fact]
        public void CloseCase_ResultSuccess()
        {
            //Arrange
            CaseDto closeCaseDto = new CaseDto()
            {
                Token = Constants.EMK_TOKEN,
                Case = new CaseBuilder().
                    WithCreateBaseAmbCase().
                    AddMedRecords().
                    Build()
            };
            closeCaseDto.Case.IdCaseMis = "deae7494-fc19-4838-9adc-3b8d3e04c625";
            closeCaseDto.Case.IdCaseResult = 1;           //Идентификатор исхода заболевания (Справочник OID: 1.2.643.5.1.13.2.1.1.688)
            closeCaseDto.Case.CloseDate = new System.DateTime(2022,11,10);
            closeCaseDto.Case.DoctorInCharge = new MedicalStaffBuilder().WithAddBaseMedicalStaff().Build();
            ((CaseAmb)closeCaseDto.Case).IdCaseType = 0;

            var operation = new CloseCaseOperation(closeCaseDto);
            var creator = new EmkClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
