namespace HubService2.ContractsClasses.HomeCall
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeInterval", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class TimeInterval : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime EndField;
        
        private System.DateTime StartField;
        
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
        public System.DateTime End
        {
            get
            {
                return this.EndField;
            }
            set
            {
                this.EndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start
        {
            get
            {
                return this.StartField;
            }
            set
            {
                this.StartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime BirthDateField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private string OMSNumberField;
        
        private string OMSSeriesField;
        
        private string SexField;
        
        private string SnilsField;
        
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
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
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
        public string OMSNumber
        {
            get
            {
                return this.OMSNumberField;
            }
            set
            {
                this.OMSNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OMSSeries
        {
            get
            {
                return this.OMSSeriesField;
            }
            set
            {
                this.OMSSeriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex
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
        public string Snils
        {
            get
            {
                return this.SnilsField;
            }
            set
            {
                this.SnilsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Applicant", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Applicant : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private string MobilePhoneField;
        
        private string SNILSField;
        
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
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
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
        public string MobilePhone
        {
            get
            {
                return this.MobilePhoneField;
            }
            set
            {
                this.MobilePhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SNILS
        {
            get
            {
                return this.SNILSField;
            }
            set
            {
                this.SNILSField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AdditionalAreaField;
        
        private string AdditionalStreetField;
        
        private string AddressLineField;
        
        private string ApartmentField;
        
        private string AreaField;
        
        private string CityField;
        
        private string CityAreaField;
        
        private string CodKladrFiasField;
        
        private string CommentField;
        
        private string HouseField;
        
        private string HousingField;
        
        private string PlaceField;
        
        private string PostIndexField;
        
        private string RegionField;
        
        private string StreetField;
        
        private string StructureField;
        
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
        public string AdditionalArea
        {
            get
            {
                return this.AdditionalAreaField;
            }
            set
            {
                this.AdditionalAreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdditionalStreet
        {
            get
            {
                return this.AdditionalStreetField;
            }
            set
            {
                this.AdditionalStreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressLine
        {
            get
            {
                return this.AddressLineField;
            }
            set
            {
                this.AddressLineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apartment
        {
            get
            {
                return this.ApartmentField;
            }
            set
            {
                this.ApartmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Area
        {
            get
            {
                return this.AreaField;
            }
            set
            {
                this.AreaField = value;
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
        public string CityArea
        {
            get
            {
                return this.CityAreaField;
            }
            set
            {
                this.CityAreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodKladrFias
        {
            get
            {
                return this.CodKladrFiasField;
            }
            set
            {
                this.CodKladrFiasField = value;
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
        public string House
        {
            get
            {
                return this.HouseField;
            }
            set
            {
                this.HouseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Housing
        {
            get
            {
                return this.HousingField;
            }
            set
            {
                this.HousingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostIndex
        {
            get
            {
                return this.PostIndexField;
            }
            set
            {
                this.PostIndexField = value;
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
        public string Structure
        {
            get
            {
                return this.StructureField;
            }
            set
            {
                this.StructureField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateHomeCallRequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class UpdateHomeCallRequestResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateHomeCallRequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class CreateHomeCallRequestResult : HubService2.MethodResult
    {
        
        private string IdHomeCallRequestField;
        
        private string IdSessionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHomeCallRequest
        {
            get
            {
                return this.IdHomeCallRequestField;
            }
            set
            {
                this.IdHomeCallRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSession
        {
            get
            {
                return this.IdSessionField;
            }
            set
            {
                this.IdSessionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchHomeCallRequestsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class SearchHomeCallRequestsResult : HubService2.MethodResult
    {
        
        private int CountField;
        
        private HubService2.ContractsClasses.HomeCall.HomeCallRequest[] ListHomeCallRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count
        {
            get
            {
                return this.CountField;
            }
            set
            {
                this.CountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.HomeCall.HomeCallRequest[] ListHomeCallRequest
        {
            get
            {
                return this.ListHomeCallRequestField;
            }
            set
            {
                this.ListHomeCallRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetHomeCallAvailableSlotsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class GetHomeCallAvailableSlotsResult : HubService2.MethodResult
    {
        
        private string IdSessionField;
        
        private HubService2.Slot[] ListSlotField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSession
        {
            get
            {
                return this.IdSessionField;
            }
            set
            {
                this.IdSessionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Slot[] ListSlot
        {
            get
            {
                return this.ListSlotField;
            }
            set
            {
                this.ListSlotField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HandleHomeCallRequestChangedResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class HandleHomeCallRequestChangedResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidateHomeCallResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class ValidateHomeCallResult : HubService2.MethodResult
    {
        
        private HubService2.HomeCallDoctorWithSlots HomeCallDoctorField;
        
        private string IdDoctorPositionField;
        
        private string IdPatField;
        
        private string IdSessionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.HomeCallDoctorWithSlots HomeCallDoctor
        {
            get
            {
                return this.HomeCallDoctorField;
            }
            set
            {
                this.HomeCallDoctorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDoctorPosition
        {
            get
            {
                return this.IdDoctorPositionField;
            }
            set
            {
                this.IdDoctorPositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPat
        {
            get
            {
                return this.IdPatField;
            }
            set
            {
                this.IdPatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSession
        {
            get
            {
                return this.IdSessionField;
            }
            set
            {
                this.IdSessionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HomeCallRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class HomeCallRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.ContractsClasses.HomeCall.Address AddressField;
        
        private HubService2.ContractsClasses.HomeCall.Applicant ApplicantField;
        
        private string CommentField;
        
        private System.DateTime CreatedDateField;
        
        private HubService2.HomeCallDoctor HomeCallDoctorField;
        
        private HubService2.ContractsClasses.HomeCall.Patient HomeCallPatientField;
        
        private int HomeCallStatusField;
        
        private string IdDoctorPositionField;
        
        private string IdHomeCallRequestField;
        
        private int IdLpuField;
        
        private System.Nullable<System.Guid> IdNsiLpuField;
        
        private string IdPatField;
        
        private string IdSessionField;
        
        private string MemberGuidField;
        
        private string ReasonField;
        
        private HubService2.Slot SlotField;
        
        private System.DateTime UpdatedDateField;
        
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
        public HubService2.ContractsClasses.HomeCall.Address Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.HomeCall.Applicant Applicant
        {
            get
            {
                return this.ApplicantField;
            }
            set
            {
                this.ApplicantField = value;
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
        public System.DateTime CreatedDate
        {
            get
            {
                return this.CreatedDateField;
            }
            set
            {
                this.CreatedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.HomeCallDoctor HomeCallDoctor
        {
            get
            {
                return this.HomeCallDoctorField;
            }
            set
            {
                this.HomeCallDoctorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.HomeCall.Patient HomeCallPatient
        {
            get
            {
                return this.HomeCallPatientField;
            }
            set
            {
                this.HomeCallPatientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HomeCallStatus
        {
            get
            {
                return this.HomeCallStatusField;
            }
            set
            {
                this.HomeCallStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDoctorPosition
        {
            get
            {
                return this.IdDoctorPositionField;
            }
            set
            {
                this.IdDoctorPositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHomeCallRequest
        {
            get
            {
                return this.IdHomeCallRequestField;
            }
            set
            {
                this.IdHomeCallRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdLpu
        {
            get
            {
                return this.IdLpuField;
            }
            set
            {
                this.IdLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> IdNsiLpu
        {
            get
            {
                return this.IdNsiLpuField;
            }
            set
            {
                this.IdNsiLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPat
        {
            get
            {
                return this.IdPatField;
            }
            set
            {
                this.IdPatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSession
        {
            get
            {
                return this.IdSessionField;
            }
            set
            {
                this.IdSessionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MemberGuid
        {
            get
            {
                return this.MemberGuidField;
            }
            set
            {
                this.MemberGuidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason
        {
            get
            {
                return this.ReasonField;
            }
            set
            {
                this.ReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Slot Slot
        {
            get
            {
                return this.SlotField;
            }
            set
            {
                this.SlotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdatedDate
        {
            get
            {
                return this.UpdatedDateField;
            }
            set
            {
                this.UpdatedDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchHomeCallRequestFilter", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class SearchHomeCallRequestFilter : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.ContractsClasses.HomeCall.TimeInterval CreatedDateRangeField;
        
        private int[] HomeCallStatusesField;
        
        private string IdDocField;
        
        private string IdHomeCallRequestField;
        
        private System.Nullable<int> IdLpuField;
        
        private HubService2.ContractsClasses.HomeCall.FilterLpuPatient[] IdLpuAndIdPatientsField;
        
        private System.Nullable<System.Guid> IdNsiLpuField;
        
        private string[] IdPatientsField;
        
        private HubService2.ContractsClasses.HomeCall.TimeInterval UpdatedDateRangeField;
        
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
        public HubService2.ContractsClasses.HomeCall.TimeInterval CreatedDateRange
        {
            get
            {
                return this.CreatedDateRangeField;
            }
            set
            {
                this.CreatedDateRangeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] HomeCallStatuses
        {
            get
            {
                return this.HomeCallStatusesField;
            }
            set
            {
                this.HomeCallStatusesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDoc
        {
            get
            {
                return this.IdDocField;
            }
            set
            {
                this.IdDocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdHomeCallRequest
        {
            get
            {
                return this.IdHomeCallRequestField;
            }
            set
            {
                this.IdHomeCallRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdLpu
        {
            get
            {
                return this.IdLpuField;
            }
            set
            {
                this.IdLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.HomeCall.FilterLpuPatient[] IdLpuAndIdPatients
        {
            get
            {
                return this.IdLpuAndIdPatientsField;
            }
            set
            {
                this.IdLpuAndIdPatientsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> IdNsiLpu
        {
            get
            {
                return this.IdNsiLpuField;
            }
            set
            {
                this.IdNsiLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] IdPatients
        {
            get
            {
                return this.IdPatientsField;
            }
            set
            {
                this.IdPatientsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.HomeCall.TimeInterval UpdatedDateRange
        {
            get
            {
                return this.UpdatedDateRangeField;
            }
            set
            {
                this.UpdatedDateRangeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterLpuPatient", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class FilterLpuPatient : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdLpuField;
        
        private string IdPatientField;
        
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
        public int IdLpu
        {
            get
            {
                return this.IdLpuField;
            }
            set
            {
                this.IdLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPatient
        {
            get
            {
                return this.IdPatientField;
            }
            set
            {
                this.IdPatientField = value;
            }
        }
    }
}
namespace HubService2
{
    using System.Runtime.Serialization;
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HomeCallDoctorWithSlots", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class HomeCallDoctorWithSlots : HubService2.HomeCallDoctor
    {
        
        private HubService2.Slot[] ListSlotField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Slot[] ListSlot
        {
            get
            {
                return this.ListSlotField;
            }
            set
            {
                this.ListSlotField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HomeCallDoctor", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.HomeCallDoctorWithSlots))]
    public partial class HomeCallDoctor : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AreaField;
        
        private string AreaTypeField;
        
        private string CommentField;
        
        private System.Nullable<int> CountFreeParticipantIEField;
        
        private System.Nullable<int> CountFreeTicketField;
        
        private string IdDocField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string NameField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
        private string SnilsField;
        
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
        public string Area
        {
            get
            {
                return this.AreaField;
            }
            set
            {
                this.AreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaType
        {
            get
            {
                return this.AreaTypeField;
            }
            set
            {
                this.AreaTypeField = value;
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
        public System.Nullable<int> CountFreeParticipantIE
        {
            get
            {
                return this.CountFreeParticipantIEField;
            }
            set
            {
                this.CountFreeParticipantIEField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CountFreeTicket
        {
            get
            {
                return this.CountFreeTicketField;
            }
            set
            {
                this.CountFreeTicketField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDoc
        {
            get
            {
                return this.IdDocField;
            }
            set
            {
                this.IdDocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastDate
        {
            get
            {
                return this.LastDateField;
            }
            set
            {
                this.LastDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NearestDate
        {
            get
            {
                return this.NearestDateField;
            }
            set
            {
                this.NearestDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Snils
        {
            get
            {
                return this.SnilsField;
            }
            set
            {
                this.SnilsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Slot", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Slot : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int DurationField;
        
        private string IdSlotField;
        
        private System.DateTime VisitTimeField;
        
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
        public int Duration
        {
            get
            {
                return this.DurationField;
            }
            set
            {
                this.DurationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSlot
        {
            get
            {
                return this.IdSlotField;
            }
            set
            {
                this.IdSlotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitTime
        {
            get
            {
                return this.VisitTimeField;
            }
            set
            {
                this.VisitTimeField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHomeCallService")]
public interface IHomeCallService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/ValidateHomeCall", ReplyAction="http://tempuri.org/IHomeCallService/ValidateHomeCallResponse")]
    HubService2.ContractsClasses.HomeCall.ValidateHomeCallResult ValidateHomeCall(int idLpu, string reason, string comment, string idSession, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals, HubService2.ContractsClasses.HomeCall.Patient homeCallPatient, HubService2.ContractsClasses.HomeCall.Applicant applicant, HubService2.ContractsClasses.HomeCall.Address address);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/ValidateHomeCall", ReplyAction="http://tempuri.org/IHomeCallService/ValidateHomeCallResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.ValidateHomeCallResult> ValidateHomeCallAsync(int idLpu, string reason, string comment, string idSession, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals, HubService2.ContractsClasses.HomeCall.Patient homeCallPatient, HubService2.ContractsClasses.HomeCall.Applicant applicant, HubService2.ContractsClasses.HomeCall.Address address);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/UpdateHomeCallRequest", ReplyAction="http://tempuri.org/IHomeCallService/UpdateHomeCallRequestResponse")]
    HubService2.ContractsClasses.HomeCall.UpdateHomeCallRequestResult UpdateHomeCallRequest(string idHomeCallRequest, int homeCallStatus, string comment, string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/UpdateHomeCallRequest", ReplyAction="http://tempuri.org/IHomeCallService/UpdateHomeCallRequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.UpdateHomeCallRequestResult> UpdateHomeCallRequestAsync(string idHomeCallRequest, int homeCallStatus, string comment, string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/CreateHomeCallRequest", ReplyAction="http://tempuri.org/IHomeCallService/CreateHomeCallRequestResponse")]
    HubService2.ContractsClasses.HomeCall.CreateHomeCallRequestResult CreateHomeCallRequest(string idSession, int idLpu, string idSlot, string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/CreateHomeCallRequest", ReplyAction="http://tempuri.org/IHomeCallService/CreateHomeCallRequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.CreateHomeCallRequestResult> CreateHomeCallRequestAsync(string idSession, int idLpu, string idSlot, string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/SearchHomeCallRequests", ReplyAction="http://tempuri.org/IHomeCallService/SearchHomeCallRequestsResponse")]
    HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestsResult SearchHomeCallRequests(string guid, HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestFilter filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/SearchHomeCallRequests", ReplyAction="http://tempuri.org/IHomeCallService/SearchHomeCallRequestsResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestsResult> SearchHomeCallRequestsAsync(string guid, HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestFilter filter);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlots", ReplyAction="http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlotsResponse")]
    HubService2.ContractsClasses.HomeCall.GetHomeCallAvailableSlotsResult GetHomeCallAvailableSlots(string idSession, int idLpu, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlots", ReplyAction="http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlotsResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.GetHomeCallAvailableSlotsResult> GetHomeCallAvailableSlotsAsync(string idSession, int idLpu, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/HandleHomeCallRequestChanged", ReplyAction="http://tempuri.org/IHomeCallService/HandleHomeCallRequestChangedResponse")]
    HubService2.ContractsClasses.HomeCall.HandleHomeCallRequestChangedResult HandleHomeCallRequestChanged(System.Guid guid, HubService2.ContractsClasses.HomeCall.HomeCallRequest homeCallRequest);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHomeCallService/HandleHomeCallRequestChanged", ReplyAction="http://tempuri.org/IHomeCallService/HandleHomeCallRequestChangedResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.HandleHomeCallRequestChangedResult> HandleHomeCallRequestChangedAsync(System.Guid guid, HubService2.ContractsClasses.HomeCall.HomeCallRequest homeCallRequest);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHomeCallServiceChannel : IHomeCallService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HomeCallServiceClient : System.ServiceModel.ClientBase<IHomeCallService>, IHomeCallService
{
    
    public HomeCallServiceClient()
    {
    }
    
    public HomeCallServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HomeCallServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HomeCallServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HomeCallServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public HubService2.ContractsClasses.HomeCall.ValidateHomeCallResult ValidateHomeCall(int idLpu, string reason, string comment, string idSession, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals, HubService2.ContractsClasses.HomeCall.Patient homeCallPatient, HubService2.ContractsClasses.HomeCall.Applicant applicant, HubService2.ContractsClasses.HomeCall.Address address)
    {
        return base.Channel.ValidateHomeCall(idLpu, reason, comment, idSession, guid, timeIntervals, homeCallPatient, applicant, address);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.ValidateHomeCallResult> ValidateHomeCallAsync(int idLpu, string reason, string comment, string idSession, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals, HubService2.ContractsClasses.HomeCall.Patient homeCallPatient, HubService2.ContractsClasses.HomeCall.Applicant applicant, HubService2.ContractsClasses.HomeCall.Address address)
    {
        return base.Channel.ValidateHomeCallAsync(idLpu, reason, comment, idSession, guid, timeIntervals, homeCallPatient, applicant, address);
    }
    
    public HubService2.ContractsClasses.HomeCall.UpdateHomeCallRequestResult UpdateHomeCallRequest(string idHomeCallRequest, int homeCallStatus, string comment, string guid)
    {
        return base.Channel.UpdateHomeCallRequest(idHomeCallRequest, homeCallStatus, comment, guid);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.UpdateHomeCallRequestResult> UpdateHomeCallRequestAsync(string idHomeCallRequest, int homeCallStatus, string comment, string guid)
    {
        return base.Channel.UpdateHomeCallRequestAsync(idHomeCallRequest, homeCallStatus, comment, guid);
    }
    
    public HubService2.ContractsClasses.HomeCall.CreateHomeCallRequestResult CreateHomeCallRequest(string idSession, int idLpu, string idSlot, string guid)
    {
        return base.Channel.CreateHomeCallRequest(idSession, idLpu, idSlot, guid);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.CreateHomeCallRequestResult> CreateHomeCallRequestAsync(string idSession, int idLpu, string idSlot, string guid)
    {
        return base.Channel.CreateHomeCallRequestAsync(idSession, idLpu, idSlot, guid);
    }
    
    public HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestsResult SearchHomeCallRequests(string guid, HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestFilter filter)
    {
        return base.Channel.SearchHomeCallRequests(guid, filter);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestsResult> SearchHomeCallRequestsAsync(string guid, HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestFilter filter)
    {
        return base.Channel.SearchHomeCallRequestsAsync(guid, filter);
    }
    
    public HubService2.ContractsClasses.HomeCall.GetHomeCallAvailableSlotsResult GetHomeCallAvailableSlots(string idSession, int idLpu, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals)
    {
        return base.Channel.GetHomeCallAvailableSlots(idSession, idLpu, guid, timeIntervals);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.GetHomeCallAvailableSlotsResult> GetHomeCallAvailableSlotsAsync(string idSession, int idLpu, string guid, HubService2.ContractsClasses.HomeCall.TimeInterval[] timeIntervals)
    {
        return base.Channel.GetHomeCallAvailableSlotsAsync(idSession, idLpu, guid, timeIntervals);
    }
    
    public HubService2.ContractsClasses.HomeCall.HandleHomeCallRequestChangedResult HandleHomeCallRequestChanged(System.Guid guid, HubService2.ContractsClasses.HomeCall.HomeCallRequest homeCallRequest)
    {
        return base.Channel.HandleHomeCallRequestChanged(guid, homeCallRequest);
    }
    
    public System.Threading.Tasks.Task<HubService2.ContractsClasses.HomeCall.HandleHomeCallRequestChangedResult> HandleHomeCallRequestChangedAsync(System.Guid guid, HubService2.ContractsClasses.HomeCall.HomeCallRequest homeCallRequest)
    {
        return base.Channel.HandleHomeCallRequestChangedAsync(guid, homeCallRequest);
    }
}
