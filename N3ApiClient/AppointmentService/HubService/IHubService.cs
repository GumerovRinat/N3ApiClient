using N3ApiClient.AppointmentService.DataContract.HubService2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace N3ApiClient.AppointmentService.DataContract.HubService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IHubService")]
    public interface IHubService
    {

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/CheckPatient", ReplyAction = "http://tempuri.org/IHubService/CheckPatientResponse")]
        CheckPatientResult CheckPatient(Patient pat, int idLpu, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetSpesialityList", ReplyAction = "http://tempuri.org/IHubService/GetSpesialityListResponse")]
        GetSpesialityListResult GetSpesialityList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList", ReplyAction = "http://tempuri.org/IHubService/GetDoctorListResponse")]
        GetDoctorListResult GetDoctorList(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetDoctorList2", ReplyAction = "http://tempuri.org/IHubService/GetDoctorList2Response")]
        GetDoctorList2Result GetDoctorList2(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetAvaibleAppointments", ReplyAction = "http://tempuri.org/IHubService/GetAvaibleAppointmentsResponse")]
        GetAvaibleAppointmentsResult GetAvaibleAppointments(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SetAppointment", ReplyAction = "http://tempuri.org/IHubService/SetAppointmentResponse")]
        SetAppointmentResult SetAppointment(string idAppointment, int idLpu, string idPat, string doctorsReferral,SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPositionList", ReplyAction = "http://tempuri.org/IHubService/GetPositionListResponse")]
        GetPositionListResult GetPositionList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/GetPatientHistory", ReplyAction = "http://tempuri.org/IHubService/GetPatientHistoryResponse")]
        GetPatientHistoryResult GetPatientHistory(int idLpu, string idPat, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/CreateClaimForRefusal", ReplyAction = "http://tempuri.org/IHubService/CreateClaimForRefusalResponse")]
        CreateClaimForRefusalResult CreateClaimForRefusal(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointment", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentResponse")]
        SendNotificationAboutAppointmentResult SendNotificationAboutAppointment(Doctor5 doctor, Spesiality spesiality, int idLpu, Patient patient, Appointment appointment, string doctorsReferal, AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition);

        /// <remarks/>
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatus", ReplyAction = "http://tempuri.org/IHubService/SendNotificationAboutAppointmentStatusResponse")]
        SendNotificationAboutAppointmentStatusResult SendNotificationAboutAppointmentStatus(
                    System.Nullable<long> idNotification,
                    System.Nullable<int> idLpu,
                    string idPat,
                    string idAppointment,
                    string doctorsReferral,
                    AppointmentStatusType status,
                    System.DateTime eventDatetime,
                    string guid,
                    System.Nullable<int> idHistory,
                    string registryArea,
                    string appointmentReason);

        #region Not impliment
        /*
    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/CheckReferral", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    CheckReferralResult CheckReferral([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string doctorsReferral, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SearchTop10Patient", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SearchTop10PatientResult SearchTop10Patient([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Patient pat, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/AddNewPatient", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    AddNewPatientResult AddNewPatient([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Patient patient, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<bool> approvedByTfoms, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool approvedByTfomsSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetDocListFullTree", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetDocListFullTreeResult GetDocListFullTree(int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/InspectDoctorsReferal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    InspectDoctorsReferalResult InspectDoctorsReferal(int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string doctorsReferal, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/InspectDoctorsReferral2", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    InspectDoctorsReferral2Result InspectDoctorsReferral2([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string doctorsReferal, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string surname, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] SearchOneDirectionResult attachedReferral, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetAppointmentsDemandDoctorsReferal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetAvaibleAppointmentsResult GetAppointmentsDemandDoctorsReferal([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idDoc, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, AppointmentType appType, [System.Xml.Serialization.XmlIgnoreAttribute()] bool appTypeSpecified, System.DateTime startVisit, [System.Xml.Serialization.XmlIgnoreAttribute()] bool startVisitSpecified, System.DateTime endVisit, [System.Xml.Serialization.XmlIgnoreAttribute()] bool endVisitSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetAvailableDates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetAvailableDatesResult GetAvailableDates([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idDoc, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, System.DateTime visitStart, [System.Xml.Serialization.XmlIgnoreAttribute()] bool visitStartSpecified, System.DateTime visitEnd, [System.Xml.Serialization.XmlIgnoreAttribute()] bool visitEndSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetAvailableDoctors", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetAvailableDoctorsResult GetAvailableDoctors(int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idSpeciality, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ferIdSpeciality, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetLPUList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetLPUListResult GetLPUList([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idDistrict, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idDistrictSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetOrgList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetOrgListResult GetOrgList([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idDistrict, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idDistrictSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetLpuToRFSZIList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    LpuListToRfiszResult GetLpuToRFSZIList([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetDistrictList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    DistrictResult GetDistrictList([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetWorkingTime", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetWorkingTimeResult GetWorkingTime([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idDoc, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, System.DateTime visitStart, [System.Xml.Serialization.XmlIgnoreAttribute()] bool visitStartSpecified, System.DateTime visitEnd, [System.Xml.Serialization.XmlIgnoreAttribute()] bool visitEndSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetFullInfoById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetFullInfoByIdResult GetFullInfoById([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idDoc, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/UpdatePhoneByIdPat", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    UpdatePhoneByIdPatResult UpdatePhoneByIdPat(int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string homePhone, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string cellPhone, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetHubUserByGuid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetHubUserByGuidResult GetHubUserByGuid([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string usersGuid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetErrorList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetErrorListResult GetErrorList([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SetWaitingList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SetWaitingListResult SetWaitingList(
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idDoc, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nameDoc, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idSpesiality, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nameSpesiality, 
                int idLpu, 
                [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RulesOfWaitingList rule, 
                ClaimToWaitingListType claim, 
                [System.Xml.Serialization.XmlIgnoreAttribute()] bool claimSpecified, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string namePat, 
                System.DateTime birthday, 
                [System.Xml.Serialization.XmlIgnoreAttribute()] bool birthdaySpecified, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string phone, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, 
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetStatusAnalysis", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetStatusAnalysisResult GetStatusAnalysis(long idAnalysis, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idAnalysisSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetTodayAppointments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetTodayAppointmentResult GetTodayAppointments([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetLPUInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    LpuInformationResult GetLPUInfo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetPatientsAreas", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetPatientsAreasResult GetPatientsAreas([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/CheckIn", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    CheckInResult CheckIn([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idAppointment);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetVersionResult GetVersion();

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/PatientNotification", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    PatientNotificationResult PatientNotification([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idAppointment, System.DateTime visitStart, [System.Xml.Serialization.XmlIgnoreAttribute()] bool visitStartSpecified, int idLpu, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idPat, [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)] [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/HubService2")] Contact[] contacts, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetAvailableAppointmentsInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    AvailableAppointmentsInfoResult GetAvailableAppointmentsInfo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Patient2 patient2, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] AppointmentInfo info, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/GetAvailableAppointmentsByPARequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    GetAvailableAppointmentsByPARequestResult GetAvailableAppointmentsByPARequest([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ActivePARequestInfo attachedPARequest, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SetAppointmentByPARequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SetAppointmentByPARequestResult SetAppointmentByPARequest([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idAppointment, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ActivePARequestInfo attachedPARequest, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string idAppointmentPrev, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idLpu, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idLpuSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/RegisterPARequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    RegisterPARequestResult RegisterPARequest([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RegisterPARequestRequest request, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/CancelPARequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    CancelPARequestResult CancelPARequest([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CancelPARequestRequest request, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SearchActivePARequests", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SearchActivePARequestsResult SearchActivePARequests([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] SearchActivePARequestsRequest filter, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SearchPARequests", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SearchPARequestsResult SearchPARequests([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] SearchPARequestsRequest filter, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/SearchCtoPARequests", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    SearchCtoPARequestsResult SearchCtoPARequests([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] SearchCtoPARequestsRequest filter, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);

    /// <remarks/>
    [System.Web.Services.WebMethodAttribute()]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHubService/HandlePARequestChanged", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    MethodResult HandlePARequestChanged([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] SearchPARequestInfo info, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string guid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> idHistory, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool idHistorySpecified);
    */
        #endregion
    }

}