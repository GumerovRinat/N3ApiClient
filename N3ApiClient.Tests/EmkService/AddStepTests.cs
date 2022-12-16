using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.EmkServiceOperations;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.MedRec;
using N3ApiClient.IemkService.Dto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using Xunit;

namespace N3ApiClient.Tests.EmkService
{
    public class AddStepTests
    {
        [Fact]
        public void AddStep_ResultSuccess()
        {
            //Arrange
            AddStepToCaseDto addStepDto = new AddStepToCaseDto()
            {
                Token = Constants.EMK_TOKEN,
                IdLpu = Constants.EMK_IDLPU,
                IdPatientMis = "85E747C8-4BB1-4D54-9BAA-9112C2435849",
                IdCaseMis = "54ED160B-2F73-4503-B50D-210E970F4448"
            };
            addStepDto.Step = new StepBuilder().WithAddAmbStep().BuildAmbStep()[0];

            var operation = new AddStepOperation(addStepDto);
            var creator = new EmkClientCreator();

            //Act
            var result = creator.ExecuteOperation(operation);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
        }
    }
}
