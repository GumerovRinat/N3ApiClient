using N3ApiClient.AppointmentService.DataContract;
using N3ApiClient.AppointmentService.DataContract.HomeCallService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.HomeCallService
{
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

        public ValidateHomeCallResult ValidateHomeCall(int idLpu, string reason, string comment, string idSession, string guid, TimeInterval[] timeIntervals, Patient homeCallPatient, Applicant applicant, Address address)
        {
            return base.Channel.ValidateHomeCall(idLpu, reason, comment, idSession, guid, timeIntervals, homeCallPatient, applicant, address);
        }

        public System.Threading.Tasks.Task<ValidateHomeCallResult> ValidateHomeCallAsync(int idLpu, string reason, string comment, string idSession, string guid, TimeInterval[] timeIntervals, Patient homeCallPatient, Applicant applicant, Address address)
        {
            return base.Channel.ValidateHomeCallAsync(idLpu, reason, comment, idSession, guid, timeIntervals, homeCallPatient, applicant, address);
        }

        public UpdateHomeCallRequestResult UpdateHomeCallRequest(string idHomeCallRequest, int homeCallStatus, string comment, string guid)
        {
            return base.Channel.UpdateHomeCallRequest(idHomeCallRequest, homeCallStatus, comment, guid);
        }

        public System.Threading.Tasks.Task<UpdateHomeCallRequestResult> UpdateHomeCallRequestAsync(string idHomeCallRequest, int homeCallStatus, string comment, string guid)
        {
            return base.Channel.UpdateHomeCallRequestAsync(idHomeCallRequest, homeCallStatus, comment, guid);
        }

        public CreateHomeCallRequestResult CreateHomeCallRequest(string idSession, int idLpu, string idSlot, string guid)
        {
            return base.Channel.CreateHomeCallRequest(idSession, idLpu, idSlot, guid);
        }

        public System.Threading.Tasks.Task<CreateHomeCallRequestResult> CreateHomeCallRequestAsync(string idSession, int idLpu, string idSlot, string guid)
        {
            return base.Channel.CreateHomeCallRequestAsync(idSession, idLpu, idSlot, guid);
        }

        public SearchHomeCallRequestsResult SearchHomeCallRequests(string guid, SearchHomeCallRequestFilter filter)
        {
            return base.Channel.SearchHomeCallRequests(guid, filter);
        }

        public System.Threading.Tasks.Task<SearchHomeCallRequestsResult> SearchHomeCallRequestsAsync(string guid, SearchHomeCallRequestFilter filter)
        {
            return base.Channel.SearchHomeCallRequestsAsync(guid, filter);
        }

        public GetHomeCallAvailableSlotsResult GetHomeCallAvailableSlots(string idSession, int idLpu, string guid, TimeInterval[] timeIntervals)
        {
            return base.Channel.GetHomeCallAvailableSlots(idSession, idLpu, guid, timeIntervals);
        }

        public System.Threading.Tasks.Task<GetHomeCallAvailableSlotsResult> GetHomeCallAvailableSlotsAsync(string idSession, int idLpu, string guid, TimeInterval[] timeIntervals)
        {
            return base.Channel.GetHomeCallAvailableSlotsAsync(idSession, idLpu, guid, timeIntervals);
        }

        public HandleHomeCallRequestChangedResult HandleHomeCallRequestChanged(string guid, HomeCallRequest homeCallRequest)
        {
            return base.Channel.HandleHomeCallRequestChanged(guid, homeCallRequest);
        }

        public System.Threading.Tasks.Task<HandleHomeCallRequestChangedResult> HandleHomeCallRequestChangedAsync(string guid, HomeCallRequest homeCallRequest)
        {
            return base.Channel.HandleHomeCallRequestChangedAsync(guid, homeCallRequest);
        }
    }

}
