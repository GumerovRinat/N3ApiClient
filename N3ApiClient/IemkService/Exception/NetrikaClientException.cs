using N3ApiClient.IemkService.DataContracts.N3.EMK.Dto.Common;
using System;
using System.ServiceModel;

namespace N3ApiClient.IemkService.Exceptions
{
    public class NetrikaClientException : Exception
    {
        private string _errorMessage;

        public NetrikaClientException(object exception)
        {
            InnerException = exception;
            SetException(exception);
        }

        private void SetException(object exception)
        {
            _errorMessage = "";
            if (exception is FaultException<RequestFault>)
            {
                ErrorMessage = ((FaultException<RequestFault>)exception).Detail.Message + " (" + ((FaultException<RequestFault>)exception).Detail.PropertyName + "); ";
            }
            if (exception is FaultException<RequestFault[]>)
            {
                for (int i = 0; i < ((FaultException<RequestFault[]>)exception).Detail.Length; i++)
                {
                    ErrorMessage = GetFaultMessage(((FaultException<RequestFault[]>)exception).Detail[i]);
                }
            }
            if (exception is FaultException<RequestWarning[]>)
            {
                for (int i = 0; i < ((FaultException<RequestWarning[]>)exception).Detail.Length; i++)
                {
                    WarningMessage = GetWarningMessage(((FaultException<RequestWarning[]>)exception).Detail[i]);
                }
            }
            else
            {
                InnerException = exception;
            }
        }

        private string GetFaultMessage(RequestFault requestFault)
        {
            if (requestFault.Errors.Length > 0)
            {
                for (int i = 0; i < requestFault.Errors.Length; i++)
                {
                    GetFaultMessage(requestFault.Errors[i]);
                }
            }
            _errorMessage += requestFault.Message + " (" + requestFault.PropertyName + "); ";
            return _errorMessage;
        }

        private string GetWarningMessage(RequestWarning requestWarning)
        {
            if (requestWarning.Warnings.Length > 0)
            {
                for (int i = 0; i < requestWarning.Warnings.Length; i++)
                {
                    GetWarningMessage(requestWarning.Warnings[i]);
                }
            }
            _errorMessage += requestWarning.Message + " (" + requestWarning.PropertyName + "); ";
            return _errorMessage;
        }

        public new object InnerException { get; private set; }

        public string ErrorMessage { get; private set;  }

        public string WarningMessage { get; private set; }
    }
}
