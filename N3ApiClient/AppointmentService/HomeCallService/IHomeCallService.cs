using N3ApiClient.AppointmentService.DataContract.HomeCallService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.DataContract
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IHomeCallService")]
    public interface IHomeCallService
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/ValidateHomeCall", ReplyAction = "http://tempuri.org/IHomeCallService/ValidateHomeCallResponse")]
        ValidateHomeCallResult ValidateHomeCall(int idLpu, string reason, string comment, string idSession, string guid, TimeInterval[] timeIntervals, Patient homeCallPatient, Applicant applicant, Address address);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/ValidateHomeCall", ReplyAction = "http://tempuri.org/IHomeCallService/ValidateHomeCallResponse")]
        System.Threading.Tasks.Task<ValidateHomeCallResult> ValidateHomeCallAsync(int idLpu, string reason, string comment, string idSession, string guid, TimeInterval[] timeIntervals, Patient homeCallPatient, Applicant applicant, Address address);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/UpdateHomeCallRequest", ReplyAction = "http://tempuri.org/IHomeCallService/UpdateHomeCallRequestResponse")]
        UpdateHomeCallRequestResult UpdateHomeCallRequest(string idHomeCallRequest, int homeCallStatus, string comment, string guid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/UpdateHomeCallRequest", ReplyAction = "http://tempuri.org/IHomeCallService/UpdateHomeCallRequestResponse")]
        System.Threading.Tasks.Task<UpdateHomeCallRequestResult> UpdateHomeCallRequestAsync(string idHomeCallRequest, int homeCallStatus, string comment, string guid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/CreateHomeCallRequest", ReplyAction = "http://tempuri.org/IHomeCallService/CreateHomeCallRequestResponse")]
        CreateHomeCallRequestResult CreateHomeCallRequest(string idSession, int idLpu, string idSlot, string guid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/CreateHomeCallRequest", ReplyAction = "http://tempuri.org/IHomeCallService/CreateHomeCallRequestResponse")]
        System.Threading.Tasks.Task<CreateHomeCallRequestResult> CreateHomeCallRequestAsync(string idSession, int idLpu, string idSlot, string guid);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/SearchHomeCallRequests", ReplyAction = "http://tempuri.org/IHomeCallService/SearchHomeCallRequestsResponse")]
        SearchHomeCallRequestsResult SearchHomeCallRequests(string guid, SearchHomeCallRequestFilter filter);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/SearchHomeCallRequests", ReplyAction = "http://tempuri.org/IHomeCallService/SearchHomeCallRequestsResponse")]
        System.Threading.Tasks.Task<SearchHomeCallRequestsResult> SearchHomeCallRequestsAsync(string guid, SearchHomeCallRequestFilter filter);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlots", ReplyAction = "http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlotsResponse")]
        GetHomeCallAvailableSlotsResult GetHomeCallAvailableSlots(string idSession, int idLpu, string guid, TimeInterval[] timeIntervals);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlots", ReplyAction = "http://tempuri.org/IHomeCallService/GetHomeCallAvailableSlotsResponse")]
        System.Threading.Tasks.Task<GetHomeCallAvailableSlotsResult> GetHomeCallAvailableSlotsAsync(string idSession, int idLpu, string guid, TimeInterval[] timeIntervals);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/HandleHomeCallRequestChanged", ReplyAction = "http://tempuri.org/IHomeCallService/HandleHomeCallRequestChangedResponse")]
        HandleHomeCallRequestChangedResult HandleHomeCallRequestChanged(string guid, HomeCallRequest homeCallRequest);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IHomeCallService/HandleHomeCallRequestChanged", ReplyAction = "http://tempuri.org/IHomeCallService/HandleHomeCallRequestChangedResponse")]
        System.Threading.Tasks.Task<HandleHomeCallRequestChangedResult> HandleHomeCallRequestChangedAsync(string guid, HomeCallRequest homeCallRequest);
    }
}
