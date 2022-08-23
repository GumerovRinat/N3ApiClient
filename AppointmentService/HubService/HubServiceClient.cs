using N3ApiClient.AppointmentService.DataContract.HubService;
using N3ApiClient.AppointmentService.DataContract.HubService2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.HubService.Client
{
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

        public CheckPatientResult CheckPatient(Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CheckPatient(pat, idLpu, guid, idHistory);
        }

        public GetAvaibleAppointmentsResult GetAvaibleAppointments(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvaibleAppointments(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
        }

        public SetAppointmentResult SetAppointment(string idAppointment, int idLpu, string idPat, string doctorsReferral, SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetAppointment(idAppointment, idLpu, idPat, doctorsReferral, attachedReferral, idAppointmentPrev, guid, idHistory);
        }

        public GetPositionListResult GetPositionList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPositionList(idLpu, idPat, guid, idHistory);
        }

        public GetSpesialityListResult GetSpesialityList(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetSpesialityList(idLpu, idPat, guid, idHistory);
        }

        public GetDoctorList2Result GetDoctorList2(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDoctorList2(idLpu, idPat, idPosition, fedIdPosition, guid, idHistory);
        }

        public GetDoctorListResult GetDoctorList(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDoctorList(idSpesiality, idLpu, idPat, guid, idHistory);
        }

        public SendNotificationAboutAppointmentStatusResult SendNotificationAboutAppointmentStatus(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason)
        {
            return base.Channel.SendNotificationAboutAppointmentStatus(idNotification, idLpu, idPat, idAppointment, doctorsReferral, status, eventDatetime, guid, idHistory, registryArea, appointmentReason);
        }

        public GetPatientHistoryResult GetPatientHistory(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPatientHistory(idLpu, idPat, guid, idHistory);
        }

        public CreateClaimForRefusalResult CreateClaimForRefusal(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CreateClaimForRefusal(idLpu, idPat, idAppointment, guid, idHistory);
        }

        public SendNotificationAboutAppointmentResult SendNotificationAboutAppointment(Doctor5 doctor, Spesiality spesiality, int idLpu, Patient patient, Appointment appointment, string doctorsReferal, AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition)
        {
            return base.Channel.SendNotificationAboutAppointment(doctor, spesiality, idLpu, patient, appointment, doctorsReferal, appointmentSource, guid, member, idHistory, services, fedIdPosition);
        }

        #region Not Implement

        /*
        public System.Threading.Tasks.Task<CheckPatientResult> CheckPatientAsync(Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CheckPatientAsync(pat, idLpu, guid, idHistory);
        }

        public CheckReferralResult CheckReferral(string doctorsReferral, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CheckReferral(doctorsReferral, guid, idHistory);
        }

        public System.Threading.Tasks.Task<CheckReferralResult> CheckReferralAsync(string doctorsReferral, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CheckReferralAsync(doctorsReferral, guid, idHistory);
        }

        public SearchTop10PatientResult SearchTop10Patient(Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchTop10Patient(pat, idLpu, guid, idHistory);
        }

        public System.Threading.Tasks.Task<SearchTop10PatientResult> SearchTop10PatientAsync(Patient pat, int idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchTop10PatientAsync(pat, idLpu, guid, idHistory);
        }

        public AddNewPatientResult AddNewPatient(Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.AddNewPatient(patient, idLpu, approvedByTfoms, guid, idHistory);
        }

        public System.Threading.Tasks.Task<AddNewPatientResult> AddNewPatientAsync(Patient patient, int idLpu, System.Nullable<bool> approvedByTfoms, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.AddNewPatientAsync(patient, idLpu, approvedByTfoms, guid, idHistory);
        }

        public GetDocListFullTreeResult GetDocListFullTree(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDocListFullTree(idLpu, idPat, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetDocListFullTreeResult> GetDocListFullTreeAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDocListFullTreeAsync(idLpu, idPat, guid, idHistory);
        }

        public InspectDoctorsReferalResult InspectDoctorsReferal(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.InspectDoctorsReferal(idLpu, doctorsReferal, guid, idHistory);
        }

        public System.Threading.Tasks.Task<InspectDoctorsReferalResult> InspectDoctorsReferalAsync(int idLpu, string doctorsReferal, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.InspectDoctorsReferalAsync(idLpu, doctorsReferal, guid, idHistory);
        }

        public InspectDoctorsReferral2Result InspectDoctorsReferral2(System.Nullable<int> idLpu, string doctorsReferal, string surname, SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.InspectDoctorsReferral2(idLpu, doctorsReferal, surname, attachedReferral, guid, idHistory);
        }

        public System.Threading.Tasks.Task<InspectDoctorsReferral2Result> InspectDoctorsReferral2Async(System.Nullable<int> idLpu, string doctorsReferal, string surname, SearchOneDirectionResult attachedReferral, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.InspectDoctorsReferral2Async(idLpu, doctorsReferal, surname, attachedReferral, guid, idHistory);
        }

        public GetAvaibleAppointmentsResult GetAppointmentsDemandDoctorsReferal(string idDoc, int idLpu, string idPat, AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAppointmentsDemandDoctorsReferal(idDoc, idLpu, idPat, appType, startVisit, endVisit, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetAvaibleAppointmentsResult> GetAppointmentsDemandDoctorsReferalAsync(string idDoc, int idLpu, string idPat, AppointmentType appType, System.DateTime startVisit, System.DateTime endVisit, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAppointmentsDemandDoctorsReferalAsync(idDoc, idLpu, idPat, appType, startVisit, endVisit, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetAvaibleAppointmentsResult> GetAvaibleAppointmentsAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvaibleAppointmentsAsync(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
        }

        public System.Threading.Tasks.Task<SetAppointmentResult> SetAppointmentAsync(string idAppointment, int idLpu, string idPat, string doctorsReferral, SearchOneDirectionResult attachedReferral, string idAppointmentPrev, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetAppointmentAsync(idAppointment, idLpu, idPat, doctorsReferral, attachedReferral, idAppointmentPrev, guid, idHistory);
        }

        public GetAvailableDatesResult GetAvailableDates(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableDates(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetAvailableDatesResult> GetAvailableDatesAsync(string idDoc, int idLpu, string idPat, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableDatesAsync(idDoc, idLpu, idPat, visitStart, visitEnd, guid, idHistory);
        }


        public System.Threading.Tasks.Task<GetDoctorListResult> GetDoctorListAsync(string idSpesiality, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDoctorListAsync(idSpesiality, idLpu, idPat, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetDoctorList2Result> GetDoctorList2Async(int idLpu, string idPat, string idPosition, string fedIdPosition, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDoctorList2Async(idLpu, idPat, idPosition, fedIdPosition, guid, idHistory);
        }

        public GetAvailableDoctorsResult GetAvailableDoctors(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableDoctors(idLpu, idPat, idSpeciality, ferIdSpeciality, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetAvailableDoctorsResult> GetAvailableDoctorsAsync(int idLpu, string idPat, string idSpeciality, string ferIdSpeciality, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableDoctorsAsync(idLpu, idPat, idSpeciality, ferIdSpeciality, guid, idHistory);
        }

        public GetLPUListResult GetLPUList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLPUList(idDistrict, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetLPUListResult> GetLPUListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLPUListAsync(idDistrict, guid, idHistory);
        }

        public GetOrgListResult GetOrgList(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetOrgList(idDistrict, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetOrgListResult> GetOrgListAsync(System.Nullable<int> idDistrict, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetOrgListAsync(idDistrict, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetSpesialityListResult> GetSpesialityListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetSpesialityListAsync(idLpu, idPat, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetPositionListResult> GetPositionListAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPositionListAsync(idLpu, idPat, guid, idHistory);
        }

        public LpuListToRfiszResult GetLpuToRFSZIList(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLpuToRFSZIList(guid, idHistory);
        }

        public System.Threading.Tasks.Task<LpuListToRfiszResult> GetLpuToRFSZIListAsync(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLpuToRFSZIListAsync(guid, idHistory);
        }

        public DistrictResult GetDistrictList(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDistrictList(guid, idHistory);
        }

        public System.Threading.Tasks.Task<DistrictResult> GetDistrictListAsync(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetDistrictListAsync(guid, idHistory);
        }

        public GetWorkingTimeResult GetWorkingTime(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetWorkingTime(idDoc, idLpu, visitStart, visitEnd, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetWorkingTimeResult> GetWorkingTimeAsync(string idDoc, int idLpu, System.DateTime visitStart, System.DateTime visitEnd, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetWorkingTimeAsync(idDoc, idLpu, visitStart, visitEnd, guid, idHistory);
        }

        public GetFullInfoByIdResult GetFullInfoById(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetFullInfoById(idDoc, idLpu, idPat, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetFullInfoByIdResult> GetFullInfoByIdAsync(string idDoc, int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetFullInfoByIdAsync(idDoc, idLpu, idPat, guid, idHistory);
        }



        public System.Threading.Tasks.Task<CreateClaimForRefusalResult> CreateClaimForRefusalAsync(int idLpu, string idPat, string idAppointment, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CreateClaimForRefusalAsync(idLpu, idPat, idAppointment, guid, idHistory);
        }


        public System.Threading.Tasks.Task<GetPatientHistoryResult> GetPatientHistoryAsync(int idLpu, string idPat, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPatientHistoryAsync(idLpu, idPat, guid, idHistory);
        }

        public UpdatePhoneByIdPatResult UpdatePhoneByIdPat(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.UpdatePhoneByIdPat(idLpu, idPat, homePhone, cellPhone, guid, idHistory);
        }

        public System.Threading.Tasks.Task<UpdatePhoneByIdPatResult> UpdatePhoneByIdPatAsync(int idLpu, string idPat, string homePhone, string cellPhone, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.UpdatePhoneByIdPatAsync(idLpu, idPat, homePhone, cellPhone, guid, idHistory);
        }

        public GetHubUserByGuidResult GetHubUserByGuid(string usersGuid, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetHubUserByGuid(usersGuid, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetHubUserByGuidResult> GetHubUserByGuidAsync(string usersGuid, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetHubUserByGuidAsync(usersGuid, guid, idHistory);
        }

        public GetErrorListResult GetErrorList(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetErrorList(guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetErrorListResult> GetErrorListAsync(string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetErrorListAsync(guid, idHistory);
        }

        public SetWaitingListResult SetWaitingList(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, RulesOfWaitingList rule, ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetWaitingList(idDoc, nameDoc, idSpesiality, nameSpesiality, idLpu, rule, claim, idPat, namePat, birthday, phone, guid, idHistory);
        }

        public System.Threading.Tasks.Task<SetWaitingListResult> SetWaitingListAsync(string idDoc, string nameDoc, string idSpesiality, string nameSpesiality, int idLpu, RulesOfWaitingList rule, ClaimToWaitingListType claim, string idPat, string namePat, System.DateTime birthday, string phone, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetWaitingListAsync(idDoc, nameDoc, idSpesiality, nameSpesiality, idLpu, rule, claim, idPat, namePat, birthday, phone, guid, idHistory);
        }

        public GetStatusAnalysisResult GetStatusAnalysis(long idAnalysis, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetStatusAnalysis(idAnalysis, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetStatusAnalysisResult> GetStatusAnalysisAsync(long idAnalysis, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetStatusAnalysisAsync(idAnalysis, guid, idHistory);
        }

        public System.Threading.Tasks.Task<SendNotificationAboutAppointmentResult> SendNotificationAboutAppointmentAsync(Doctor5 doctor, Spesiality spesiality, int idLpu, Patient patient, Appointment appointment, string doctorsReferal, AppointmentSourceType appointmentSource, string guid, System.Nullable<System.Guid> member, System.Nullable<int> idHistory, string[] services, string fedIdPosition)
        {
            return base.Channel.SendNotificationAboutAppointmentAsync(doctor, spesiality, idLpu, patient, appointment, doctorsReferal, appointmentSource, guid, member, idHistory, services, fedIdPosition);
        }


        public System.Threading.Tasks.Task<SendNotificationAboutAppointmentStatusResult> SendNotificationAboutAppointmentStatusAsync(System.Nullable<long> idNotification, System.Nullable<int> idLpu, string idPat, string idAppointment, string doctorsReferral, AppointmentStatusType status, System.DateTime eventDatetime, string guid, System.Nullable<int> idHistory, string registryArea, string appointmentReason)
        {
            return base.Channel.SendNotificationAboutAppointmentStatusAsync(idNotification, idLpu, idPat, idAppointment, doctorsReferral, status, eventDatetime, guid, idHistory, registryArea, appointmentReason);
        }

        public GetTodayAppointmentResult GetTodayAppointments(string guid)
        {
            return base.Channel.GetTodayAppointments(guid);
        }

        public System.Threading.Tasks.Task<GetTodayAppointmentResult> GetTodayAppointmentsAsync(string guid)
        {
            return base.Channel.GetTodayAppointmentsAsync(guid);
        }

        public LpuInformationResult GetLPUInfo(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLPUInfo(idLpu, guid, idHistory);
        }

        public System.Threading.Tasks.Task<LpuInformationResult> GetLPUInfoAsync(System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetLPUInfoAsync(idLpu, guid, idHistory);
        }

        public GetPatientsAreasResult GetPatientsAreas(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPatientsAreas(idLpu, idPat, guid, idHistory);
        }

        public System.Threading.Tasks.Task<GetPatientsAreasResult> GetPatientsAreasAsync(string idLpu, string idPat, System.Guid guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetPatientsAreasAsync(idLpu, idPat, guid, idHistory);
        }

        public CheckInResult CheckIn(string idAppointment)
        {
            return base.Channel.CheckIn(idAppointment);
        }

        public System.Threading.Tasks.Task<CheckInResult> CheckInAsync(string idAppointment)
        {
            return base.Channel.CheckInAsync(idAppointment);
        }

        public GetVersionResult GetVersion()
        {
            return base.Channel.GetVersion();
        }

        public System.Threading.Tasks.Task<GetVersionResult> GetVersionAsync()
        {
            return base.Channel.GetVersionAsync();
        }

        public PatientNotificationResult PatientNotification(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, Contact[] contacts, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.PatientNotification(idAppointment, visitStart, idLpu, idPat, contacts, guid, idHistory);
        }

        public System.Threading.Tasks.Task<PatientNotificationResult> PatientNotificationAsync(string idAppointment, System.DateTime visitStart, int idLpu, string idPat, Contact[] contacts, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.PatientNotificationAsync(idAppointment, visitStart, idLpu, idPat, contacts, guid, idHistory);
        }

        public AvailableAppointmentsInfoResult GetAvailableAppointmentsInfo(Patient2 patient2, AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableAppointmentsInfo(patient2, info, idLpu, guid, idHistory);
        }

        public System.Threading.Tasks.Task<AvailableAppointmentsInfoResult> GetAvailableAppointmentsInfoAsync(Patient2 patient2, AppointmentInfo info, string idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableAppointmentsInfoAsync(patient2, info, idLpu, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult GetAvailableAppointmentsByPARequest(ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableAppointmentsByPARequest(attachedPARequest, idLpu, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.GetAvailableAppointmentsByPARequestResult> GetAvailableAppointmentsByPARequestAsync(ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.GetAvailableAppointmentsByPARequestAsync(attachedPARequest, idLpu, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.SetAppointmentByPARequestResult SetAppointmentByPARequest(string idAppointment, ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetAppointmentByPARequest(idAppointment, attachedPARequest, idAppointmentPrev, idLpu, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.SetAppointmentByPARequestResult> SetAppointmentByPARequestAsync(string idAppointment, ContractsClasses.PostAppointment.ActivePARequestInfo attachedPARequest, string idAppointmentPrev, System.Nullable<int> idLpu, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SetAppointmentByPARequestAsync(idAppointment, attachedPARequest, idAppointmentPrev, idLpu, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.RegisterPARequestResult RegisterPARequest(ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.RegisterPARequest(request, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.RegisterPARequestResult> RegisterPARequestAsync(ContractsClasses.PostAppointment.RegisterPARequestRequest request, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.RegisterPARequestAsync(request, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.CancelPARequestResult CancelPARequest(ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CancelPARequest(request, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.CancelPARequestResult> CancelPARequestAsync(ContractsClasses.PostAppointment.CancelPARequestRequest request, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.CancelPARequestAsync(request, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.SearchActivePARequestsResult SearchActivePARequests(ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchActivePARequests(filter, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.SearchActivePARequestsResult> SearchActivePARequestsAsync(ContractsClasses.PostAppointment.SearchActivePARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchActivePARequestsAsync(filter, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.SearchPARequestsResult SearchPARequests(ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchPARequests(filter, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.SearchPARequestsResult> SearchPARequestsAsync(ContractsClasses.PostAppointment.SearchPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchPARequestsAsync(filter, guid, idHistory);
        }

        public ContractsClasses.PostAppointment.SearchCtoPARequestsResult SearchCtoPARequests(ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchCtoPARequests(filter, guid, idHistory);
        }

        public System.Threading.Tasks.Task<ContractsClasses.PostAppointment.SearchCtoPARequestsResult> SearchCtoPARequestsAsync(ContractsClasses.PostAppointment.SearchCtoPARequestsRequest filter, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.SearchCtoPARequestsAsync(filter, guid, idHistory);
        }

        public MethodResult HandlePARequestChanged(ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.HandlePARequestChanged(info, guid, idHistory);
        }

        public System.Threading.Tasks.Task<MethodResult> HandlePARequestChangedAsync(ContractsClasses.PostAppointment.SearchPARequestInfo info, string guid, System.Nullable<int> idHistory)
        {
            return base.Channel.HandlePARequestChangedAsync(info, guid, idHistory);
        }
        */ 
        #endregion
    }

}
