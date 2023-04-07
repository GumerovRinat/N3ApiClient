using N3ApiClient.Tests.Builders.Odli;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using N3ApiClient.OdliService.Operations;
using System.IO;
using N3ApiClient.OdliService.Dto;

namespace N3ApiClient.Tests.Odli
{
    public class BundleTests
    {
        [Fact]
        public void AddBundle_Bundle_ReturnBundleId()
        {
            //Arrange
            Bundle bundle = new BundleBuilder()
                .CreateBaseAddBundle()
                .AddOrder()
                .AddDiagnosticOrder()
                .AddSpecimen()
                .AddEncounter()
                .AddCondition()
                .Build();

            //Act
            var result = new BundleOperations().AddBundle(bundle);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
            Assert.NotNull(result.GetResult<string>());
            Assert.NotEmpty(result.GetResult<string>());
        }


        [Fact]
        public void GetBundlesByTarget_SearchParameters_ReturnBundleList()
        {
            //Arrange
            Parameters parameters = new Parameters()
            {
                Parameter = new List<Parameters.ParameterComponent>()
                {
                    new Parameters.ParameterComponent { Name =  "TargetCode", Value = new FhirString { Value = "089beabb-b402-4318-afce-cc155d0e7ca8" } },
                    new Parameters.ParameterComponent { Name =  "StartDate", Value = new FhirDateTime { Value = DateTime.Now.AddDays(-14).ToString("yyyy-MM-ddTHH:MM:ss.000Z") } },
                    new Parameters.ParameterComponent { Name =  "EndDate", Value = new FhirDateTime { Value = DateTime.Now.AddDays(14).ToString("yyyy-MM-ddTHH:MM:ss.000Z") } },
                    new Parameters.ParameterComponent { Name =  "_count", Value = new FhirString { Value = "100" } },
                }
            };

            //Act
            var result = new BundleOperations().GetOrders(parameters);

            //Assert
            Assert.NotNull(result);
            Assert.NotNull(result.GetResult<Parameters>());
            Assert.Equal("Order", result.GetResult<Parameters>().Parameter[0].Name);
            Assert.NotNull(result.GetResult<Parameters>().Parameter[0].Resource);
        }

        [Fact]
        public void GetBundlesByMisId_GetBundlsDto_ReturnBundleList()
        {
            //Arrange
            Parameters parameters = new Parameters()
            {
                Parameter = new List<Parameters.ParameterComponent>()
                {
                    new Parameters.ParameterComponent { Name =  "TargetCode", Value = new FhirString { Value = Constants.ORG_ID } },
                    new Parameters.ParameterComponent { Name =  "SourceCode", Value = new FhirString { Value = Constants.ORG_ID } },
                    new Parameters.ParameterComponent { Name =  "StartDate", Value = new FhirDateTime { Value = DateTime.Now.AddDays(-40).ToString("yyyy-MM-ddTHH:MM:ss.000Z") } },
                    new Parameters.ParameterComponent { Name =  "OrderMisID", Value = new FhirString { Value = "ccb097b8-5f49-4b30-9554-048ae2aed676" } },
                }
            };

            //Act
            var result = new BundleOperations().GetOrders(parameters);

            //Assert
            Assert.NotNull(result);

            var resultParams = result.GetResult<Parameters>();
            Assert.NotEmpty(resultParams.Parameter);
            Assert.Equal("Order", resultParams.Parameter[0].Name);
            Assert.NotNull(resultParams.Parameter[0].Resource);
            Assert.IsType<Order>(resultParams.Parameter[0].Resource);
            Assert.NotEmpty(((Order)resultParams.Parameter[0].Resource).Identifier);
            Assert.NotNull(((Order)resultParams.Parameter[0].Resource).Identifier.Where(x => x.System == "urn:oid:1.2.643.2.69.1.2.243").First());
            Assert.Equal("ccb097b8-5f49-4b30-9554-048ae2aed676", ((Order)resultParams.Parameter[0].Resource).Identifier.Where(x => x.System == "urn:oid:1.2.643.2.69.1.2.243").First().Value);
        }

        [Fact]
        public void AddResult_Bundle_ResultSuccess()
        {
            //Arrange
            Bundle bundle = new BundleBuilder()
                .CreateBaseResultBundle()
                .AddObservation()
                .AddDiagnosticReport()
                .AddOrderResponse()
                .AddBinary()
                .Build();

            //Act
            var result = new BundleOperations().AddBundle(bundle);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
            Assert.NotNull(result.GetResult<string>());
            Assert.NotEmpty(result.GetResult<string>());
        }

        [Fact]
        public void AddResultWithoutOrder_Bundle_ResultSuccess()
        {
            //Arrange
            string filePath = @"D:\Result.pdf";
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            byte[] buffer = File.ReadAllBytes(filePath);

            BundleRequestDto bundleDto = new BundleRequestDto()
            {
                OrderId = Guid.NewGuid().ToString(),
                OrganisationId = "089beabb-b402-4318-afce-cc155d0e7ca8",
                SystemId = "1.2.643.2.69.1.2.243",
                OrderMisId = Guid.NewGuid().ToString(),
                DateOrder = DateTime.Now,
                PatientId = "abae7c44-9898-4f03-9213-6ecedd874e7f",
                PractitionerId = "a24ba513-b834-4784-bdf7-eb297f3a6b75",
                DiagnosticOrderId = Guid.NewGuid().ToString(),
                ResultMisId = Guid.NewGuid().ToString(),
                DateResult = DateTime.Now,
                Observation = new ObservationDto
                {
                    Id = Guid.NewGuid().ToString(),
                    Interpretation = Interpretation.N,
                    LabTestCode = "1170570",
                    DateIssued = DateTime.Now,
                    ResultValue = 835,
                    ReferenceLow = 500,
                    ReferenceHigh = 1000
                },
                DiagnosticReport = new DiagnosticReportDto
                {
                    Id = Guid.NewGuid().ToString(),
                    ServiceCode = "A12.06.001.002"
                },
                Binary = new BinaryDto
                {
                    Id = Guid.NewGuid().ToString(),
                    Content = buffer
                }
            };

            Bundle bundle = new OdliService.Mappers.BundleBuilder(bundleDto)
                .AddMetaForResultWithoutOrder()
                .AddEmptyOrder()
                .AddEmptyOrderResponse()
                .AddObservation()
                .AddEmptyDiagnosticReport()
                .AddBinary()
                .Build();


            //Act
            var result = new BundleOperations().AddBundle(bundle);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess());
            Assert.NotNull(result.GetResult<string>());
            Assert.NotEmpty(result.GetResult<string>());
        }

        [Fact]
        public void GetResult_SearchParameters_ReturnOrderResponse()
        {
            //Arrange
            Parameters parameters = new Parameters()
            {
                Parameter = new List<Parameters.ParameterComponent>()
                {
                    new Parameters.ParameterComponent { Name =  "TargetCode", Value = new FhirString { Value = Constants.ORG_ID } },
                    new Parameters.ParameterComponent { Name =  "SourceCode", Value = new FhirString { Value = Constants.ORG_ID } },
                    new Parameters.ParameterComponent { Name =  "StartDate", Value = new FhirDateTime { Value = DateTime.Now.AddDays(-14).ToString("yyyy-MM-ddTHH:MM:ss.000Z") } },
                }
            };

            //Act
            var result = new BundleOperations().GetResults(parameters);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetDiagnosticReport_DiagnosticReportId_ReturnDiagnosticReport()
        {
            //Arrange
            string resType = "DiagnosticReport";
            string resId = "a8147f4a-d768-4480-bd0f-c483b734647f";

            //Act
            var result = new ResourceOperations().GetResource(resType, resId);

            //Assert
            Assert.NotNull(result.GetResult<DiagnosticReport>());
        }

        [Fact]
        public void GetObservation_ObservationId_ReturnObservation()
        {
            //Arrange
            string resType = "Observation";
            string resId = "a4944a7f-d3df-4020-8108-a5beeac9b3d9";

            //Act
            var result = new ResourceOperations().GetResource(resType, resId);

            //Assert
            Assert.NotNull(result.GetResult<Observation>());
        }
    }
}
