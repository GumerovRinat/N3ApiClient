using N3ApiClient.IemkService.DataContracts.N3.PixService.Dto;
using System;
using System.Collections.Generic;

namespace N3ApiClient.Tests.Builders.Emk
{
    internal class PatientTestsBuilder
    {
        private PatientDto _patientDto;
        private List<DocumentDto> _documents;
        private List<AddressDto> _addresses;

        public PatientTestsBuilder()
        {
            _documents = new List<DocumentDto>();
            _addresses = new List<AddressDto>();
        }

        public PatientTestsBuilder WithCreateBasePatient()
        {
            _patientDto = new PatientDto()
            {
                BirthDate = DateTime.Parse("10.10.2000"),
                FamilyName = "Мисов",
                GivenName = "Интеграт",
                IdPatientMIS = "5445191D-0171-48ED-990E-19D756AA20AE",
                MiddleName = "Тестович",
                Sex = 2
            };
            return this;
        }

        public PatientTestsBuilder AddSnils()
        {
            DocumentDto document = new DocumentDto()
            {
                IdDocumentType = 223,
                DocN = "12345678900",
                ProviderName = "ПФР",
                DocumentName = "СНИЛС"
            };

            _documents.Add(document);
            return this;
        }

        public PatientTestsBuilder AddAddress()
        {
            _addresses.Add(GetAddress(1));
            _addresses.Add(GetAddress(2));
            return this;
        }

        public PatientDto Build()
        {
            if (_documents.Count > 0)
                _patientDto.Documents = _documents.ToArray();
            if (_addresses.Count > 0)
                _patientDto.Addresses = _addresses.ToArray();
            return _patientDto;
        }

        private AddressDto GetAddress(byte type)
        {
            AddressDto address = new AddressDto();
            address.IdAddressType = type;
            address.Building = "10";
            address.Appartment = "1";
            address.Street = "26025000001003200";
            address.City = "2602500000100";
            address.StringAddress = "Ставропольский край., Труновский р-н., Донское с. Ленина ул 17";
            return address;
        }
    }
}
