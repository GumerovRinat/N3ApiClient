using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;


namespace N3ApiClient.AppointmentService.DataContract.HubService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AppointmentType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name = "SpecialistType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public enum SpecialistType : byte
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутстствует_неопределено = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        широкого_профиля = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        узкий = 2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AreaType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ClaimToWaitingListType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]

    public enum ClaimToWaitingListType : byte
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутствуют_свободные_талоны = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        нет_удобного_времени = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        отсутствует_специалист = 3,
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AppointmentSourceType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name = "AppointmentStatusType", Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
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
}