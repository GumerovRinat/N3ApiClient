using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.EmkServiceOperations;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using Xunit;

namespace N3ApiClient.Tests.EmkService
{
    public class AddCaseTests
    {
        [Fact]
        public void AddCase_ResultSuccess()
        {
            //Arrange
            CaseDto addCaseDto = new CaseDto()
            {
                Token = Constants.EMK_TOKEN,
                Case = new CaseBuilder().
                    WithCreateBaseAmbCase().
                    AddAmbSteps().
                    AddMedRecords().
                    Build()
            };
            addCaseDto.Case.CloseDate = new System.DateTime(2022, 11, 10);
            addCaseDto.Case.IdCaseResult = 1;
            addCaseDto.Case.DoctorInCharge = new MedicalStaffBuilder().WithAddBaseMedicalStaff().Build();
            addCaseDto.Case.Comment = "Закрытый случай";
                
            var operation = new AddCaseOperation(addCaseDto);
            var creator = new EmkClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
