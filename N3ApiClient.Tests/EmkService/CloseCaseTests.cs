using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.OperationDto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using Xunit;

namespace N3ApiClient.Tests.EmkService
{
    public class CloseCaseTests
    {
        [Fact]
        public void CreateCase_ResultSuccess()
        {
            //Arrange
            CaseDto closeCaseDto = new CaseDto()
            {
                Token = Constants.EMK_TOKEN,
                Case = new CaseBuilder().
                    WithCreateBaseAmbCase().
                    Build()
            };
                
            var operation = new CloseCaseOperation(closeCaseDto);
            var creator = new EmkServiceClientFactory();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
