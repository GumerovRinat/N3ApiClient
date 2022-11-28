using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.EmkServiceOperations;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using Xunit;

namespace N3ApiClient.Tests.EmkService
{
    public class CreateCaseTests
    {
        [Fact]
        public void CreateCase_ResultSuccess()
        {
            //Arrange
            CaseDto createCaseDto = new CaseDto()
            {
                Token = Constants.EMK_TOKEN,
                Case = new CaseBuilder().
                    WithCreateBaseAmbCase().
                    AddAmbSteps().
                    Build()
            };
            createCaseDto.Case.IdCaseMis = "54ED160B-2F73-4503-B50D-210E970F4448";

            var operation = new CreateCaseOperation(createCaseDto);
            var creator = new EmkClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
