using N3ApiClient.IemkService.Abstractions;

namespace N3ApiClient.IemkService.DataContracts
{
    namespace N3.PixService.Dto
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PatientDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class PatientDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private AddressDto[] AddressesField;

            private System.DateTime BirthDateField;

            private BirthPlaceDto BirthPlaceField;

            private ContactPersonDto ContactPersonField;

            private ContactDto[] ContactsField;

            private System.Nullable<System.DateTime> DeathTimeField;

            private DocumentDto[] DocumentsField;

            private string FamilyNameField;

            private string GivenNameField;

            private System.Nullable<byte> IdBloodTypeField;

            private string IdGlobalField;

            private System.Nullable<byte> IdLivingAreaTypeField;

            private string IdPatientMISField;

            private bool IsVipField;

            private JobDto JobField;

            private string MiddleNameField;

            private PrivilegeDto PrivilegeField;

            private byte SexField;

            private System.Nullable<byte> SocialGroupField;

            private string SocialStatusField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public AddressDto[] Addresses
            {
                get
                {
                    return this.AddressesField;
                }
                set
                {
                    this.AddressesField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime BirthDate
            {
                get
                {
                    return this.BirthDateField;
                }
                set
                {
                    this.BirthDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public BirthPlaceDto BirthPlace
            {
                get
                {
                    return this.BirthPlaceField;
                }
                set
                {
                    this.BirthPlaceField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public ContactPersonDto ContactPerson
            {
                get
                {
                    return this.ContactPersonField;
                }
                set
                {
                    this.ContactPersonField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public ContactDto[] Contacts
            {
                get
                {
                    return this.ContactsField;
                }
                set
                {
                    this.ContactsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> DeathTime
            {
                get
                {
                    return this.DeathTimeField;
                }
                set
                {
                    this.DeathTimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public DocumentDto[] Documents
            {
                get
                {
                    return this.DocumentsField;
                }
                set
                {
                    this.DocumentsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string FamilyName
            {
                get
                {
                    return this.FamilyNameField;
                }
                set
                {
                    this.FamilyNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string GivenName
            {
                get
                {
                    return this.GivenNameField;
                }
                set
                {
                    this.GivenNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<byte> IdBloodType
            {
                get
                {
                    return this.IdBloodTypeField;
                }
                set
                {
                    this.IdBloodTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdGlobal
            {
                get
                {
                    return this.IdGlobalField;
                }
                set
                {
                    this.IdGlobalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<byte> IdLivingAreaType
            {
                get
                {
                    return this.IdLivingAreaTypeField;
                }
                set
                {
                    this.IdLivingAreaTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdPatientMIS
            {
                get
                {
                    return this.IdPatientMISField;
                }
                set
                {
                    this.IdPatientMISField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool IsVip
            {
                get
                {
                    return this.IsVipField;
                }
                set
                {
                    this.IsVipField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public JobDto Job
            {
                get
                {
                    return this.JobField;
                }
                set
                {
                    this.JobField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MiddleName
            {
                get
                {
                    return this.MiddleNameField;
                }
                set
                {
                    this.MiddleNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public PrivilegeDto Privilege
            {
                get
                {
                    return this.PrivilegeField;
                }
                set
                {
                    this.PrivilegeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte Sex
            {
                get
                {
                    return this.SexField;
                }
                set
                {
                    this.SexField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<byte> SocialGroup
            {
                get
                {
                    return this.SocialGroupField;
                }
                set
                {
                    this.SocialGroupField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string SocialStatus
            {
                get
                {
                    return this.SocialStatusField;
                }
                set
                {
                    this.SocialStatusField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "BirthPlaceDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class BirthPlaceDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string CityField;

            private string CountryField;

            private string RegionField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string City
            {
                get
                {
                    return this.CityField;
                }
                set
                {
                    this.CityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Country
            {
                get
                {
                    return this.CountryField;
                }
                set
                {
                    this.CountryField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Region
            {
                get
                {
                    return this.RegionField;
                }
                set
                {
                    this.RegionField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ContactPersonDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class ContactPersonDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private ContactDto[] ContactListField;

            private string FamilyNameField;

            private string GivenNameField;

            private string IdPersonMisField;

            private byte IdRelationTypeField;

            private string MiddleNameField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public ContactDto[] ContactList
            {
                get
                {
                    return this.ContactListField;
                }
                set
                {
                    this.ContactListField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string FamilyName
            {
                get
                {
                    return this.FamilyNameField;
                }
                set
                {
                    this.FamilyNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string GivenName
            {
                get
                {
                    return this.GivenNameField;
                }
                set
                {
                    this.GivenNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdPersonMis
            {
                get
                {
                    return this.IdPersonMisField;
                }
                set
                {
                    this.IdPersonMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdRelationType
            {
                get
                {
                    return this.IdRelationTypeField;
                }
                set
                {
                    this.IdRelationTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MiddleName
            {
                get
                {
                    return this.MiddleNameField;
                }
                set
                {
                    this.MiddleNameField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "JobDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class JobDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string CompanyNameField;

            private System.Nullable<System.DateTime> DateEndField;

            private System.Nullable<System.DateTime> DateStartField;

            private string OgrnCodeField;

            private string PositionField;

            private string SphereField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string CompanyName
            {
                get
                {
                    return this.CompanyNameField;
                }
                set
                {
                    this.CompanyNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string OgrnCode
            {
                get
                {
                    return this.OgrnCodeField;
                }
                set
                {
                    this.OgrnCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Position
            {
                get
                {
                    return this.PositionField;
                }
                set
                {
                    this.PositionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Sphere
            {
                get
                {
                    return this.SphereField;
                }
                set
                {
                    this.SphereField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PrivilegeDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class PrivilegeDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string CommentField;

            private System.DateTime DateEndField;

            private System.DateTime DateStartField;

            private string DisabilityDegreeField;

            private System.Nullable<byte> IdDisabilityTypeField;

            private byte IdPrivilegeTypeField;

            private bool IsMainField;

            private string MkbCodeField;

            private DocumentDto PrivilegeDocumentField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Comment
            {
                get
                {
                    return this.CommentField;
                }
                set
                {
                    this.CommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DisabilityDegree
            {
                get
                {
                    return this.DisabilityDegreeField;
                }
                set
                {
                    this.DisabilityDegreeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<byte> IdDisabilityType
            {
                get
                {
                    return this.IdDisabilityTypeField;
                }
                set
                {
                    this.IdDisabilityTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdPrivilegeType
            {
                get
                {
                    return this.IdPrivilegeTypeField;
                }
                set
                {
                    this.IdPrivilegeTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool IsMain
            {
                get
                {
                    return this.IsMainField;
                }
                set
                {
                    this.IsMainField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MkbCode
            {
                get
                {
                    return this.MkbCodeField;
                }
                set
                {
                    this.MkbCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public DocumentDto PrivilegeDocument
            {
                get
                {
                    return this.PrivilegeDocumentField;
                }
                set
                {
                    this.PrivilegeDocumentField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AddressDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class AddressDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string AppartmentField;

            private string BuildingField;

            private string CityField;

            private string GeoDataField;

            private byte IdAddressTypeField;

            private System.Nullable<int> PostalCodeField;

            private string StreetField;

            private string StringAddressField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Appartment
            {
                get
                {
                    return this.AppartmentField;
                }
                set
                {
                    this.AppartmentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Building
            {
                get
                {
                    return this.BuildingField;
                }
                set
                {
                    this.BuildingField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string City
            {
                get
                {
                    return this.CityField;
                }
                set
                {
                    this.CityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string GeoData
            {
                get
                {
                    return this.GeoDataField;
                }
                set
                {
                    this.GeoDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdAddressType
            {
                get
                {
                    return this.IdAddressTypeField;
                }
                set
                {
                    this.IdAddressTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<int> PostalCode
            {
                get
                {
                    return this.PostalCodeField;
                }
                set
                {
                    this.PostalCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Street
            {
                get
                {
                    return this.StreetField;
                }
                set
                {
                    this.StreetField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string StringAddress
            {
                get
                {
                    return this.StringAddressField;
                }
                set
                {
                    this.StringAddressField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ContactDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class ContactDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string ContactValueField;

            private byte IdContactTypeField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ContactValue
            {
                get
                {
                    return this.ContactValueField;
                }
                set
                {
                    this.ContactValueField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdContactType
            {
                get
                {
                    return this.IdContactTypeField;
                }
                set
                {
                    this.IdContactTypeField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DocumentDto", Namespace = "http://schemas.datacontract.org/2004/07/EMKService.Data.Dto")]
        public partial class DocumentDto : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string DocNField;

            private string DocSField;

            private string DocumentNameField;

            private System.Nullable<System.DateTime> ExpiredDateField;

            private byte IdDocumentTypeField;

            private string IdProviderField;

            private System.Nullable<System.DateTime> IssuedDateField;

            private string ProviderNameField;

            private string RegionCodeField;

            private System.Nullable<System.DateTime> StartDateField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DocN
            {
                get
                {
                    return this.DocNField;
                }
                set
                {
                    this.DocNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DocS
            {
                get
                {
                    return this.DocSField;
                }
                set
                {
                    this.DocSField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DocumentName
            {
                get
                {
                    return this.DocumentNameField;
                }
                set
                {
                    this.DocumentNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> ExpiredDate
            {
                get
                {
                    return this.ExpiredDateField;
                }
                set
                {
                    this.ExpiredDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdDocumentType
            {
                get
                {
                    return this.IdDocumentTypeField;
                }
                set
                {
                    this.IdDocumentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdProvider
            {
                get
                {
                    return this.IdProviderField;
                }
                set
                {
                    this.IdProviderField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> IssuedDate
            {
                get
                {
                    return this.IssuedDateField;
                }
                set
                {
                    this.IssuedDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ProviderName
            {
                get
                {
                    return this.ProviderNameField;
                }
                set
                {
                    this.ProviderNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string RegionCode
            {
                get
                {
                    return this.RegionCodeField;
                }
                set
                {
                    this.RegionCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> StartDate
            {
                get
                {
                    return this.StartDateField;
                }
                set
                {
                    this.StartDateField = value;
                }
            }
        }
    }
    namespace N3.EMK.Domain.Enums
    {
        using System.Runtime.Serialization;


        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "SourceType", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Domain.Enums")]
        public enum SourceType : int
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Unknown = 0,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Reg = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Fed = 2,
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IPixService")]
    public interface IPixService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceSupport/GetVersion", ReplyAction = "http://tempuri.org/IServiceSupport/GetVersionResponse")]
        N3.Shared.Core.VersionInfo GetVersion();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceSupport/GetVersion", ReplyAction = "http://tempuri.org/IServiceSupport/GetVersionResponse")]
        System.Threading.Tasks.Task<N3.Shared.Core.VersionInfo> GetVersionAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/AddPatient", ReplyAction = "http://tempuri.org/IPixService/AddPatientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IPixService/AddPatientRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IPixService/AddPatientListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void AddPatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/AddPatient", ReplyAction = "http://tempuri.org/IPixService/AddPatientResponse")]
        System.Threading.Tasks.Task AddPatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/UpdatePatient", ReplyAction = "http://tempuri.org/IPixService/UpdatePatientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IPixService/UpdatePatientRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IPixService/UpdatePatientListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void UpdatePatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/UpdatePatient", ReplyAction = "http://tempuri.org/IPixService/UpdatePatientResponse")]
        System.Threading.Tasks.Task UpdatePatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/GetPatient", ReplyAction = "http://tempuri.org/IPixService/GetPatientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IPixService/GetPatientRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IPixService/GetPatientListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        N3.PixService.Dto.PatientDto[] GetPatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient, N3.EMK.Domain.Enums.SourceType idSource);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/GetPatient", ReplyAction = "http://tempuri.org/IPixService/GetPatientResponse")]
        System.Threading.Tasks.Task<N3.PixService.Dto.PatientDto[]> GetPatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient, N3.EMK.Domain.Enums.SourceType idSource);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/GetPatientByGlobalId", ReplyAction = "http://tempuri.org/IPixService/GetPatientByGlobalIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IPixService/GetPatientByGlobalIdRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IPixService/GetPatientByGlobalIdListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        N3.PixService.Dto.PatientDto GetPatientByGlobalId(string guid, string patientId, string idLpu);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IPixService/GetPatientByGlobalId", ReplyAction = "http://tempuri.org/IPixService/GetPatientByGlobalIdResponse")]
        System.Threading.Tasks.Task<N3.PixService.Dto.PatientDto> GetPatientByGlobalIdAsync(string guid, string patientId, string idLpu);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPixServiceChannel : IPixService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PixServiceClient : System.ServiceModel.ClientBase<IPixService>, IPixService, INetrikaServiceClient
    {

        public PixServiceClient()
        {
        }

        public PixServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public PixServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public PixServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public PixServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public N3.Shared.Core.VersionInfo GetVersion()
        {
            return base.Channel.GetVersion();
        }

        public System.Threading.Tasks.Task<N3.Shared.Core.VersionInfo> GetVersionAsync()
        {
            return base.Channel.GetVersionAsync();
        }

        public void AddPatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient)
        {
            base.Channel.AddPatient(guid, idLPU, patient);
        }

        public System.Threading.Tasks.Task AddPatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient)
        {
            return base.Channel.AddPatientAsync(guid, idLPU, patient);
        }

        public void UpdatePatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient)
        {
            base.Channel.UpdatePatient(guid, idLPU, patient);
        }

        public System.Threading.Tasks.Task UpdatePatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient)
        {
            return base.Channel.UpdatePatientAsync(guid, idLPU, patient);
        }

        public N3.PixService.Dto.PatientDto[] GetPatient(string guid, string idLPU, N3.PixService.Dto.PatientDto patient, N3.EMK.Domain.Enums.SourceType idSource)
        {
            return base.Channel.GetPatient(guid, idLPU, patient, idSource);
        }

        public System.Threading.Tasks.Task<N3.PixService.Dto.PatientDto[]> GetPatientAsync(string guid, string idLPU, N3.PixService.Dto.PatientDto patient, N3.EMK.Domain.Enums.SourceType idSource)
        {
            return base.Channel.GetPatientAsync(guid, idLPU, patient, idSource);
        }

        public N3.PixService.Dto.PatientDto GetPatientByGlobalId(string guid, string patientId, string idLpu)
        {
            return base.Channel.GetPatientByGlobalId(guid, patientId, idLpu);
        }

        public System.Threading.Tasks.Task<N3.PixService.Dto.PatientDto> GetPatientByGlobalIdAsync(string guid, string patientId, string idLpu)
        {
            return base.Channel.GetPatientByGlobalIdAsync(guid, patientId, idLpu);
        }
    }
}
