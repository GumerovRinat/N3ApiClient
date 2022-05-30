using N3ApiClient.AppointmentService.Svip.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.Svip
{
    public partial class SvipClient
    {
        /// <summary>
        /// Получение токена
        /// </summary>
        /// <returns>Токен</returns>
        public string GetAuthToken()
        {
            var result = Get<GetTokenResponse>("token");
            return result.Content;
        }


        public Content GetTokenStatus(string token)
        {
            var result = Get<GetSessionResponse>($"session?token={token}");
            return result.Content;
        }
    }
}
