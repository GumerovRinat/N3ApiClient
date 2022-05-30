namespace HubService2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AriaNumberField;
        
        private System.Nullable<System.DateTime> BirthdayField;
        
        private string CellPhoneField;
        
        private string Document_NField;
        
        private string Document_SField;
        
        private string HomePhoneField;
        
        private string IdPatField;
        
        private string NameField;
        
        private string Polis_NField;
        
        private string Polis_SField;
        
        private string SecondNameField;
        
        private string SnilsField;
        
        private string SurnameField;
        
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
        public string AriaNumber
        {
            get
            {
                return this.AriaNumberField;
            }
            set
            {
                this.AriaNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Birthday
        {
            get
            {
                return this.BirthdayField;
            }
            set
            {
                this.BirthdayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CellPhone
        {
            get
            {
                return this.CellPhoneField;
            }
            set
            {
                this.CellPhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document_N
        {
            get
            {
                return this.Document_NField;
            }
            set
            {
                this.Document_NField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document_S
        {
            get
            {
                return this.Document_SField;
            }
            set
            {
                this.Document_SField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhone
        {
            get
            {
                return this.HomePhoneField;
            }
            set
            {
                this.HomePhoneField = value;
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
        public string Polis_N
        {
            get
            {
                return this.Polis_NField;
            }
            set
            {
                this.Polis_NField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Polis_S
        {
            get
            {
                return this.Polis_SField;
            }
            set
            {
                this.Polis_SField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName
        {
            get
            {
                return this.SecondNameField;
            }
            set
            {
                this.SecondNameField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname
        {
            get
            {
                return this.SurnameField;
            }
            set
            {
                this.SurnameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MethodResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SetAppointmentByPARequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.RegisterPARequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.CancelPARequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.CheckReferralResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.SearchTop10PatientResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.AddNewPatientResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetDocListFullTreeResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.InspectDoctorsReferalResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.InspectDoctorsReferral2Result))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetAvaibleAppointmentsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.SetAppointmentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetAvailableDatesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetDoctorListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetDoctorList2Result))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetAvailableDoctorsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetLPUListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetOrgListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetSpesialityListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetPositionListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.LpuListToRfiszResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.DistrictResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetWorkingTimeResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetFullInfoByIdResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.CreateClaimForRefusalResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetPatientHistoryResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.UpdatePhoneByIdPatResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetHubUserByGuidResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetErrorListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.SetWaitingListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetStatusAnalysisResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.SendNotificationAboutAppointmentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.SendNotificationAboutAppointmentStatusResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetTodayAppointmentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.LpuInformationResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetPatientsAreasResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.CheckInResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.GetVersionResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.PatientNotificationResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.AvailableAppointmentsInfoResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.CheckPatientResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.UpdateHomeCallRequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.CreateHomeCallRequestResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.SearchHomeCallRequestsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.GetHomeCallAvailableSlotsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.HandleHomeCallRequestChangedResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.HomeCall.ValidateHomeCallResult))]
    public partial class MethodResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Error[] ErrorListField;
        
        private System.Nullable<int> IdHistoryField;
        
        private bool SuccessField;
        
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
        public HubService2.Error[] ErrorList
        {
            get
            {
                return this.ErrorListField;
            }
            set
            {
                this.ErrorListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdHistory
        {
            get
            {
                return this.IdHistoryField;
            }
            set
            {
                this.IdHistoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                this.SuccessField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckReferralResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class CheckReferralResult : HubService2.MethodResult
    {
        
        private HubService2.Dto.Referral ReferralField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Referral Referral
        {
            get
            {
                return this.ReferralField;
            }
            set
            {
                this.ReferralField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchTop10PatientResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SearchTop10PatientResult : HubService2.MethodResult
    {
        
        private HubService2.Patient[] ListPatientField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Patient[] ListPatient
        {
            get
            {
                return this.ListPatientField;
            }
            set
            {
                this.ListPatientField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddNewPatientResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class AddNewPatientResult : HubService2.MethodResult
    {
        
        private string IdPatField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDocListFullTreeResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetDocListFullTreeResult : HubService2.MethodResult
    {
        
        private HubService2.Essence[] ListDoctorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Essence[] ListDoctor
        {
            get
            {
                return this.ListDoctorField;
            }
            set
            {
                this.ListDoctorField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InspectDoctorsReferalResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class InspectDoctorsReferalResult : HubService2.MethodResult
    {
        
        private string IdDocField;
        
        private int IdLpuField;
        
        private string Id_PatientField;
        
        private HubService2.AppointmentType TypeField;
        
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
        public string Id_Patient
        {
            get
            {
                return this.Id_PatientField;
            }
            set
            {
                this.Id_PatientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.AppointmentType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InspectDoctorsReferral2Result", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class InspectDoctorsReferral2Result : HubService2.MethodResult
    {
        
        private int IdLpuField;
        
        private string IdPatField;
        
        private HubService2.Speciality2[] ListSpecialityField;
        
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
        public HubService2.Speciality2[] ListSpeciality
        {
            get
            {
                return this.ListSpecialityField;
            }
            set
            {
                this.ListSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAvaibleAppointmentsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetAvaibleAppointmentsResult : HubService2.MethodResult
    {
        
        private HubService2.Appointment[] ListAppointmentsField;
        
        private HubService2.ContractsClasses.ProxyAndReturn.MedicalOrganization MedicalOrganizationField;
        
        private HubService2.ContractsClasses.ProxyAndReturn.MedicalResource MedicalResourceField;
        
        private HubService2.ContractsClasses.ProxyAndReturn.NextAvailableDate NextAvailableDateField;
        
        private string NotAvailableReasonCodeField;
        
        private HubService2.ContractsClasses.ProxyAndReturn.VisitInfo VisitInfoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Appointment[] ListAppointments
        {
            get
            {
                return this.ListAppointmentsField;
            }
            set
            {
                this.ListAppointmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.ProxyAndReturn.MedicalOrganization MedicalOrganization
        {
            get
            {
                return this.MedicalOrganizationField;
            }
            set
            {
                this.MedicalOrganizationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.ProxyAndReturn.MedicalResource MedicalResource
        {
            get
            {
                return this.MedicalResourceField;
            }
            set
            {
                this.MedicalResourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.ProxyAndReturn.NextAvailableDate NextAvailableDate
        {
            get
            {
                return this.NextAvailableDateField;
            }
            set
            {
                this.NextAvailableDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NotAvailableReasonCode
        {
            get
            {
                return this.NotAvailableReasonCodeField;
            }
            set
            {
                this.NotAvailableReasonCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.ProxyAndReturn.VisitInfo VisitInfo
        {
            get
            {
                return this.VisitInfoField;
            }
            set
            {
                this.VisitInfoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetAppointmentResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SetAppointmentResult : HubService2.MethodResult
    {
        
        private HubService2.SpecialistType TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.SpecialistType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAvailableDatesResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetAvailableDatesResult : HubService2.MethodResult
    {
        
        private System.DateTime[] AvailableDateListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime[] AvailableDateList
        {
            get
            {
                return this.AvailableDateListField;
            }
            set
            {
                this.AvailableDateListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDoctorListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetDoctorListResult : HubService2.MethodResult
    {
        
        private HubService2.Doctor[] DocsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor[] Docs
        {
            get
            {
                return this.DocsField;
            }
            set
            {
                this.DocsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDoctorList2Result", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetDoctorList2Result : HubService2.MethodResult
    {
        
        private HubService2.Doctor4[] DocsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor4[] Docs
        {
            get
            {
                return this.DocsField;
            }
            set
            {
                this.DocsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAvailableDoctorsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetAvailableDoctorsResult : HubService2.MethodResult
    {
        
        private string CommentField;
        
        private HubService2.Speciality3[] ListSpecialityField;
        
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
        public HubService2.Speciality3[] ListSpeciality
        {
            get
            {
                return this.ListSpecialityField;
            }
            set
            {
                this.ListSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetLPUListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetLPUListResult : HubService2.MethodResult
    {
        
        private HubService2.Clinic[] ListLPUField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Clinic[] ListLPU
        {
            get
            {
                return this.ListLPUField;
            }
            set
            {
                this.ListLPUField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetOrgListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetOrgListResult : HubService2.MethodResult
    {
        
        private HubService2.OrgList[] OrgListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.OrgList[] OrgList
        {
            get
            {
                return this.OrgListField;
            }
            set
            {
                this.OrgListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetSpesialityListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetSpesialityListResult : HubService2.MethodResult
    {
        
        private HubService2.Spesiality[] ListSpesialityField;
        
        private string LpuChangesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Spesiality[] ListSpesiality
        {
            get
            {
                return this.ListSpesialityField;
            }
            set
            {
                this.ListSpesialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LpuChanges
        {
            get
            {
                return this.LpuChangesField;
            }
            set
            {
                this.LpuChangesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetPositionListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetPositionListResult : HubService2.MethodResult
    {
        
        private string CommentField;
        
        private HubService2.Position[] ListPositionField;
        
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
        public HubService2.Position[] ListPosition
        {
            get
            {
                return this.ListPositionField;
            }
            set
            {
                this.ListPositionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LpuListToRfiszResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class LpuListToRfiszResult : HubService2.MethodResult
    {
        
        private HubService2.LpuListToRFISZ[] LpuListToRfiszsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.LpuListToRFISZ[] LpuListToRfiszs
        {
            get
            {
                return this.LpuListToRfiszsField;
            }
            set
            {
                this.LpuListToRfiszsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DistrictResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class DistrictResult : HubService2.MethodResult
    {
        
        private HubService2.District[] DistrictsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.District[] Districts
        {
            get
            {
                return this.DistrictsField;
            }
            set
            {
                this.DistrictsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetWorkingTimeResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetWorkingTimeResult : HubService2.MethodResult
    {
        
        private HubService2.WorkingTime[] WorkingTimeListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.WorkingTime[] WorkingTimeList
        {
            get
            {
                return this.WorkingTimeListField;
            }
            set
            {
                this.WorkingTimeListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetFullInfoByIdResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetFullInfoByIdResult : HubService2.MethodResult
    {
        
        private HubService2.Doctor DocField;
        
        private HubService2.Spesiality DoctorsSpesialityField;
        
        private HubService2.Clinic LPUField;
        
        private HubService2.Patient PatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor Doc
        {
            get
            {
                return this.DocField;
            }
            set
            {
                this.DocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Spesiality DoctorsSpesiality
        {
            get
            {
                return this.DoctorsSpesialityField;
            }
            set
            {
                this.DoctorsSpesialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Clinic LPU
        {
            get
            {
                return this.LPUField;
            }
            set
            {
                this.LPUField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Patient Pat
        {
            get
            {
                return this.PatField;
            }
            set
            {
                this.PatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateClaimForRefusalResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class CreateClaimForRefusalResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetPatientHistoryResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetPatientHistoryResult : HubService2.MethodResult
    {
        
        private HubService2.HistoryRefusal[] ListHistoryRefusalField;
        
        private HubService2.HistoryVisit[] ListHistoryVisitField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.HistoryRefusal[] ListHistoryRefusal
        {
            get
            {
                return this.ListHistoryRefusalField;
            }
            set
            {
                this.ListHistoryRefusalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.HistoryVisit[] ListHistoryVisit
        {
            get
            {
                return this.ListHistoryVisitField;
            }
            set
            {
                this.ListHistoryVisitField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdatePhoneByIdPatResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class UpdatePhoneByIdPatResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetHubUserByGuidResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetHubUserByGuidResult : HubService2.MethodResult
    {
        
        private HubService2.HubUser[] HubUserListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.HubUser[] HubUserList
        {
            get
            {
                return this.HubUserListField;
            }
            set
            {
                this.HubUserListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetErrorListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetErrorListResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetWaitingListResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SetWaitingListResult : HubService2.MethodResult
    {
        
        private System.Nullable<System.Guid> GuidClaimField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> GuidClaim
        {
            get
            {
                return this.GuidClaimField;
            }
            set
            {
                this.GuidClaimField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetStatusAnalysisResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetStatusAnalysisResult : HubService2.MethodResult
    {
        
        private System.Nullable<System.Collections.Generic.KeyValuePair<int, string>> StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Collections.Generic.KeyValuePair<int, string>> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendNotificationAboutAppointmentResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SendNotificationAboutAppointmentResult : HubService2.MethodResult
    {
        
        private System.Nullable<long> IdNotificationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> IdNotification
        {
            get
            {
                return this.IdNotificationField;
            }
            set
            {
                this.IdNotificationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendNotificationAboutAppointmentStatusResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SendNotificationAboutAppointmentStatusResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTodayAppointmentResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetTodayAppointmentResult : HubService2.MethodResult
    {
        
        private HubService2.SchedulerOfDoctor[] SchedulerOfDoctorListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.SchedulerOfDoctor[] SchedulerOfDoctorList
        {
            get
            {
                return this.SchedulerOfDoctorListField;
            }
            set
            {
                this.SchedulerOfDoctorListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LpuInformationResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class LpuInformationResult : HubService2.MethodResult
    {
        
        private HubService2.LpuInfo[] LpuCollectionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.LpuInfo[] LpuCollection
        {
            get
            {
                return this.LpuCollectionField;
            }
            set
            {
                this.LpuCollectionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetPatientsAreasResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetPatientsAreasResult : HubService2.MethodResult
    {
        
        private HubService2.PatientsArea[] PatientsAreaListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.PatientsArea[] PatientsAreaList
        {
            get
            {
                return this.PatientsAreaListField;
            }
            set
            {
                this.PatientsAreaListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckInResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class CheckInResult : HubService2.MethodResult
    {
        
        private int CountField;
        
        private string OfficeField;
        
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
        public string Office
        {
            get
            {
                return this.OfficeField;
            }
            set
            {
                this.OfficeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVersionResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class GetVersionResult : HubService2.MethodResult
    {
        
        private string DatabaseVersionField;
        
        private string ServiceVersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DatabaseVersion
        {
            get
            {
                return this.DatabaseVersionField;
            }
            set
            {
                this.DatabaseVersionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceVersion
        {
            get
            {
                return this.ServiceVersionField;
            }
            set
            {
                this.ServiceVersionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientNotificationResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class PatientNotificationResult : HubService2.MethodResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AvailableAppointmentsInfoResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class AvailableAppointmentsInfoResult : HubService2.MethodResult
    {
        
        private int IdLpuField;
        
        private string IdPatField;
        
        private HubService2.Speciality2[] ListSpecialityField;
        
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
        public HubService2.Speciality2[] ListSpeciality
        {
            get
            {
                return this.ListSpecialityField;
            }
            set
            {
                this.ListSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckPatientResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class CheckPatientResult : HubService2.MethodResult
    {
        
        private string IdPatField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ErrorDescriptionField;
        
        private int IdErrorField;
        
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
        public string ErrorDescription
        {
            get
            {
                return this.ErrorDescriptionField;
            }
            set
            {
                this.ErrorDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdError
        {
            get
            {
                return this.IdErrorField;
            }
            set
            {
                this.IdErrorField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Speciality2", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Speciality2 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private string FerIdSpecialityField;
        
        private string IdSpecialityField;
        
        private HubService2.Doctor2[] ListDoctorField;
        
        private string NameSpecialityField;
        
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FerIdSpeciality
        {
            get
            {
                return this.FerIdSpecialityField;
            }
            set
            {
                this.FerIdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSpeciality
        {
            get
            {
                return this.IdSpecialityField;
            }
            set
            {
                this.IdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor2[] ListDoctor
        {
            get
            {
                return this.ListDoctorField;
            }
            set
            {
                this.ListDoctorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameSpeciality
        {
            get
            {
                return this.NameSpecialityField;
            }
            set
            {
                this.NameSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor2", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Doctor2 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private string IdDocField;
        
        private HubService2.Appointment[] ListAppointmentField;
        
        private string NameField;
        
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
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
        public HubService2.Appointment[] ListAppointment
        {
            get
            {
                return this.ListAppointmentField;
            }
            set
            {
                this.ListAppointmentField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Appointment", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.NoticeAppointment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.StatusAppointment))]
    public partial class Appointment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string IdAppointmentField;
        
        private System.Nullable<int> NumField;
        
        private string RoomField;
        
        private System.DateTime VisitEndField;
        
        private System.DateTime VisitStartField;
        
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
        public string Address
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
        public string IdAppointment
        {
            get
            {
                return this.IdAppointmentField;
            }
            set
            {
                this.IdAppointmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Num
        {
            get
            {
                return this.NumField;
            }
            set
            {
                this.NumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Room
        {
            get
            {
                return this.RoomField;
            }
            set
            {
                this.RoomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitEnd
        {
            get
            {
                return this.VisitEndField;
            }
            set
            {
                this.VisitEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitStart
        {
            get
            {
                return this.VisitStartField;
            }
            set
            {
                this.VisitStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NoticeAppointment", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class NoticeAppointment : HubService2.Appointment
    {
        
        private System.DateTime EventDateTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventDateTime
        {
            get
            {
                return this.EventDateTimeField;
            }
            set
            {
                this.EventDateTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusAppointment", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class StatusAppointment : HubService2.Appointment
    {
        
        private System.DateTime EventDateTimeField;
        
        private System.DateTime RecordDateTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventDateTime
        {
            get
            {
                return this.EventDateTimeField;
            }
            set
            {
                this.EventDateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RecordDateTime
        {
            get
            {
                return this.RecordDateTimeField;
            }
            set
            {
                this.RecordDateTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Essence", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Essence : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private string IdEssenceField;
        
        private HubService2.Essence[] ListEssenceField;
        
        private string NameEssenceField;
        
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdEssence
        {
            get
            {
                return this.IdEssenceField;
            }
            set
            {
                this.IdEssenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Essence[] ListEssence
        {
            get
            {
                return this.ListEssenceField;
            }
            set
            {
                this.ListEssenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameEssence
        {
            get
            {
                return this.NameEssenceField;
            }
            set
            {
                this.NameEssenceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum AppointmentType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутстствует_неопределено = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        повторный = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        консультация = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SpecialistType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum SpecialistType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутстствует_неопределено = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        широкого_профиля = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        узкий = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AriaNumberField;
        
        private string CommentField;
        
        private int CountFreeParticipantIEField;
        
        private int CountFreeTicketField;
        
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
        public string AriaNumber
        {
            get
            {
                return this.AriaNumberField;
            }
            set
            {
                this.AriaNumberField = value;
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
        public int CountFreeParticipantIE
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
        public int CountFreeTicket
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor4", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Doctor4 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string[] AgeGroupField;
        
        private string AreaField;
        
        private string AreaTypeField;
        
        private string CommentField;
        
        private System.Nullable<int> CountFreeParticipantIEField;
        
        private System.Nullable<int> CountFreeTicketField;
        
        private string FirstNameField;
        
        private string IdDocField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
        private string PositionIdField;
        
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
        public string[] AgeGroup
        {
            get
            {
                return this.AgeGroupField;
            }
            set
            {
                this.AgeGroupField = value;
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
        public string PositionId
        {
            get
            {
                return this.PositionIdField;
            }
            set
            {
                this.PositionIdField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Speciality3", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Speciality3 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentField;
        
        private int CountFreeParticipantIEField;
        
        private int CountFreeTicketField;
        
        private HubService2.Doctor3[] DocsField;
        
        private string FerIdSpecialityField;
        
        private string IdSpecialityField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string NameSpecialityField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
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
        public int CountFreeParticipantIE
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
        public int CountFreeTicket
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
        public HubService2.Doctor3[] Docs
        {
            get
            {
                return this.DocsField;
            }
            set
            {
                this.DocsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FerIdSpeciality
        {
            get
            {
                return this.FerIdSpecialityField;
            }
            set
            {
                this.FerIdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSpeciality
        {
            get
            {
                return this.IdSpecialityField;
            }
            set
            {
                this.IdSpecialityField = value;
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
        public string NameSpeciality
        {
            get
            {
                return this.NameSpecialityField;
            }
            set
            {
                this.NameSpecialityField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor3", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Doctor3 : object, System.Runtime.Serialization.IExtensibleDataObject
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Clinic", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Clinic : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private System.Nullable<int> DistrictField;
        
        private int IdLPUField;
        
        private bool IsActiveField;
        
        private string LPUFullNameField;
        
        private string LPUShortNameField;
        
        private int LPUTypeField;
        
        private string OidField;
        
        private System.Nullable<int> PartOfField;
        
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdLPU
        {
            get
            {
                return this.IdLPUField;
            }
            set
            {
                this.IdLPUField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive
        {
            get
            {
                return this.IsActiveField;
            }
            set
            {
                this.IsActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LPUFullName
        {
            get
            {
                return this.LPUFullNameField;
            }
            set
            {
                this.LPUFullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LPUShortName
        {
            get
            {
                return this.LPUShortNameField;
            }
            set
            {
                this.LPUShortNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LPUType
        {
            get
            {
                return this.LPUTypeField;
            }
            set
            {
                this.LPUTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Oid
        {
            get
            {
                return this.OidField;
            }
            set
            {
                this.OidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PartOf
        {
            get
            {
                return this.PartOfField;
            }
            set
            {
                this.PartOfField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrgList", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class OrgList : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ChiefField;
        
        private string ContactField;
        
        private System.Nullable<int> DistrictField;
        
        private string E_MailField;
        
        private System.Nullable<int> GIS_IDField;
        
        private System.Nullable<int> GIS_LayerField;
        
        private System.Nullable<int> Hub_IDField;
        
        private int IDField;
        
        private string Org_AddressField;
        
        private string Org_NameField;
        
        private string Org_TypeField;
        
        private string WWWField;
        
        private string WorkTimeField;
        
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
        public string Chief
        {
            get
            {
                return this.ChiefField;
            }
            set
            {
                this.ChiefField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact
        {
            get
            {
                return this.ContactField;
            }
            set
            {
                this.ContactField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string E_Mail
        {
            get
            {
                return this.E_MailField;
            }
            set
            {
                this.E_MailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GIS_ID
        {
            get
            {
                return this.GIS_IDField;
            }
            set
            {
                this.GIS_IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GIS_Layer
        {
            get
            {
                return this.GIS_LayerField;
            }
            set
            {
                this.GIS_LayerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Hub_ID
        {
            get
            {
                return this.Hub_IDField;
            }
            set
            {
                this.Hub_IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Org_Address
        {
            get
            {
                return this.Org_AddressField;
            }
            set
            {
                this.Org_AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Org_Name
        {
            get
            {
                return this.Org_NameField;
            }
            set
            {
                this.Org_NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Org_Type
        {
            get
            {
                return this.Org_TypeField;
            }
            set
            {
                this.Org_TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WWW
        {
            get
            {
                return this.WWWField;
            }
            set
            {
                this.WWWField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkTime
        {
            get
            {
                return this.WorkTimeField;
            }
            set
            {
                this.WorkTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Spesiality", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Spesiality : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CountFreeParticipantIEField;
        
        private int CountFreeTicketField;
        
        private string FerIdSpesialityField;
        
        private string IdSpesialityField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string NameSpesialityField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
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
        public int CountFreeParticipantIE
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
        public int CountFreeTicket
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
        public string FerIdSpesiality
        {
            get
            {
                return this.FerIdSpesialityField;
            }
            set
            {
                this.FerIdSpesialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSpesiality
        {
            get
            {
                return this.IdSpesialityField;
            }
            set
            {
                this.IdSpesialityField = value;
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
        public string NameSpesiality
        {
            get
            {
                return this.NameSpesialityField;
            }
            set
            {
                this.NameSpesialityField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Position : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentField;
        
        private System.Nullable<int> CountFreeParticipantIEField;
        
        private System.Nullable<int> CountFreeTicketField;
        
        private string FedIdPositionField;
        
        private string IdPositionField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string NamePositionField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
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
        public string FedIdPosition
        {
            get
            {
                return this.FedIdPositionField;
            }
            set
            {
                this.FedIdPositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPosition
        {
            get
            {
                return this.IdPositionField;
            }
            set
            {
                this.IdPositionField = value;
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
        public string NamePosition
        {
            get
            {
                return this.NamePositionField;
            }
            set
            {
                this.NamePositionField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LpuListToRFISZ", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class LpuListToRFISZ : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CommentField;
        
        private string EmailField;
        
        private System.Nullable<double> ExternalGisIdField;
        
        private System.Nullable<double> ExternalHubIdField;
        
        private int IdField;
        
        private System.Nullable<int> IdDistrictField;
        
        private bool InfoStandField;
        
        private string InternetReferenceField;
        
        private bool IsEnableAppointmentField;
        
        private bool IsEnableInternetField;
        
        private string LpuNameField;
        
        private string LpuTypeField;
        
        private string PhoneCallCentreField;
        
        private string WorkTimeField;
        
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
        public string Address
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
        public System.Nullable<double> ExternalGisId
        {
            get
            {
                return this.ExternalGisIdField;
            }
            set
            {
                this.ExternalGisIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> ExternalHubId
        {
            get
            {
                return this.ExternalHubIdField;
            }
            set
            {
                this.ExternalHubIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdDistrict
        {
            get
            {
                return this.IdDistrictField;
            }
            set
            {
                this.IdDistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InfoStand
        {
            get
            {
                return this.InfoStandField;
            }
            set
            {
                this.InfoStandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InternetReference
        {
            get
            {
                return this.InternetReferenceField;
            }
            set
            {
                this.InternetReferenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnableAppointment
        {
            get
            {
                return this.IsEnableAppointmentField;
            }
            set
            {
                this.IsEnableAppointmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnableInternet
        {
            get
            {
                return this.IsEnableInternetField;
            }
            set
            {
                this.IsEnableInternetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LpuName
        {
            get
            {
                return this.LpuNameField;
            }
            set
            {
                this.LpuNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LpuType
        {
            get
            {
                return this.LpuTypeField;
            }
            set
            {
                this.LpuTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneCallCentre
        {
            get
            {
                return this.PhoneCallCentreField;
            }
            set
            {
                this.PhoneCallCentreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkTime
        {
            get
            {
                return this.WorkTimeField;
            }
            set
            {
                this.WorkTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="District", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class District : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DistrictNameField;
        
        private int IdDistrictField;
        
        private System.Nullable<double> OkatoField;
        
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
        public string DistrictName
        {
            get
            {
                return this.DistrictNameField;
            }
            set
            {
                this.DistrictNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdDistrict
        {
            get
            {
                return this.IdDistrictField;
            }
            set
            {
                this.IdDistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Okato
        {
            get
            {
                return this.OkatoField;
            }
            set
            {
                this.OkatoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WorkingTime", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class WorkingTime : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DenyCauseField;
        
        private bool RecordableDayField;
        
        private System.DateTime VisitEndField;
        
        private System.DateTime VisitStartField;
        
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
        public string DenyCause
        {
            get
            {
                return this.DenyCauseField;
            }
            set
            {
                this.DenyCauseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RecordableDay
        {
            get
            {
                return this.RecordableDayField;
            }
            set
            {
                this.RecordableDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitEnd
        {
            get
            {
                return this.VisitEndField;
            }
            set
            {
                this.VisitEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitStart
        {
            get
            {
                return this.VisitStartField;
            }
            set
            {
                this.VisitStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HistoryRefusal", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class HistoryRefusal : HubService2.HistoryVisit
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HistoryVisit", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.HistoryRefusal))]
    public partial class HistoryVisit : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateCreatedAppointmentField;
        
        private HubService2.Doctor DoctorBringReferalField;
        
        private HubService2.Doctor DoctorRendingConsultationField;
        
        private string IdAppointmentField;
        
        private HubService2.Spesiality SpecialityBringReferalField;
        
        private HubService2.Spesiality SpecialityRendingConsultationField;
        
        private HubService2.User UserCreatedAppointmentField;
        
        private System.DateTime VisitStartField;
        
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
        public System.DateTime DateCreatedAppointment
        {
            get
            {
                return this.DateCreatedAppointmentField;
            }
            set
            {
                this.DateCreatedAppointmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor DoctorBringReferal
        {
            get
            {
                return this.DoctorBringReferalField;
            }
            set
            {
                this.DoctorBringReferalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Doctor DoctorRendingConsultation
        {
            get
            {
                return this.DoctorRendingConsultationField;
            }
            set
            {
                this.DoctorRendingConsultationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdAppointment
        {
            get
            {
                return this.IdAppointmentField;
            }
            set
            {
                this.IdAppointmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Spesiality SpecialityBringReferal
        {
            get
            {
                return this.SpecialityBringReferalField;
            }
            set
            {
                this.SpecialityBringReferalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Spesiality SpecialityRendingConsultation
        {
            get
            {
                return this.SpecialityRendingConsultationField;
            }
            set
            {
                this.SpecialityRendingConsultationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.User UserCreatedAppointment
        {
            get
            {
                return this.UserCreatedAppointmentField;
            }
            set
            {
                this.UserCreatedAppointmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitStart
        {
            get
            {
                return this.VisitStartField;
            }
            set
            {
                this.VisitStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.HubUser))]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string UserNameField;
        
        private string UserPositionField;
        
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
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPosition
        {
            get
            {
                return this.UserPositionField;
            }
            set
            {
                this.UserPositionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HubUser", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class HubUser : HubService2.User
    {
        
        private System.Nullable<int> IdDistrictField;
        
        private System.Guid PublicGuidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdDistrict
        {
            get
            {
                return this.IdDistrictField;
            }
            set
            {
                this.IdDistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PublicGuid
        {
            get
            {
                return this.PublicGuidField;
            }
            set
            {
                this.PublicGuidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SchedulerOfDoctor", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SchedulerOfDoctor : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Doctor DocField;
        
        private HubService2.SchedulerOfDoctorItem[] ShedulerOfDoctorItemCollectionField;
        
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
        public HubService2.Doctor Doc
        {
            get
            {
                return this.DocField;
            }
            set
            {
                this.DocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.SchedulerOfDoctorItem[] ShedulerOfDoctorItemCollection
        {
            get
            {
                return this.ShedulerOfDoctorItemCollectionField;
            }
            set
            {
                this.ShedulerOfDoctorItemCollectionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SchedulerOfDoctorItem", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SchedulerOfDoctorItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Appointment AppointmentItemField;
        
        private System.DateTime DateStartCheckInField;
        
        private HubService2.Patient PatField;
        
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
        public HubService2.Appointment AppointmentItem
        {
            get
            {
                return this.AppointmentItemField;
            }
            set
            {
                this.AppointmentItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateStartCheckIn
        {
            get
            {
                return this.DateStartCheckInField;
            }
            set
            {
                this.DateStartCheckInField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Patient Pat
        {
            get
            {
                return this.PatField;
            }
            set
            {
                this.PatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LpuInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class LpuInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CommentaryField;
        
        private int DistrictIdField;
        
        private string DistrictNameField;
        
        private System.Nullable<double> DistrictOkatoField;
        
        private string EmailField;
        
        private string FullNameField;
        
        private System.Nullable<int> IdField;
        
        private string OidField;
        
        private string PhoneField;
        
        private string PublicGuidField;
        
        private string ShortNameField;
        
        private string TypeField;
        
        private string WorkTimeField;
        
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
        public string Address
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
        public string Commentary
        {
            get
            {
                return this.CommentaryField;
            }
            set
            {
                this.CommentaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DistrictId
        {
            get
            {
                return this.DistrictIdField;
            }
            set
            {
                this.DistrictIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DistrictName
        {
            get
            {
                return this.DistrictNameField;
            }
            set
            {
                this.DistrictNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> DistrictOkato
        {
            get
            {
                return this.DistrictOkatoField;
            }
            set
            {
                this.DistrictOkatoField = value;
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
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Oid
        {
            get
            {
                return this.OidField;
            }
            set
            {
                this.OidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PublicGuid
        {
            get
            {
                return this.PublicGuidField;
            }
            set
            {
                this.PublicGuidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortName
        {
            get
            {
                return this.ShortNameField;
            }
            set
            {
                this.ShortNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkTime
        {
            get
            {
                return this.WorkTimeField;
            }
            set
            {
                this.WorkTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientsArea", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class PatientsArea : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AreaField;
        
        private HubService2.AreaType AreaTypeField;
        
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
        public HubService2.AreaType AreaType
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum AreaType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Фельдшерский = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Терапевтический = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ВрачОбщейПрактики = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Комплексный = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Акушерский = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Приписной = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Педиатрический = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Фтизиатрический = 8,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchOneDirectionResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class SearchOneDirectionResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string IdMqField;
        
        private HubService2.Dto.Coding MqReferralStatusField;
        
        private System.Nullable<System.DateTime> MqReferralStatusDateField;
        
        private int QLengthField;
        
        private HubService2.Dto.Referral ReferralField;
        
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
        public string IdMq
        {
            get
            {
                return this.IdMqField;
            }
            set
            {
                this.IdMqField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding MqReferralStatus
        {
            get
            {
                return this.MqReferralStatusField;
            }
            set
            {
                this.MqReferralStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> MqReferralStatusDate
        {
            get
            {
                return this.MqReferralStatusDateField;
            }
            set
            {
                this.MqReferralStatusDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QLength
        {
            get
            {
                return this.QLengthField;
            }
            set
            {
                this.QLengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Referral Referral
        {
            get
            {
                return this.ReferralField;
            }
            set
            {
                this.ReferralField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RulesOfWaitingList", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class RulesOfWaitingList : object, System.Runtime.Serialization.IExtensibleDataObject
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClaimToWaitingListType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum ClaimToWaitingListType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутствуют_свободные_талоны = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        нет_удобного_времени = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутствует_специалист = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor5", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Doctor5 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AriaNumberField;
        
        private string CommentField;
        
        private int CountFreeParticipantIEField;
        
        private int CountFreeTicketField;
        
        private string FirstNameField;
        
        private string IdDocField;
        
        private System.Nullable<System.DateTime> LastDateField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private System.Nullable<System.DateTime> NearestDateField;
        
        private string PositionIdField;
        
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
        public string AriaNumber
        {
            get
            {
                return this.AriaNumberField;
            }
            set
            {
                this.AriaNumberField = value;
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
        public int CountFreeParticipantIE
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
        public int CountFreeTicket
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
        public string PositionId
        {
            get
            {
                return this.PositionIdField;
            }
            set
            {
                this.PositionIdField = value;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentSourceType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum AppointmentSourceType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ЦТО = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Инфомат = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Регистратура = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Врач_АПУ = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Интернет = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Прочее = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentStatusType", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public enum AppointmentStatusType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        запись_отменена_по_инициативе_ЛПУ = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        запись_отменена_по_инициативе_пациента = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        запись_перенесена = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        посещение_состоялось = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        пациент_не_явился = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ContactValueField;
        
        private short IdContactTypeField;
        
        private bool IsPrefField;
        
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
        public short IdContactType
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPref
        {
            get
            {
                return this.IsPrefField;
            }
            set
            {
                this.IsPrefField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient2", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Patient2 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AriaNumberField;
        
        private System.Nullable<System.DateTime> BirthdayField;
        
        private string CellPhoneField;
        
        private string Document_NField;
        
        private string Document_SField;
        
        private string GenderField;
        
        private string HomePhoneField;
        
        private string IdPatField;
        
        private string NameField;
        
        private string Polis_NField;
        
        private string Polis_SField;
        
        private string SecondNameField;
        
        private string SnilsField;
        
        private string SurnameField;
        
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
        public string AriaNumber
        {
            get
            {
                return this.AriaNumberField;
            }
            set
            {
                this.AriaNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Birthday
        {
            get
            {
                return this.BirthdayField;
            }
            set
            {
                this.BirthdayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CellPhone
        {
            get
            {
                return this.CellPhoneField;
            }
            set
            {
                this.CellPhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document_N
        {
            get
            {
                return this.Document_NField;
            }
            set
            {
                this.Document_NField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document_S
        {
            get
            {
                return this.Document_SField;
            }
            set
            {
                this.Document_SField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhone
        {
            get
            {
                return this.HomePhoneField;
            }
            set
            {
                this.HomePhoneField = value;
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
        public string Polis_N
        {
            get
            {
                return this.Polis_NField;
            }
            set
            {
                this.Polis_NField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Polis_S
        {
            get
            {
                return this.Polis_SField;
            }
            set
            {
                this.Polis_SField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName
        {
            get
            {
                return this.SecondNameField;
            }
            set
            {
                this.SecondNameField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname
        {
            get
            {
                return this.SurnameField;
            }
            set
            {
                this.SurnameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class AppointmentInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MkbCodeField;
        
        private string PriorityField;
        
        private string PrivilegeTypeField;
        
        private string ProfileMedServiceField;
        
        private string ReasonField;
        
        private string SourceLpuField;
        
        private string SurveyOrganField;
        
        private string SurveyTypeField;
        
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
        public string Priority
        {
            get
            {
                return this.PriorityField;
            }
            set
            {
                this.PriorityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrivilegeType
        {
            get
            {
                return this.PrivilegeTypeField;
            }
            set
            {
                this.PrivilegeTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfileMedService
        {
            get
            {
                return this.ProfileMedServiceField;
            }
            set
            {
                this.ProfileMedServiceField = value;
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
        public string SourceLpu
        {
            get
            {
                return this.SourceLpuField;
            }
            set
            {
                this.SourceLpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SurveyOrgan
        {
            get
            {
                return this.SurveyOrganField;
            }
            set
            {
                this.SurveyOrganField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SurveyType
        {
            get
            {
                return this.SurveyTypeField;
            }
            set
            {
                this.SurveyTypeField = value;
            }
        }
    }
}
namespace HubService2.ContractsClasses.PostAppointment
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAvailableAppointmentsByPARequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class GetAvailableAppointmentsByPARequestResult : HubService2.MethodResult
    {
        
        private int IdLpuField;
        
        private string IdPatField;
        
        private HubService2.Speciality2[] ListSpecialityField;
        
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
        public HubService2.Speciality2[] ListSpeciality
        {
            get
            {
                return this.ListSpecialityField;
            }
            set
            {
                this.ListSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetAppointmentByPARequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SetAppointmentByPARequestResult : HubService2.MethodResult
    {
        
        private int TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterPARequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class RegisterPARequestResult : HubService2.MethodResult
    {
        
        private string IdParField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelPARequestResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class CancelPARequestResult : HubService2.MethodResult
    {
        
        private bool CancellationResultField;
        
        private string IdParField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CancellationResult
        {
            get
            {
                return this.CancellationResultField;
            }
            set
            {
                this.CancellationResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchActivePARequestsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchActivePARequestsResult : HubService2.MethodResult
    {
        
        private HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo[] ActivePARequestsField;
        
        private int CountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo[] ActivePARequests
        {
            get
            {
                return this.ActivePARequestsField;
            }
            set
            {
                this.ActivePARequestsField = value;
            }
        }
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchPARequestsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult))]
    public partial class SearchPARequestsResult : HubService2.MethodResult
    {
        
        private int CountField;
        
        private HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo[] PARequestsField;
        
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
        public HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo[] PARequests
        {
            get
            {
                return this.PARequestsField;
            }
            set
            {
                this.PARequestsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchCtoPARequestsResult", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchCtoPARequestsResult : HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivePARequestInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo))]
    public partial class ActivePARequestInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime CreatedDateField;
        
        private string IdParField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequest PARequestField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestInfo PARequestInfoField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestPatient PARequestPatientField;
        
        private int PASourceCreatedField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestInterval[] PreferredIntervalsField;
        
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
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequest PARequest
        {
            get
            {
                return this.PARequestField;
            }
            set
            {
                this.PARequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestInfo PARequestInfo
        {
            get
            {
                return this.PARequestInfoField;
            }
            set
            {
                this.PARequestInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestPatient PARequestPatient
        {
            get
            {
                return this.PARequestPatientField;
            }
            set
            {
                this.PARequestPatientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PASourceCreated
        {
            get
            {
                return this.PASourceCreatedField;
            }
            set
            {
                this.PASourceCreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestInterval[] PreferredIntervals
        {
            get
            {
                return this.PreferredIntervalsField;
            }
            set
            {
                this.PreferredIntervalsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FerIdSpecialityField;
        
        private string IdDocField;
        
        private string IdLpuField;
        
        private string IdNsiLpuField;
        
        private string IdSpecialityField;
        
        private string NameDocField;
        
        private string NameSpecialityField;
        
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
        public string FerIdSpeciality
        {
            get
            {
                return this.FerIdSpecialityField;
            }
            set
            {
                this.FerIdSpecialityField = value;
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
        public string IdLpu
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
        public string IdNsiLpu
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
        public string IdSpeciality
        {
            get
            {
                return this.IdSpecialityField;
            }
            set
            {
                this.IdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameDoc
        {
            get
            {
                return this.NameDocField;
            }
            set
            {
                this.NameDocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameSpeciality
        {
            get
            {
                return this.NameSpecialityField;
            }
            set
            {
                this.NameSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequestInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequestInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ClaimField;
        
        private string InfoField;
        
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
        public string Claim
        {
            get
            {
                return this.ClaimField;
            }
            set
            {
                this.ClaimField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info
        {
            get
            {
                return this.InfoField;
            }
            set
            {
                this.InfoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequestPatient", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequestPatient : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<System.DateTime> BirthDateField;
        
        private string FirstNameField;
        
        private string IdPatientField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestPatientContacts PARequestPatientContactsField;
        
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
        public System.Nullable<System.DateTime> BirthDate
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
        public HubService2.ContractsClasses.PostAppointment.PARequestPatientContacts PARequestPatientContacts
        {
            get
            {
                return this.PARequestPatientContactsField;
            }
            set
            {
                this.PARequestPatientContactsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchPARequestInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchPARequestInfo : HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo
    {
        
        private HubService2.ContractsClasses.PostAppointment.PARequestDeactivationInfo PARequestDeactivationInfoField;
        
        private int PARequestStatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestDeactivationInfo PARequestDeactivationInfo
        {
            get
            {
                return this.PARequestDeactivationInfoField;
            }
            set
            {
                this.PARequestDeactivationInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PARequestStatus
        {
            get
            {
                return this.PARequestStatusField;
            }
            set
            {
                this.PARequestStatusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequestInterval", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequestInterval : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime EndDateField;
        
        private System.DateTime StartDateField;
        
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
        public System.DateTime EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequestPatientContacts", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequestPatientContacts : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AdditionalInformationField;
        
        private string EmailField;
        
        private string PhoneField;
        
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
        public string AdditionalInformation
        {
            get
            {
                return this.AdditionalInformationField;
            }
            set
            {
                this.AdditionalInformationField = value;
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
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PARequestDeactivationInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class PARequestDeactivationInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DeactivationCommentField;
        
        private System.DateTime DeactivationDateField;
        
        private System.Nullable<int> DeactivationReasonField;
        
        private string LinkedIdParField;
        
        private System.Nullable<int> PASourceDeactivatedField;
        
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
        public string DeactivationComment
        {
            get
            {
                return this.DeactivationCommentField;
            }
            set
            {
                this.DeactivationCommentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DeactivationDate
        {
            get
            {
                return this.DeactivationDateField;
            }
            set
            {
                this.DeactivationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> DeactivationReason
        {
            get
            {
                return this.DeactivationReasonField;
            }
            set
            {
                this.DeactivationReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LinkedIdPar
        {
            get
            {
                return this.LinkedIdParField;
            }
            set
            {
                this.LinkedIdParField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PASourceDeactivated
        {
            get
            {
                return this.PASourceDeactivatedField;
            }
            set
            {
                this.PASourceDeactivatedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterPARequestRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class RegisterPARequestRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequest PARequestField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestInfo PARequestInfoField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestPatient PARequestPatientField;
        
        private int PASourceField;
        
        private HubService2.ContractsClasses.PostAppointment.PARequestInterval[] PreferredIntervalsField;
        
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
        public HubService2.ContractsClasses.PostAppointment.PARequest PARequest
        {
            get
            {
                return this.PARequestField;
            }
            set
            {
                this.PARequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestInfo PARequestInfo
        {
            get
            {
                return this.PARequestInfoField;
            }
            set
            {
                this.PARequestInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestPatient PARequestPatient
        {
            get
            {
                return this.PARequestPatientField;
            }
            set
            {
                this.PARequestPatientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PASource
        {
            get
            {
                return this.PASourceField;
            }
            set
            {
                this.PASourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.ContractsClasses.PostAppointment.PARequestInterval[] PreferredIntervals
        {
            get
            {
                return this.PreferredIntervalsField;
            }
            set
            {
                this.PreferredIntervalsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelPARequestRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class CancelPARequestRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DeactivationCommentField;
        
        private int DeactivationReasonField;
        
        private string IdParField;
        
        private string LinkedIdParField;
        
        private int PASourceField;
        
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
        public string DeactivationComment
        {
            get
            {
                return this.DeactivationCommentField;
            }
            set
            {
                this.DeactivationCommentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DeactivationReason
        {
            get
            {
                return this.DeactivationReasonField;
            }
            set
            {
                this.DeactivationReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LinkedIdPar
        {
            get
            {
                return this.LinkedIdParField;
            }
            set
            {
                this.LinkedIdParField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PASource
        {
            get
            {
                return this.PASourceField;
            }
            set
            {
                this.PASourceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchActivePARequestsRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchActivePARequestsRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ClaimField;
        
        private string FerIdSpecialityField;
        
        private string IdDocField;
        
        private string IdLpuField;
        
        private string IdNsiLpuField;
        
        private string IdParField;
        
        private string[] IdPatientsField;
        
        private string IdSpecialityField;
        
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
        public string Claim
        {
            get
            {
                return this.ClaimField;
            }
            set
            {
                this.ClaimField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FerIdSpeciality
        {
            get
            {
                return this.FerIdSpecialityField;
            }
            set
            {
                this.FerIdSpecialityField = value;
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
        public string IdLpu
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
        public string IdNsiLpu
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
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
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
        public string IdSpeciality
        {
            get
            {
                return this.IdSpecialityField;
            }
            set
            {
                this.IdSpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchPARequestsRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchPARequestsRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.ContractsClasses.PostAppointment.IdInfo[] IdInfosField;
        
        private string IdParField;
        
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
        public HubService2.ContractsClasses.PostAppointment.IdInfo[] IdInfos
        {
            get
            {
                return this.IdInfosField;
            }
            set
            {
                this.IdInfosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPar
        {
            get
            {
                return this.IdParField;
            }
            set
            {
                this.IdParField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class IdInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string IdLpuField;
        
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
        public string IdLpu
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchCtoPARequestsRequest", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.PostAppointm" +
        "ent")]
    public partial class SearchCtoPARequestsRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FerIdSpecialityField;
        
        private string IdDoctorField;
        
        private string IdLpuField;
        
        private string IdSpecialityField;
        
        private System.Nullable<System.DateTime> IntervalEndField;
        
        private System.Nullable<System.DateTime> IntervalStartField;
        
        private System.Nullable<System.DateTime> PatientBirthdayField;
        
        private string PatientFirstNameField;
        
        private string PatientLastNameField;
        
        private string PatientMiddleNameField;
        
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
        public string FerIdSpeciality
        {
            get
            {
                return this.FerIdSpecialityField;
            }
            set
            {
                this.FerIdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdDoctor
        {
            get
            {
                return this.IdDoctorField;
            }
            set
            {
                this.IdDoctorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdLpu
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
        public string IdSpeciality
        {
            get
            {
                return this.IdSpecialityField;
            }
            set
            {
                this.IdSpecialityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> IntervalEnd
        {
            get
            {
                return this.IntervalEndField;
            }
            set
            {
                this.IntervalEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> IntervalStart
        {
            get
            {
                return this.IntervalStartField;
            }
            set
            {
                this.IntervalStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> PatientBirthday
        {
            get
            {
                return this.PatientBirthdayField;
            }
            set
            {
                this.PatientBirthdayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientFirstName
        {
            get
            {
                return this.PatientFirstNameField;
            }
            set
            {
                this.PatientFirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientLastName
        {
            get
            {
                return this.PatientLastNameField;
            }
            set
            {
                this.PatientLastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientMiddleName
        {
            get
            {
                return this.PatientMiddleNameField;
            }
            set
            {
                this.PatientMiddleNameField = value;
            }
        }
    }
}
namespace HubService2.Dto
{
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Referral", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Referral : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.EventsInfo EventsInfoField;
        
        private HubService2.Dto.ReferralPatient PatientField;
        
        private HubService2.Dto.ReferralInfo ReferralInfoField;
        
        private HubService2.Dto.Survey ReferralSurveyField;
        
        private HubService2.Dto.ReferralSource SourceField;
        
        private HubService2.Dto.ReferralTarget TargetField;
        
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
        public HubService2.Dto.EventsInfo EventsInfo
        {
            get
            {
                return this.EventsInfoField;
            }
            set
            {
                this.EventsInfoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.ReferralPatient Patient
        {
            get
            {
                return this.PatientField;
            }
            set
            {
                this.PatientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.ReferralInfo ReferralInfo
        {
            get
            {
                return this.ReferralInfoField;
            }
            set
            {
                this.ReferralInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Survey ReferralSurvey
        {
            get
            {
                return this.ReferralSurveyField;
            }
            set
            {
                this.ReferralSurveyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.ReferralSource Source
        {
            get
            {
                return this.SourceField;
            }
            set
            {
                this.SourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.ReferralTarget Target
        {
            get
            {
                return this.TargetField;
            }
            set
            {
                this.TargetField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventsInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class EventsInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.CancellationData CancellationField;
        
        private HubService2.Dto.EventSource SourceField;
        
        private HubService2.Dto.EventTarget TargetField;
        
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
        public HubService2.Dto.CancellationData Cancellation
        {
            get
            {
                return this.CancellationField;
            }
            set
            {
                this.CancellationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.EventSource Source
        {
            get
            {
                return this.SourceField;
            }
            set
            {
                this.SourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.EventTarget Target
        {
            get
            {
                return this.TargetField;
            }
            set
            {
                this.TargetField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class ReferralPatient : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.AddressDto[] AddressesField;
        
        private HubService2.Dto.ContactDto[] ContactDtosField;
        
        private HubService2.Dto.DocumentDto[] DocumentsField;
        
        private HubService2.Dto.Job[] JobsField;
        
        private HubService2.Dto.Person PersonField;
        
        private HubService2.Dto.Privilege[] PrivilegesField;
        
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
        public HubService2.Dto.AddressDto[] Addresses
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
        public HubService2.Dto.ContactDto[] ContactDtos
        {
            get
            {
                return this.ContactDtosField;
            }
            set
            {
                this.ContactDtosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.DocumentDto[] Documents
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
        public HubService2.Dto.Job[] Jobs
        {
            get
            {
                return this.JobsField;
            }
            set
            {
                this.JobsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Person Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Privilege[] Privileges
        {
            get
            {
                return this.PrivilegesField;
            }
            set
            {
                this.PrivilegesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReferralInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class ReferralInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentField;
        
        private System.Nullable<System.DateTime> DateField;
        
        private string IdMqField;
        
        private HubService2.Dto.Coding MqReferralStatusField;
        
        private string PriorityField;
        
        private HubService2.Dto.Coding ProfileMedServiceField;
        
        private string ReasonField;
        
        private HubService2.Dto.Coding ReferralTypeField;
        
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
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdMq
        {
            get
            {
                return this.IdMqField;
            }
            set
            {
                this.IdMqField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding MqReferralStatus
        {
            get
            {
                return this.MqReferralStatusField;
            }
            set
            {
                this.MqReferralStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Priority
        {
            get
            {
                return this.PriorityField;
            }
            set
            {
                this.PriorityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding ProfileMedService
        {
            get
            {
                return this.ProfileMedServiceField;
            }
            set
            {
                this.ProfileMedServiceField = value;
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
        public HubService2.Dto.Coding ReferralType
        {
            get
            {
                return this.ReferralTypeField;
            }
            set
            {
                this.ReferralTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Survey", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Survey : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Additional AdditionalField;
        
        private string CommentField;
        
        private HubService2.Dto.Coding SurveyOrganField;
        
        private HubService2.Dto.Coding SurveyTypeField;
        
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
        public HubService2.Dto.Additional Additional
        {
            get
            {
                return this.AdditionalField;
            }
            set
            {
                this.AdditionalField = value;
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
        public HubService2.Dto.Coding SurveyOrgan
        {
            get
            {
                return this.SurveyOrganField;
            }
            set
            {
                this.SurveyOrganField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding SurveyType
        {
            get
            {
                return this.SurveyTypeField;
            }
            set
            {
                this.SurveyTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReferralSource", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class ReferralSource : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Doctor6[] DoctorsField;
        
        private string IdCaseMisField;
        
        private string IdReferralMisField;
        
        private HubService2.Dto.Coding LpuField;
        
        private HubService2.Dto.MainDiagnosis[] MainDiagnosisField;
        
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
        public HubService2.Dto.Doctor6[] Doctors
        {
            get
            {
                return this.DoctorsField;
            }
            set
            {
                this.DoctorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCaseMis
        {
            get
            {
                return this.IdCaseMisField;
            }
            set
            {
                this.IdCaseMisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdReferralMis
        {
            get
            {
                return this.IdReferralMisField;
            }
            set
            {
                this.IdReferralMisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Lpu
        {
            get
            {
                return this.LpuField;
            }
            set
            {
                this.LpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.MainDiagnosis[] MainDiagnosis
        {
            get
            {
                return this.MainDiagnosisField;
            }
            set
            {
                this.MainDiagnosisField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReferralTarget", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class ReferralTarget : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Doctor6[] DoctorsField;
        
        private string IdCaseMisField;
        
        private System.Nullable<bool> IsReferralReviewedField;
        
        private HubService2.Dto.Coding LpuField;
        
        private HubService2.Dto.MainDiagnosis[] MainDiagnosisField;
        
        private string ReceptionAppointCommentField;
        
        private System.Nullable<System.DateTime> ReceptionAppointDateField;
        
        private string ReceptionAppointTimeField;
        
        private System.Nullable<System.DateTime> ReferralReviewDateField;
        
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
        public HubService2.Dto.Doctor6[] Doctors
        {
            get
            {
                return this.DoctorsField;
            }
            set
            {
                this.DoctorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCaseMis
        {
            get
            {
                return this.IdCaseMisField;
            }
            set
            {
                this.IdCaseMisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsReferralReviewed
        {
            get
            {
                return this.IsReferralReviewedField;
            }
            set
            {
                this.IsReferralReviewedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Lpu
        {
            get
            {
                return this.LpuField;
            }
            set
            {
                this.LpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.MainDiagnosis[] MainDiagnosis
        {
            get
            {
                return this.MainDiagnosisField;
            }
            set
            {
                this.MainDiagnosisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceptionAppointComment
        {
            get
            {
                return this.ReceptionAppointCommentField;
            }
            set
            {
                this.ReceptionAppointCommentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReceptionAppointDate
        {
            get
            {
                return this.ReceptionAppointDateField;
            }
            set
            {
                this.ReceptionAppointDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceptionAppointTime
        {
            get
            {
                return this.ReceptionAppointTimeField;
            }
            set
            {
                this.ReceptionAppointTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReferralReviewDate
        {
            get
            {
                return this.ReferralReviewDateField;
            }
            set
            {
                this.ReferralReviewDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancellationData", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class CancellationData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Coding CancellationReasonField;
        
        private HubService2.Dto.Coding CancellationSourceField;
        
        private System.Nullable<System.DateTime> DateField;
        
        private string ReasonCommentField;
        
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
        public HubService2.Dto.Coding CancellationReason
        {
            get
            {
                return this.CancellationReasonField;
            }
            set
            {
                this.CancellationReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding CancellationSource
        {
            get
            {
                return this.CancellationSourceField;
            }
            set
            {
                this.CancellationSourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReasonComment
        {
            get
            {
                return this.ReasonCommentField;
            }
            set
            {
                this.ReasonCommentField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventSource", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class EventSource : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<bool> IsReferralReviewedField;
        
        private System.Nullable<System.DateTime> PlannedDateField;
        
        private System.Nullable<System.DateTime> ReferralCreateDateField;
        
        private System.Nullable<System.DateTime> ReferralOutDateField;
        
        private System.Nullable<System.DateTime> ReferralReviewDateField;
        
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
        public System.Nullable<bool> IsReferralReviewed
        {
            get
            {
                return this.IsReferralReviewedField;
            }
            set
            {
                this.IsReferralReviewedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> PlannedDate
        {
            get
            {
                return this.PlannedDateField;
            }
            set
            {
                this.PlannedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReferralCreateDate
        {
            get
            {
                return this.ReferralCreateDateField;
            }
            set
            {
                this.ReferralCreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReferralOutDate
        {
            get
            {
                return this.ReferralOutDateField;
            }
            set
            {
                this.ReferralOutDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReferralReviewDate
        {
            get
            {
                return this.ReferralReviewDateField;
            }
            set
            {
                this.ReferralReviewDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventTarget", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class EventTarget : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Coding CaseAidFormField;
        
        private HubService2.Dto.Coding CaseAidPlaceField;
        
        private HubService2.Dto.Coding CaseAidTypeField;
        
        private System.Nullable<System.DateTime> CaseCloseDateField;
        
        private System.Nullable<System.DateTime> CaseOpenDateField;
        
        private System.Nullable<bool> IsReferralReviwedField;
        
        private HubService2.Dto.Coding LpuField;
        
        private string ReceptionAppointCommentField;
        
        private System.Nullable<System.DateTime> ReceptionAppointDateField;
        
        private string ReceptionAppointTimeField;
        
        private System.Nullable<System.DateTime> ReferralReviewDateField;
        
        private System.Nullable<System.DateTime> RefferalCreatedDateField;
        
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
        public HubService2.Dto.Coding CaseAidForm
        {
            get
            {
                return this.CaseAidFormField;
            }
            set
            {
                this.CaseAidFormField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding CaseAidPlace
        {
            get
            {
                return this.CaseAidPlaceField;
            }
            set
            {
                this.CaseAidPlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding CaseAidType
        {
            get
            {
                return this.CaseAidTypeField;
            }
            set
            {
                this.CaseAidTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CaseCloseDate
        {
            get
            {
                return this.CaseCloseDateField;
            }
            set
            {
                this.CaseCloseDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CaseOpenDate
        {
            get
            {
                return this.CaseOpenDateField;
            }
            set
            {
                this.CaseOpenDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsReferralReviwed
        {
            get
            {
                return this.IsReferralReviwedField;
            }
            set
            {
                this.IsReferralReviwedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Lpu
        {
            get
            {
                return this.LpuField;
            }
            set
            {
                this.LpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceptionAppointComment
        {
            get
            {
                return this.ReceptionAppointCommentField;
            }
            set
            {
                this.ReceptionAppointCommentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReceptionAppointDate
        {
            get
            {
                return this.ReceptionAppointDateField;
            }
            set
            {
                this.ReceptionAppointDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceptionAppointTime
        {
            get
            {
                return this.ReceptionAppointTimeField;
            }
            set
            {
                this.ReceptionAppointTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReferralReviewDate
        {
            get
            {
                return this.ReferralReviewDateField;
            }
            set
            {
                this.ReferralReviewDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> RefferalCreatedDate
        {
            get
            {
                return this.RefferalCreatedDateField;
            }
            set
            {
                this.RefferalCreatedDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Coding", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Coding : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CodeField;
        
        private string SystemField;
        
        private string VersionField;
        
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
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string System
        {
            get
            {
                return this.SystemField;
            }
            set
            {
                this.SystemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version
        {
            get
            {
                return this.VersionField;
            }
            set
            {
                this.VersionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<System.DateTime> BirthDateField;
        
        private HubService2.Dto.HumanName HumanNameField;
        
        private string IdPatientMisField;
        
        private string IdPersonMisField;
        
        private HubService2.Dto.Coding SexField;
        
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
        public System.Nullable<System.DateTime> BirthDate
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
        public HubService2.Dto.HumanName HumanName
        {
            get
            {
                return this.HumanNameField;
            }
            set
            {
                this.HumanNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdPatientMis
        {
            get
            {
                return this.IdPatientMisField;
            }
            set
            {
                this.IdPatientMisField = value;
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
        public HubService2.Dto.Coding Sex
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressDto", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class AddressDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Coding AddressTypeField;
        
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
        public HubService2.Dto.Coding AddressType
        {
            get
            {
                return this.AddressTypeField;
            }
            set
            {
                this.AddressTypeField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ContactDto", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class ContactDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.Coding ContactTypeField;
        
        private string ContactValueField;
        
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
        public HubService2.Dto.Coding ContactType
        {
            get
            {
                return this.ContactTypeField;
            }
            set
            {
                this.ContactTypeField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentDto", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class DocumentDto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DocNField;
        
        private string DocSField;
        
        private HubService2.Dto.Coding DocumentTypeField;
        
        private System.Nullable<System.DateTime> ExpiredDateField;
        
        private System.Nullable<System.DateTime> IssuedDateField;
        
        private HubService2.Dto.Coding ProviderField;
        
        private string ProviderNameField;
        
        private HubService2.Dto.Coding RegionCodeField;
        
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
        public HubService2.Dto.Coding DocumentType
        {
            get
            {
                return this.DocumentTypeField;
            }
            set
            {
                this.DocumentTypeField = value;
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
        public HubService2.Dto.Coding Provider
        {
            get
            {
                return this.ProviderField;
            }
            set
            {
                this.ProviderField = value;
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
        public HubService2.Dto.Coding RegionCode
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Job", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Job : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CompanyNameField;
        
        private string PositionField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Privilege", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Privilege : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<System.DateTime> EndDateField;
        
        private HubService2.Dto.Coding PrivilegeTypeField;
        
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
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding PrivilegeType
        {
            get
            {
                return this.PrivilegeTypeField;
            }
            set
            {
                this.PrivilegeTypeField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HumanName", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class HumanName : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FamilyNameField;
        
        private string GivenNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Additional", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Additional : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AllergyIodineField;
        
        private string HeightField;
        
        private string WeightField;
        
        //private System.Collections.Generic.Dictionary<string, string> ExtraDataField;
        
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
        public string AllergyIodine
        {
            get
            {
                return this.AllergyIodineField;
            }
            set
            {
                this.AllergyIodineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Height
        {
            get
            {
                return this.HeightField;
            }
            set
            {
                this.HeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight
        {
            get
            {
                return this.WeightField;
            }
            set
            {
                this.WeightField = value;
            }
        }
        
        //[System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        //public System.Collections.Generic.Dictionary<string, string> ExtraData
        //{
        //    get
        //    {
        //        return this.ExtraDataField;
        //    }
        //    set
        //    {
        //        this.ExtraDataField = value;
        //    }
        //}
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor6", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class Doctor6 : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.ContactDto[] ContactDtosField;
        
        private HubService2.Dto.Coding LpuField;
        
        private HubService2.Dto.Person PersonField;
        
        private HubService2.Dto.Coding PositionField;
        
        private HubService2.Dto.Coding RoleField;
        
        private HubService2.Dto.Coding SpecialityField;
        
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
        public HubService2.Dto.ContactDto[] ContactDtos
        {
            get
            {
                return this.ContactDtosField;
            }
            set
            {
                this.ContactDtosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Lpu
        {
            get
            {
                return this.LpuField;
            }
            set
            {
                this.LpuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Person Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Position
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
        public HubService2.Dto.Coding Role
        {
            get
            {
                return this.RoleField;
            }
            set
            {
                this.RoleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding Speciality
        {
            get
            {
                return this.SpecialityField;
            }
            set
            {
                this.SpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MainDiagnosis", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class MainDiagnosis : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private HubService2.Dto.DiagnosisInfo[] ComplicationDiagnosisField;
        
        private HubService2.Dto.DiagnosisInfo DiagnosisInfoField;
        
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
        public HubService2.Dto.DiagnosisInfo[] ComplicationDiagnosis
        {
            get
            {
                return this.ComplicationDiagnosisField;
            }
            set
            {
                this.ComplicationDiagnosisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.DiagnosisInfo DiagnosisInfo
        {
            get
            {
                return this.DiagnosisInfoField;
            }
            set
            {
                this.DiagnosisInfoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiagnosisInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.Dto")]
    public partial class DiagnosisInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentField;
        
        private System.Nullable<System.DateTime> DiagnosedDateField;
        
        private HubService2.Dto.Coding DiagnosisTypeField;
        
        private HubService2.Dto.Coding MkbCodeField;
        
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
        public System.Nullable<System.DateTime> DiagnosedDate
        {
            get
            {
                return this.DiagnosedDateField;
            }
            set
            {
                this.DiagnosedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding DiagnosisType
        {
            get
            {
                return this.DiagnosisTypeField;
            }
            set
            {
                this.DiagnosisTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HubService2.Dto.Coding MkbCode
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
    }
}
namespace HubService2.ContractsClasses.ProxyAndReturn
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicalOrganization", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.ProxyAndRetu" +
        "rn")]
    public partial class MedicalOrganization : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string NameField;
        
        private string PhoneField;
        
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
        public string Address
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
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicalResource", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.ProxyAndRetu" +
        "rn")]
    public partial class MedicalResource : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MoAddressField;
        
        private string MoNameField;
        
        private string NameField;
        
        private string PositionField;
        
        private string RoomField;
        
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
        public string MoAddress
        {
            get
            {
                return this.MoAddressField;
            }
            set
            {
                this.MoAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MoName
        {
            get
            {
                return this.MoNameField;
            }
            set
            {
                this.MoNameField = value;
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
        public string Room
        {
            get
            {
                return this.RoomField;
            }
            set
            {
                this.RoomField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NextAvailableDate", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.ProxyAndRetu" +
        "rn")]
    public partial class NextAvailableDate : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime AvailableDateField;
        
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
        public System.DateTime AvailableDate
        {
            get
            {
                return this.AvailableDateField;
            }
            set
            {
                this.AvailableDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisitInfo", Namespace="http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.ProxyAndRetu" +
        "rn")]
    public partial class VisitInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime[] VisitDateTimesField;
        
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
        public System.DateTime[] VisitDateTimes
        {
            get
            {
                return this.VisitDateTimesField;
            }
            set
            {
                this.VisitDateTimesField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHubService")]
public interface IHubService
{
    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetSpesialityList", ReplyAction = "http://tempuri.org/IHubService/GetSpesialityListResponse")]
    HubService2.GetSpesialityListResult GetSpesialityList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetSpesialityList", ReplyAction = "http://tempuri.org/IHubService/GetSpesialityListResponse")]
    System.Threading.Tasks.Task<HubService2.GetSpesialityListResult> GetSpesialityListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList", ReplyAction = "http://tempuri.org/IHubService/GetDoctorListResponse")]
    HubService2.GetDoctorListResult GetDoctorList(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList", ReplyAction = "http://tempuri.org/IHubService/GetDoctorListResponse")]
    System.Threading.Tasks.Task<HubService2.GetDoctorListResult> GetDoctorListAsync(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList2", ReplyAction = "http://tempuri.org/IHubService/GetDoctorList2Response")]
    HubService2.GetDoctorList2Result GetDoctorList2(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList2", ReplyAction = "http://tempuri.org/IHubService/GetDoctorList2Response")]
    System.Threading.Tasks.Task<HubService2.GetDoctorList2Result> GetDoctorList2Async(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetAvaibleAppointments", ReplyAction = "http://tempuri.org/IHubService/GetAvaibleAppointmentsResponse")]
    HubService2.GetAvaibleAppointmentsResult GetAvaibleAppointments(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetAvaibleAppointments", ReplyAction = "http://tempuri.org/IHubService/GetAvaibleAppointmentsResponse")]
    System.Threading.Tasks.Task<HubService2.GetAvaibleAppointmentsResult> GetAvaibleAppointmentsAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckPatient", ReplyAction="http://tempuri.org/IHubService/CheckPatientResponse")]
    HubService2.CheckPatientResult CheckPatient(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckPatient", ReplyAction="http://tempuri.org/IHubService/CheckPatientResponse")]
    System.Threading.Tasks.Task<HubService2.CheckPatientResult> CheckPatientAsync(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SetAppointment", ReplyAction = "http://tempuri.org/IHubService/SetAppointmentResponse")]
    HubService2.SetAppointmentResult SetAppointment(string idAppointment, int idLpu, string idPat, string doctorsReferral, HubService2.SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SetAppointment", ReplyAction = "http://tempuri.org/IHubService/SetAppointmentResponse")]
    System.Threading.Tasks.Task<HubService2.SetAppointmentResult> SetAppointmentAsync(string idAppointment, int idLpu, string idPat, string doctorsReferral, HubService2.SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPositionList", ReplyAction = "http://tempuri.org/IHubService/GetPositionListResponse")]
    HubService2.GetPositionListResult GetPositionList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPositionList", ReplyAction = "http://tempuri.org/IHubService/GetPositionListResponse")]
    System.Threading.Tasks.Task<HubService2.GetPositionListResult> GetPositionListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPatientHistory", ReplyAction = "http://tempuri.org/IHubService/GetPatientHistoryResponse")]
    HubService2.GetPatientHistoryResult GetPatientHistory(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPatientHistory", ReplyAction = "http://tempuri.org/IHubService/GetPatientHistoryResponse")]
    System.Threading.Tasks.Task<HubService2.GetPatientHistoryResult> GetPatientHistoryAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/CreateClaimForRefusal", ReplyAction = "http://tempuri.org/IHubService/CreateClaimForRefusalResponse")]
    HubService2.CreateClaimForRefusalResult CreateClaimForRefusal(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/CreateClaimForRefusal", ReplyAction = "http://tempuri.org/IHubService/CreateClaimForRefusalResponse")]
    System.Threading.Tasks.Task<HubService2.CreateClaimForRefusalResult> CreateClaimForRefusalAsync(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointment", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentResponse")]
    HubService2.SendNotificationAboutAppointmentResult SendNotificationAboutAppointment(HubService2.Doctor5 doctor, HubService2.Spesiality spesiality, int idLpu, HubService2.Patient patient, HubService2.Appointment appointment, string doctorsReferal, HubService2.AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointment", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentResponse")]
    System.Threading.Tasks.Task<HubService2.SendNotificationAboutAppointmentResult> SendNotificationAboutAppointmentAsync(HubService2.Doctor5 doctor, HubService2.Spesiality spesiality, int idLpu, HubService2.Patient patient, HubService2.Appointment appointment, string doctorsReferal, HubService2.AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatus", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatusResponse")]
    HubService2.SendNotificationAboutAppointmentStatusResult SendNotificationAboutAppointmentStatus(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, HubService2.AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatus", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatusResponse")]
    System.Threading.Tasks.Task<HubService2.SendNotificationAboutAppointmentStatusResult> SendNotificationAboutAppointmentStatusAsync(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, HubService2.AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason);

    #region Не используется

    /*
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckReferral", ReplyAction="http://tempuri.org/IHubService/CheckReferralResponse")]
    HubService2.CheckReferralResult CheckReferral(string doctorsReferral, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckReferral", ReplyAction="http://tempuri.org/IHubService/CheckReferralResponse")]
    System.Threading.Tasks.Task<HubService2.CheckReferralResult> CheckReferralAsync(string doctorsReferral, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchTop10Patient", ReplyAction="http://tempuri.org/IHubService/SearchTop10PatientResponse")]
    HubService2.SearchTop10PatientResult SearchTop10Patient(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchTop10Patient", ReplyAction="http://tempuri.org/IHubService/SearchTop10PatientResponse")]
    System.Threading.Tasks.Task<HubService2.SearchTop10PatientResult> SearchTop10PatientAsync(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/AddNewPatient", ReplyAction="http://tempuri.org/IHubService/AddNewPatientResponse")]
    HubService2.AddNewPatientResult AddNewPatient(HubService2.Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/AddNewPatient", ReplyAction="http://tempuri.org/IHubService/AddNewPatientResponse")]
    System.Threading.Tasks.Task<HubService2.AddNewPatientResult> AddNewPatientAsync(HubService2.Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetDocListFullTree", ReplyAction="http://tempuri.org/IHubService/GetDocListFullTreeResponse")]
    HubService2.GetDocListFullTreeResult GetDocListFullTree(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetDocListFullTree", ReplyAction="http://tempuri.org/IHubService/GetDocListFullTreeResponse")]
    System.Threading.Tasks.Task<HubService2.GetDocListFullTreeResult> GetDocListFullTreeAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/InspectDoctorsReferal", ReplyAction="http://tempuri.org/IHubService/InspectDoctorsReferalResponse")]
    HubService2.InspectDoctorsReferalResult InspectDoctorsReferal(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/InspectDoctorsReferal", ReplyAction="http://tempuri.org/IHubService/InspectDoctorsReferalResponse")]
    System.Threading.Tasks.Task<HubService2.InspectDoctorsReferalResult> InspectDoctorsReferalAsync(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/InspectDoctorsReferral2", ReplyAction="http://tempuri.org/IHubService/InspectDoctorsReferral2Response")]
    HubService2.InspectDoctorsReferral2Result InspectDoctorsReferral2(System.Nullable<int> idLpu, string doctorsReferal, string surname, HubService2.SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/InspectDoctorsReferral2", ReplyAction="http://tempuri.org/IHubService/InspectDoctorsReferral2Response")]
    System.Threading.Tasks.Task<HubService2.InspectDoctorsReferral2Result> InspectDoctorsReferral2Async(System.Nullable<int> idLpu, string doctorsReferal, string surname, HubService2.SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAppointmentsDemandDoctorsReferal", ReplyAction="http://tempuri.org/IHubService/GetAppointmentsDemandDoctorsReferalResponse")]
    HubService2.GetAvaibleAppointmentsResult GetAppointmentsDemandDoctorsReferal(string idDoc, int idLpu, string idPat, HubService2.AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAppointmentsDemandDoctorsReferal", ReplyAction="http://tempuri.org/IHubService/GetAppointmentsDemandDoctorsReferalResponse")]
    System.Threading.Tasks.Task<HubService2.GetAvaibleAppointmentsResult> GetAppointmentsDemandDoctorsReferalAsync(string idDoc, int idLpu, string idPat, HubService2.AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableDates", ReplyAction="http://tempuri.org/IHubService/GetAvailableDatesResponse")]
    HubService2.GetAvailableDatesResult GetAvailableDates(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableDates", ReplyAction="http://tempuri.org/IHubService/GetAvailableDatesResponse")]
    System.Threading.Tasks.Task<HubService2.GetAvailableDatesResult> GetAvailableDatesAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableDoctors", ReplyAction="http://tempuri.org/IHubService/GetAvailableDoctorsResponse")]
    HubService2.GetAvailableDoctorsResult GetAvailableDoctors(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableDoctors", ReplyAction="http://tempuri.org/IHubService/GetAvailableDoctorsResponse")]
    System.Threading.Tasks.Task<HubService2.GetAvailableDoctorsResult> GetAvailableDoctorsAsync(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLPUList", ReplyAction="http://tempuri.org/IHubService/GetLPUListResponse")]
    HubService2.GetLPUListResult GetLPUList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLPUList", ReplyAction="http://tempuri.org/IHubService/GetLPUListResponse")]
    System.Threading.Tasks.Task<HubService2.GetLPUListResult> GetLPUListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetOrgList", ReplyAction="http://tempuri.org/IHubService/GetOrgListResponse")]
    HubService2.GetOrgListResult GetOrgList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetOrgList", ReplyAction="http://tempuri.org/IHubService/GetOrgListResponse")]
    System.Threading.Tasks.Task<HubService2.GetOrgListResult> GetOrgListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLpuToRFSZIList", ReplyAction="http://tempuri.org/IHubService/GetLpuToRFSZIListResponse")]
    HubService2.LpuListToRfiszResult GetLpuToRFSZIList(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLpuToRFSZIList", ReplyAction="http://tempuri.org/IHubService/GetLpuToRFSZIListResponse")]
    System.Threading.Tasks.Task<HubService2.LpuListToRfiszResult> GetLpuToRFSZIListAsync(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetDistrictList", ReplyAction="http://tempuri.org/IHubService/GetDistrictListResponse")]
    HubService2.DistrictResult GetDistrictList(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetDistrictList", ReplyAction="http://tempuri.org/IHubService/GetDistrictListResponse")]
    System.Threading.Tasks.Task<HubService2.DistrictResult> GetDistrictListAsync(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetWorkingTime", ReplyAction="http://tempuri.org/IHubService/GetWorkingTimeResponse")]
    HubService2.GetWorkingTimeResult GetWorkingTime(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetWorkingTime", ReplyAction="http://tempuri.org/IHubService/GetWorkingTimeResponse")]
    System.Threading.Tasks.Task<HubService2.GetWorkingTimeResult> GetWorkingTimeAsync(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetFullInfoById", ReplyAction="http://tempuri.org/IHubService/GetFullInfoByIdResponse")]
    HubService2.GetFullInfoByIdResult GetFullInfoById(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetFullInfoById", ReplyAction="http://tempuri.org/IHubService/GetFullInfoByIdResponse")]
    System.Threading.Tasks.Task<HubService2.GetFullInfoByIdResult> GetFullInfoByIdAsync(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/UpdatePhoneByIdPat", ReplyAction="http://tempuri.org/IHubService/UpdatePhoneByIdPatResponse")]
    HubService2.UpdatePhoneByIdPatResult UpdatePhoneByIdPat(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/UpdatePhoneByIdPat", ReplyAction="http://tempuri.org/IHubService/UpdatePhoneByIdPatResponse")]
    System.Threading.Tasks.Task<HubService2.UpdatePhoneByIdPatResult> UpdatePhoneByIdPatAsync(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetHubUserByGuid", ReplyAction="http://tempuri.org/IHubService/GetHubUserByGuidResponse")]
    HubService2.GetHubUserByGuidResult GetHubUserByGuid(string usersGuid, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetHubUserByGuid", ReplyAction="http://tempuri.org/IHubService/GetHubUserByGuidResponse")]
    System.Threading.Tasks.Task<HubService2.GetHubUserByGuidResult> GetHubUserByGuidAsync(string usersGuid, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetErrorList", ReplyAction="http://tempuri.org/IHubService/GetErrorListResponse")]
    HubService2.GetErrorListResult GetErrorList(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetErrorList", ReplyAction="http://tempuri.org/IHubService/GetErrorListResponse")]
    System.Threading.Tasks.Task<HubService2.GetErrorListResult> GetErrorListAsync(string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SetWaitingList", ReplyAction="http://tempuri.org/IHubService/SetWaitingListResponse")]
    HubService2.SetWaitingListResult SetWaitingList(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, HubService2.RulesOfWaitingList rule, HubService2.ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SetWaitingList", ReplyAction="http://tempuri.org/IHubService/SetWaitingListResponse")]
    System.Threading.Tasks.Task<HubService2.SetWaitingListResult> SetWaitingListAsync(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, HubService2.RulesOfWaitingList rule, HubService2.ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetStatusAnalysis", ReplyAction="http://tempuri.org/IHubService/GetStatusAnalysisResponse")]
    HubService2.GetStatusAnalysisResult GetStatusAnalysis(long idAnalysis, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetStatusAnalysis", ReplyAction="http://tempuri.org/IHubService/GetStatusAnalysisResponse")]
    System.Threading.Tasks.Task<HubService2.GetStatusAnalysisResult> GetStatusAnalysisAsync(long idAnalysis, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetTodayAppointments", ReplyAction="http://tempuri.org/IHubService/GetTodayAppointmentsResponse")]
    HubService2.GetTodayAppointmentResult GetTodayAppointments(string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetTodayAppointments", ReplyAction="http://tempuri.org/IHubService/GetTodayAppointmentsResponse")]
    System.Threading.Tasks.Task<HubService2.GetTodayAppointmentResult> GetTodayAppointmentsAsync(string guid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLPUInfo", ReplyAction="http://tempuri.org/IHubService/GetLPUInfoResponse")]
    HubService2.LpuInformationResult GetLPUInfo(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetLPUInfo", ReplyAction="http://tempuri.org/IHubService/GetLPUInfoResponse")]
    System.Threading.Tasks.Task<HubService2.LpuInformationResult> GetLPUInfoAsync(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetPatientsAreas", ReplyAction="http://tempuri.org/IHubService/GetPatientsAreasResponse")]
    HubService2.GetPatientsAreasResult GetPatientsAreas(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetPatientsAreas", ReplyAction="http://tempuri.org/IHubService/GetPatientsAreasResponse")]
    System.Threading.Tasks.Task<HubService2.GetPatientsAreasResult> GetPatientsAreasAsync(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckIn", ReplyAction="http://tempuri.org/IHubService/CheckInResponse")]
    HubService2.CheckInResult CheckIn(string idAppointment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CheckIn", ReplyAction="http://tempuri.org/IHubService/CheckInResponse")]
    System.Threading.Tasks.Task<HubService2.CheckInResult> CheckInAsync(string idAppointment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetVersion", ReplyAction="http://tempuri.org/IHubService/GetVersionResponse")]
    HubService2.GetVersionResult GetVersion();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetVersion", ReplyAction="http://tempuri.org/IHubService/GetVersionResponse")]
    System.Threading.Tasks.Task<HubService2.GetVersionResult> GetVersionAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/PatientNotification", ReplyAction="http://tempuri.org/IHubService/PatientNotificationResponse")]
    HubService2.PatientNotificationResult PatientNotification(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, HubService2.Contact[] contacts, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/PatientNotification", ReplyAction="http://tempuri.org/IHubService/PatientNotificationResponse")]
    System.Threading.Tasks.Task<HubService2.PatientNotificationResult> PatientNotificationAsync(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, HubService2.Contact[] contacts, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableAppointmentsInfo", ReplyAction="http://tempuri.org/IHubService/GetAvailableAppointmentsInfoResponse")]
    HubService2.AvailableAppointmentsInfoResult GetAvailableAppointmentsInfo(HubService2.Patient2 patient2, HubService2.AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableAppointmentsInfo", ReplyAction="http://tempuri.org/IHubService/GetAvailableAppointmentsInfoResponse")]
    System.Threading.Tasks.Task<HubService2.AvailableAppointmentsInfoResult> GetAvailableAppointmentsInfoAsync(HubService2.Patient2 patient2, HubService2.AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableAppointmentsByPARequest", ReplyAction="http://tempuri.org/IHubService/GetAvailableAppointmentsByPARequestResponse")]
    HubService2.ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult GetAvailableAppointmentsByPARequest(HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/GetAvailableAppointmentsByPARequest", ReplyAction="http://tempuri.org/IHubService/GetAvailableAppointmentsByPARequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult> GetAvailableAppointmentsByPARequestAsync(HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SetAppointmentByPARequest", ReplyAction="http://tempuri.org/IHubService/SetAppointmentByPARequestResponse")]
    HubService2.ContractsClasses.PostAppointment.SetAppointmentByPARequestResult SetAppointmentByPARequest(string idAppointment, HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SetAppointmentByPARequest", ReplyAction="http://tempuri.org/IHubService/SetAppointmentByPARequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SetAppointmentByPARequestResult> SetAppointmentByPARequestAsync(string idAppointment, HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/RegisterPARequest", ReplyAction="http://tempuri.org/IHubService/RegisterPARequestResponse")]
    HubService2.ContractsClasses.PostAppointment.RegisterPARequestResult RegisterPARequest(HubService2.ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/RegisterPARequest", ReplyAction="http://tempuri.org/IHubService/RegisterPARequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.RegisterPARequestResult> RegisterPARequestAsync(HubService2.ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CancelPARequest", ReplyAction="http://tempuri.org/IHubService/CancelPARequestResponse")]
    HubService2.ContractsClasses.PostAppointment.CancelPARequestResult CancelPARequest(HubService2.ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/CancelPARequest", ReplyAction="http://tempuri.org/IHubService/CancelPARequestResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.CancelPARequestResult> CancelPARequestAsync(HubService2.ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchActivePARequests", ReplyAction="http://tempuri.org/IHubService/SearchActivePARequestsResponse")]
    HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsResult SearchActivePARequests(HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchActivePARequests", ReplyAction="http://tempuri.org/IHubService/SearchActivePARequestsResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsResult> SearchActivePARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchPARequests", ReplyAction="http://tempuri.org/IHubService/SearchPARequestsResponse")]
    HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult SearchPARequests(HubService2.ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchPARequests", ReplyAction="http://tempuri.org/IHubService/SearchPARequestsResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult> SearchPARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchCtoPARequests", ReplyAction="http://tempuri.org/IHubService/SearchCtoPARequestsResponse")]
    HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult SearchCtoPARequests(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/SearchCtoPARequests", ReplyAction="http://tempuri.org/IHubService/SearchCtoPARequestsResponse")]
    System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult> SearchCtoPARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/HandlePARequestChanged", ReplyAction="http://tempuri.org/IHubService/HandlePARequestChangedResponse")]
    HubService2.MethodResult HandlePARequestChanged(HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHubService/HandlePARequestChanged", ReplyAction="http://tempuri.org/IHubService/HandlePARequestChangedResponse")]
    System.Threading.Tasks.Task<HubService2.MethodResult> HandlePARequestChangedAsync(HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory);
    */ 
    #endregion
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHubServiceChannel : IHubService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HubServiceClient : System.ServiceModel.ClientBase<IHubService>, IHubService
{
    
    public HubServiceClient()
    {
    }
    
    public HubServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HubServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HubServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HubServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public HubService2.CheckPatientResult CheckPatient(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.CheckPatient(pat, idLpu, guid, idHistory);
    }
    
    public System.Threading.Tasks.Task<HubService2.CheckPatientResult> CheckPatientAsync(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.CheckPatientAsync(pat, idLpu, guid, idHistory);
    }

    public HubService2.GetAvaibleAppointmentsResult GetAvaibleAppointments(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetAvaibleAppointments(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetAvaibleAppointmentsResult> GetAvaibleAppointmentsAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetAvaibleAppointmentsAsync(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
    }

    public HubService2.SetAppointmentResult SetAppointment(string idAppointment, int idLpu, string idPat, string doctorsReferral, HubService2.SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.SetAppointment(idAppointment, idLpu, idPat, doctorsReferral, attachedReferral, idAppointmentPrev, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.SetAppointmentResult> SetAppointmentAsync(string idAppointment, int idLpu, string idPat, string doctorsReferral, HubService2.SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.SetAppointmentAsync(idAppointment, idLpu, idPat, doctorsReferral, attachedReferral, idAppointmentPrev, guid, idHistory);
    }


    public HubService2.GetDoctorListResult GetDoctorList(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetDoctorList(idSpesiality, idLpu, idPat, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetDoctorListResult> GetDoctorListAsync(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetDoctorListAsync(idSpesiality, idLpu, idPat, guid, idHistory);
    }

    public HubService2.GetDoctorList2Result GetDoctorList2(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetDoctorList2(idLpu, idPat, idPosition, fedIdPosition, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetDoctorList2Result> GetDoctorList2Async(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetDoctorList2Async(idLpu, idPat, idPosition, fedIdPosition, guid, idHistory);
    }

    public HubService2.GetSpesialityListResult GetSpesialityList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetSpesialityList(idLpu, idPat, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetSpesialityListResult> GetSpesialityListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetSpesialityListAsync(idLpu, idPat, guid, idHistory);
    }

    public HubService2.GetPositionListResult GetPositionList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetPositionList(idLpu, idPat, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetPositionListResult> GetPositionListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetPositionListAsync(idLpu, idPat, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.CreateClaimForRefusalResult> CreateClaimForRefusalAsync(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.CreateClaimForRefusalAsync(idLpu, idPat, idAppointment, guid, idHistory);
    }

    public HubService2.GetPatientHistoryResult GetPatientHistory(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetPatientHistory(idLpu, idPat, guid, idHistory);
    }

    public System.Threading.Tasks.Task<HubService2.GetPatientHistoryResult> GetPatientHistoryAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.GetPatientHistoryAsync(idLpu, idPat, guid, idHistory);
    }

    public HubService2.SendNotificationAboutAppointmentResult SendNotificationAboutAppointment(HubService2.Doctor5 doctor, HubService2.Spesiality spesiality, int idLpu, HubService2.Patient patient, HubService2.Appointment appointment, string doctorsReferal, HubService2.AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition)
    {
        return base.Channel.SendNotificationAboutAppointment(doctor, spesiality, idLpu, patient, appointment, doctorsReferal, appointmentSource, guid, member, idHistory, services, fedIdPosition);
    }

    public System.Threading.Tasks.Task<HubService2.SendNotificationAboutAppointmentResult> SendNotificationAboutAppointmentAsync(HubService2.Doctor5 doctor, HubService2.Spesiality spesiality, int idLpu, HubService2.Patient patient, HubService2.Appointment appointment, string doctorsReferal, HubService2.AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition)
    {
        return base.Channel.SendNotificationAboutAppointmentAsync(doctor, spesiality, idLpu, patient, appointment, doctorsReferal, appointmentSource, guid, member, idHistory, services, fedIdPosition);
    }

    public HubService2.SendNotificationAboutAppointmentStatusResult SendNotificationAboutAppointmentStatus(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, HubService2.AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason)
    {
        return base.Channel.SendNotificationAboutAppointmentStatus(idNotification, idLpu, idPat, idAppointment, doctorsReferral, status, eventDatetime, guid, idHistory, registryArea, appointmentReason);
    }

    public System.Threading.Tasks.Task<HubService2.SendNotificationAboutAppointmentStatusResult> SendNotificationAboutAppointmentStatusAsync(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, HubService2.AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason)
    {
        return base.Channel.SendNotificationAboutAppointmentStatusAsync(idNotification, idLpu, idPat, idAppointment, doctorsReferral, status, eventDatetime, guid, idHistory, registryArea, appointmentReason);
    }

    public HubService2.CreateClaimForRefusalResult CreateClaimForRefusal(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory)
    {
        return base.Channel.CreateClaimForRefusal(idLpu, idPat, idAppointment, guid, idHistory);
    }

    #region Не используется
    /*
public HubService2.CheckReferralResult CheckReferral(string doctorsReferral, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.CheckReferral(doctorsReferral, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.CheckReferralResult> CheckReferralAsync(string doctorsReferral, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.CheckReferralAsync(doctorsReferral, guid, idHistory);
}

public HubService2.SearchTop10PatientResult SearchTop10Patient(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchTop10Patient(pat, idLpu, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.SearchTop10PatientResult> SearchTop10PatientAsync(HubService2.Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchTop10PatientAsync(pat, idLpu, guid, idHistory);
}

public HubService2.AddNewPatientResult AddNewPatient(HubService2.Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.AddNewPatient(patient, idLpu, approvedByTfoms, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.AddNewPatientResult> AddNewPatientAsync(HubService2.Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.AddNewPatientAsync(patient, idLpu, approvedByTfoms, guid, idHistory);
}

public HubService2.GetDocListFullTreeResult GetDocListFullTree(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetDocListFullTree(idLpu, idPat, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetDocListFullTreeResult> GetDocListFullTreeAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetDocListFullTreeAsync(idLpu, idPat, guid, idHistory);
}

public HubService2.InspectDoctorsReferalResult InspectDoctorsReferal(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.InspectDoctorsReferal(idLpu, doctorsReferal, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.InspectDoctorsReferalResult> InspectDoctorsReferalAsync(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.InspectDoctorsReferalAsync(idLpu, doctorsReferal, guid, idHistory);
}

public HubService2.InspectDoctorsReferral2Result InspectDoctorsReferral2(System.Nullable<int> idLpu, string doctorsReferal, string surname, HubService2.SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.InspectDoctorsReferral2(idLpu, doctorsReferal, surname, attachedReferral, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.InspectDoctorsReferral2Result> InspectDoctorsReferral2Async(System.Nullable<int> idLpu, string doctorsReferal, string surname, HubService2.SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.InspectDoctorsReferral2Async(idLpu, doctorsReferal, surname, attachedReferral, guid, idHistory);
}

public HubService2.GetAvaibleAppointmentsResult GetAppointmentsDemandDoctorsReferal(string idDoc, int idLpu, string idPat, HubService2.AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAppointmentsDemandDoctorsReferal(idDoc, idLpu, idPat, appType, startVisit, endVisit, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetAvaibleAppointmentsResult> GetAppointmentsDemandDoctorsReferalAsync(string idDoc, int idLpu, string idPat, HubService2.AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAppointmentsDemandDoctorsReferalAsync(idDoc, idLpu, idPat, appType, startVisit, endVisit, guid, idHistory);
}

public HubService2.GetAvailableDatesResult GetAvailableDates(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableDates(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetAvailableDatesResult> GetAvailableDatesAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableDatesAsync(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
}

public HubService2.GetAvailableDoctorsResult GetAvailableDoctors(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableDoctors(idLpu, idPat, idSpeciality, ferIdSpeciality, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetAvailableDoctorsResult> GetAvailableDoctorsAsync(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableDoctorsAsync(idLpu, idPat, idSpeciality, ferIdSpeciality, guid, idHistory);
}

public HubService2.GetLPUListResult GetLPUList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLPUList(idDistrict, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetLPUListResult> GetLPUListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLPUListAsync(idDistrict, guid, idHistory);
}

public HubService2.GetOrgListResult GetOrgList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetOrgList(idDistrict, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetOrgListResult> GetOrgListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetOrgListAsync(idDistrict, guid, idHistory);
}


public HubService2.LpuListToRfiszResult GetLpuToRFSZIList(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLpuToRFSZIList(guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.LpuListToRfiszResult> GetLpuToRFSZIListAsync(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLpuToRFSZIListAsync(guid, idHistory);
}

public HubService2.DistrictResult GetDistrictList(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetDistrictList(guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.DistrictResult> GetDistrictListAsync(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetDistrictListAsync(guid, idHistory);
}

public HubService2.GetWorkingTimeResult GetWorkingTime(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetWorkingTime(idDoc, idLpu, visitStart, visitEnd, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetWorkingTimeResult> GetWorkingTimeAsync(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetWorkingTimeAsync(idDoc, idLpu, visitStart, visitEnd, guid, idHistory);
}

public HubService2.GetFullInfoByIdResult GetFullInfoById(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetFullInfoById(idDoc, idLpu, idPat, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetFullInfoByIdResult> GetFullInfoByIdAsync(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetFullInfoByIdAsync(idDoc, idLpu, idPat, guid, idHistory);
}

public HubService2.UpdatePhoneByIdPatResult UpdatePhoneByIdPat(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.UpdatePhoneByIdPat(idLpu, idPat, homePhone, cellPhone, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.UpdatePhoneByIdPatResult> UpdatePhoneByIdPatAsync(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.UpdatePhoneByIdPatAsync(idLpu, idPat, homePhone, cellPhone, guid, idHistory);
}

public HubService2.GetHubUserByGuidResult GetHubUserByGuid(string usersGuid, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetHubUserByGuid(usersGuid, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetHubUserByGuidResult> GetHubUserByGuidAsync(string usersGuid, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetHubUserByGuidAsync(usersGuid, guid, idHistory);
}

public HubService2.GetErrorListResult GetErrorList(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetErrorList(guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetErrorListResult> GetErrorListAsync(string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetErrorListAsync(guid, idHistory);
}

public HubService2.SetWaitingListResult SetWaitingList(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, HubService2.RulesOfWaitingList rule, HubService2.ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SetWaitingList(idDoc, nameDoc, idSpesiality, nameSpesiality, idLpu, rule, claim, idPat, namePat, birthday, phone, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.SetWaitingListResult> SetWaitingListAsync(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, HubService2.RulesOfWaitingList rule, HubService2.ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SetWaitingListAsync(idDoc, nameDoc, idSpesiality, nameSpesiality, idLpu, rule, claim, idPat, namePat, birthday, phone, guid, idHistory);
}

public HubService2.GetStatusAnalysisResult GetStatusAnalysis(long idAnalysis, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetStatusAnalysis(idAnalysis, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetStatusAnalysisResult> GetStatusAnalysisAsync(long idAnalysis, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetStatusAnalysisAsync(idAnalysis, guid, idHistory);
}



public HubService2.GetTodayAppointmentResult GetTodayAppointments(string guid)
{
    return base.Channel.GetTodayAppointments(guid);
}

public System.Threading.Tasks.Task<HubService2.GetTodayAppointmentResult> GetTodayAppointmentsAsync(string guid)
{
    return base.Channel.GetTodayAppointmentsAsync(guid);
}

public HubService2.LpuInformationResult GetLPUInfo(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLPUInfo(idLpu, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.LpuInformationResult> GetLPUInfoAsync(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetLPUInfoAsync(idLpu, guid, idHistory);
}

public HubService2.GetPatientsAreasResult GetPatientsAreas(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetPatientsAreas(idLpu, idPat, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.GetPatientsAreasResult> GetPatientsAreasAsync(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetPatientsAreasAsync(idLpu, idPat, guid, idHistory);
}

public HubService2.CheckInResult CheckIn(string idAppointment)
{
    return base.Channel.CheckIn(idAppointment);
}

public System.Threading.Tasks.Task<HubService2.CheckInResult> CheckInAsync(string idAppointment)
{
    return base.Channel.CheckInAsync(idAppointment);
}

public HubService2.GetVersionResult GetVersion()
{
    return base.Channel.GetVersion();
}

public System.Threading.Tasks.Task<HubService2.GetVersionResult> GetVersionAsync()
{
    return base.Channel.GetVersionAsync();
}

public HubService2.PatientNotificationResult PatientNotification(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, HubService2.Contact[] contacts, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.PatientNotification(idAppointment, visitStart, idLpu, idPat, contacts, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.PatientNotificationResult> PatientNotificationAsync(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, HubService2.Contact[] contacts, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.PatientNotificationAsync(idAppointment, visitStart, idLpu, idPat, contacts, guid, idHistory);
}

public HubService2.AvailableAppointmentsInfoResult GetAvailableAppointmentsInfo(HubService2.Patient2 patient2, HubService2.AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableAppointmentsInfo(patient2, info, idLpu, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.AvailableAppointmentsInfoResult> GetAvailableAppointmentsInfoAsync(HubService2.Patient2 patient2, HubService2.AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableAppointmentsInfoAsync(patient2, info, idLpu, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult GetAvailableAppointmentsByPARequest(HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableAppointmentsByPARequest(attachedPARequest, idLpu, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult> GetAvailableAppointmentsByPARequestAsync(HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.GetAvailableAppointmentsByPARequestAsync(attachedPARequest, idLpu, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.SetAppointmentByPARequestResult SetAppointmentByPARequest(string idAppointment, HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SetAppointmentByPARequest(idAppointment, attachedPARequest, idAppointmentPrev, idLpu, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SetAppointmentByPARequestResult> SetAppointmentByPARequestAsync(string idAppointment, HubService2.ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SetAppointmentByPARequestAsync(idAppointment, attachedPARequest, idAppointmentPrev, idLpu, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.RegisterPARequestResult RegisterPARequest(HubService2.ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.RegisterPARequest(request, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.RegisterPARequestResult> RegisterPARequestAsync(HubService2.ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.RegisterPARequestAsync(request, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.CancelPARequestResult CancelPARequest(HubService2.ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.CancelPARequest(request, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.CancelPARequestResult> CancelPARequestAsync(HubService2.ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.CancelPARequestAsync(request, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsResult SearchActivePARequests(HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchActivePARequests(filter, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsResult> SearchActivePARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchActivePARequestsAsync(filter, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult SearchPARequests(HubService2.ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchPARequests(filter, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchPARequestsResult> SearchPARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchPARequestsAsync(filter, guid, idHistory);
}

public HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult SearchCtoPARequests(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchCtoPARequests(filter, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsResult> SearchCtoPARequestsAsync(HubService2.ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.SearchCtoPARequestsAsync(filter, guid, idHistory);
}

public HubService2.MethodResult HandlePARequestChanged(HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.HandlePARequestChanged(info, guid, idHistory);
}

public System.Threading.Tasks.Task<HubService2.MethodResult> HandlePARequestChangedAsync(HubService2.ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory)
{
    return base.Channel.HandlePARequestChangedAsync(info, guid, idHistory);
}
*/ 
    #endregion
}
