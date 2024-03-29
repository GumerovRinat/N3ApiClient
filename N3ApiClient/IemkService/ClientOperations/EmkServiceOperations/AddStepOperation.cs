﻿using N3ApiClient.Base.Abstractions;
using N3ApiClient.IemkService.Abstractions;
using N3ApiClient.IemkService.DataContracts;
using N3ApiClient.IemkService.Dto;
using N3ApiClient.IemkService.Dto.EmkServiceDto;

namespace N3ApiClient.IemkService.ClientOperations.EmkServiceOperations
{
    public class AddStepOperation : IEmkClientOperation
    {
        private AddStepToCaseDto _addStepToCasetDto;
        private OperationResult _operationResult;

        public AddStepOperation(AddStepToCaseDto addStepToCasetDto)
        {
            _addStepToCasetDto = addStepToCasetDto;
            _operationResult = new OperationResult();
        }

        public IOperationResult Execute(EmkServiceClient clientInstance)
        {
            clientInstance.AddStepToCase(_addStepToCasetDto.Token, _addStepToCasetDto.IdLpu, _addStepToCasetDto.IdPatientMis,
                _addStepToCasetDto.IdCaseMis, _addStepToCasetDto.Step);
            return _operationResult;
        }
    }
}
