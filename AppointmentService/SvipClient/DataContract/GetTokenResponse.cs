using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.Svip.DataContract
{
    [DataContract]
    public class GetTokenResponse
    {
        /// <summary>
        /// Успешность выполнения запроса
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Код результата ответа
        /// </summary>
        [DataMember(Name = "resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Данные ответа
        /// </summary>
        [DataMember(Name = "content")]
        public string Content { get; set; }
    }
}
