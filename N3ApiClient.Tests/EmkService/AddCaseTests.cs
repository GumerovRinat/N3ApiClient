using N3ApiClient.IemkService.ClientFactory;
using N3ApiClient.IemkService.ClientOperations.EmkServiceOperations;
using N3ApiClient.IemkService.ClientOperations.PixServiceOperations;
using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Common;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;
using N3ApiClient.Tests.Builders;
using System.ServiceModel;
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

        [Fact]
        public void AddCaseWithWarning_ResultSuccess_WarningMessageIsNotNull()
        {
            //Arrange
            RequestWarning warning = new RequestWarning()
            {
                PropertyName = "ConsultNote",
                Message = "Поле содержит ошибки",
                WarningCode = 8,
                Warnings = new RequestWarning[]
                {
                    new RequestWarning
                    {
                        PropertyName = "Attachments",
                        Message = "Есть PDF, нет TXT",
                        WarningCode = 2135
                    }
                }
            };
            var faultException = new FaultException<RequestWarning[]>(new RequestWarning[] { warning });
            var result = new OperationResult().SetException(faultException).SetSuccess(true);

            //Act


            //Assert
            Assert.True(result.IsSuccess());
            Assert.NotNull(result.GetException().WarningMessage);
        }
    }
}
