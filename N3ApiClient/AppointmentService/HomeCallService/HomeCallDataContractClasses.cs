using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.AppointmentService.DataContract.HomeCallService
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class TimeInterval
    {

        private System.DateTime endField;

        private bool endFieldSpecified;

        private System.DateTime startField;

        private bool startFieldSpecified;

        /// <remarks/>
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndSpecified
        {
            get
            {
                return this.endFieldSpecified;
            }
            set
            {
                this.endFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class FilterLpuPatient
    {

        private int idLpuField;

        private bool idLpuFieldSpecified;

        private string idPatientField;

        /// <remarks/>
        public int IdLpu
        {
            get
            {
                return this.idLpuField;
            }
            set
            {
                this.idLpuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdLpuSpecified
        {
            get
            {
                return this.idLpuFieldSpecified;
            }
            set
            {
                this.idLpuFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdPatient
        {
            get
            {
                return this.idPatientField;
            }
            set
            {
                this.idPatientField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class SearchHomeCallRequestFilter
    {

        private TimeInterval createdDateRangeField;

        private int[] homeCallStatusesField;

        private string idDocField;

        private string idHomeCallRequestField;

        private System.Nullable<int> idLpuField;

        private bool idLpuFieldSpecified;

        private FilterLpuPatient[] idLpuAndIdPatientsField;

        private string idNsiLpuField;

        private string[] idPatientsField;

        private TimeInterval updatedDateRangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public TimeInterval CreatedDateRange
        {
            get
            {
                return this.createdDateRangeField;
            }
            set
            {
                this.createdDateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public int[] HomeCallStatuses
        {
            get
            {
                return this.homeCallStatusesField;
            }
            set
            {
                this.homeCallStatusesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdDoc
        {
            get
            {
                return this.idDocField;
            }
            set
            {
                this.idDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdHomeCallRequest
        {
            get
            {
                return this.idHomeCallRequestField;
            }
            set
            {
                this.idHomeCallRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> IdLpu
        {
            get
            {
                return this.idLpuField;
            }
            set
            {
                this.idLpuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdLpuSpecified
        {
            get
            {
                return this.idLpuFieldSpecified;
            }
            set
            {
                this.idLpuFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FilterLpuPatient[] IdLpuAndIdPatients
        {
            get
            {
                return this.idLpuAndIdPatientsField;
            }
            set
            {
                this.idLpuAndIdPatientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdNsiLpu
        {
            get
            {
                return this.idNsiLpuField;
            }
            set
            {
                this.idNsiLpuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] IdPatients
        {
            get
            {
                return this.idPatientsField;
            }
            set
            {
                this.idPatientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public TimeInterval UpdatedDateRange
        {
            get
            {
                return this.updatedDateRangeField;
            }
            set
            {
                this.updatedDateRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class HomeCallRequest
    {

        private Address addressField;

        private Applicant applicantField;

        private string commentField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private HomeCallDoctor homeCallDoctorField;

        private Patient homeCallPatientField;

        private int homeCallStatusField;

        private bool homeCallStatusFieldSpecified;

        private string idDoctorPositionField;

        private string idHomeCallRequestField;

        private int idLpuField;

        private bool idLpuFieldSpecified;

        private string idNsiLpuField;

        private string idPatField;

        private string idSessionField;

        private string memberGuidField;

        private string reasonField;

        private Slot slotField;

        private System.DateTime updatedDateField;

        private bool updatedDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Applicant Applicant
        {
            get
            {
                return this.applicantField;
            }
            set
            {
                this.applicantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreatedDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedDateSpecified
        {
            get
            {
                return this.createdDateFieldSpecified;
            }
            set
            {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public HomeCallDoctor HomeCallDoctor
        {
            get
            {
                return this.homeCallDoctorField;
            }
            set
            {
                this.homeCallDoctorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Patient HomeCallPatient
        {
            get
            {
                return this.homeCallPatientField;
            }
            set
            {
                this.homeCallPatientField = value;
            }
        }

        /// <remarks/>
        public int HomeCallStatus
        {
            get
            {
                return this.homeCallStatusField;
            }
            set
            {
                this.homeCallStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HomeCallStatusSpecified
        {
            get
            {
                return this.homeCallStatusFieldSpecified;
            }
            set
            {
                this.homeCallStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdDoctorPosition
        {
            get
            {
                return this.idDoctorPositionField;
            }
            set
            {
                this.idDoctorPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdHomeCallRequest
        {
            get
            {
                return this.idHomeCallRequestField;
            }
            set
            {
                this.idHomeCallRequestField = value;
            }
        }

        /// <remarks/>
        public int IdLpu
        {
            get
            {
                return this.idLpuField;
            }
            set
            {
                this.idLpuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdLpuSpecified
        {
            get
            {
                return this.idLpuFieldSpecified;
            }
            set
            {
                this.idLpuFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdNsiLpu
        {
            get
            {
                return this.idNsiLpuField;
            }
            set
            {
                this.idNsiLpuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdPat
        {
            get
            {
                return this.idPatField;
            }
            set
            {
                this.idPatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSession
        {
            get
            {
                return this.idSessionField;
            }
            set
            {
                this.idSessionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MemberGuid
        {
            get
            {
                return this.memberGuidField;
            }
            set
            {
                this.memberGuidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Slot Slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }

        /// <remarks/>
        public System.DateTime UpdatedDate
        {
            get
            {
                return this.updatedDateField;
            }
            set
            {
                this.updatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdatedDateSpecified
        {
            get
            {
                return this.updatedDateFieldSpecified;
            }
            set
            {
                this.updatedDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Address
    {

        private string additionalAreaField;

        private string additionalStreetField;

        private string addressLineField;

        private string apartmentField;

        private string areaField;

        private string cityField;

        private string cityAreaField;

        private string codKladrFiasField;

        private string commentField;

        private string houseField;

        private string housingField;

        private string placeField;

        private string postIndexField;

        private string regionField;

        private string streetField;

        private string structureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AdditionalArea
        {
            get
            {
                return this.additionalAreaField;
            }
            set
            {
                this.additionalAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AdditionalStreet
        {
            get
            {
                return this.additionalStreetField;
            }
            set
            {
                this.additionalStreetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Apartment
        {
            get
            {
                return this.apartmentField;
            }
            set
            {
                this.apartmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CityArea
        {
            get
            {
                return this.cityAreaField;
            }
            set
            {
                this.cityAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodKladrFias
        {
            get
            {
                return this.codKladrFiasField;
            }
            set
            {
                this.codKladrFiasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Housing
        {
            get
            {
                return this.housingField;
            }
            set
            {
                this.housingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PostIndex
        {
            get
            {
                return this.postIndexField;
            }
            set
            {
                this.postIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Structure
        {
            get
            {
                return this.structureField;
            }
            set
            {
                this.structureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Applicant
    {

        private string emailField;

        private string firstNameField;

        private string lastNameField;

        private string middleNameField;

        private string mobilePhoneField;

        private string sNILSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MobilePhone
        {
            get
            {
                return this.mobilePhoneField;
            }
            set
            {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SNILS
        {
            get
            {
                return this.sNILSField;
            }
            set
            {
                this.sNILSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HomeCallDoctorWithSlots))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class HomeCallDoctor
    {

        private string areaField;

        private string areaTypeField;

        private string commentField;

        private System.Nullable<int> countFreeParticipantIEField;

        private bool countFreeParticipantIEFieldSpecified;

        private System.Nullable<int> countFreeTicketField;

        private bool countFreeTicketFieldSpecified;

        private string idDocField;

        private System.Nullable<System.DateTime> lastDateField;

        private bool lastDateFieldSpecified;

        private string nameField;

        private System.Nullable<System.DateTime> nearestDateField;

        private bool nearestDateFieldSpecified;

        private string snilsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AreaType
        {
            get
            {
                return this.areaTypeField;
            }
            set
            {
                this.areaTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> CountFreeParticipantIE
        {
            get
            {
                return this.countFreeParticipantIEField;
            }
            set
            {
                this.countFreeParticipantIEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountFreeParticipantIESpecified
        {
            get
            {
                return this.countFreeParticipantIEFieldSpecified;
            }
            set
            {
                this.countFreeParticipantIEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> CountFreeTicket
        {
            get
            {
                return this.countFreeTicketField;
            }
            set
            {
                this.countFreeTicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountFreeTicketSpecified
        {
            get
            {
                return this.countFreeTicketFieldSpecified;
            }
            set
            {
                this.countFreeTicketFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdDoc
        {
            get
            {
                return this.idDocField;
            }
            set
            {
                this.idDocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastDate
        {
            get
            {
                return this.lastDateField;
            }
            set
            {
                this.lastDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastDateSpecified
        {
            get
            {
                return this.lastDateFieldSpecified;
            }
            set
            {
                this.lastDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> NearestDate
        {
            get
            {
                return this.nearestDateField;
            }
            set
            {
                this.nearestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NearestDateSpecified
        {
            get
            {
                return this.nearestDateFieldSpecified;
            }
            set
            {
                this.nearestDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Snils
        {
            get
            {
                return this.snilsField;
            }
            set
            {
                this.snilsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class HomeCallDoctorWithSlots : HomeCallDoctor
    {

        private Slot[] listSlotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Slot[] ListSlot
        {
            get
            {
                return this.listSlotField;
            }
            set
            {
                this.listSlotField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Slot
    {

        private int durationField;

        private bool durationFieldSpecified;

        private string idSlotField;

        private System.DateTime visitTimeField;

        private bool visitTimeFieldSpecified;

        /// <remarks/>
        public int Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSlot
        {
            get
            {
                return this.idSlotField;
            }
            set
            {
                this.idSlotField = value;
            }
        }

        /// <remarks/>
        public System.DateTime VisitTime
        {
            get
            {
                return this.visitTimeField;
            }
            set
            {
                this.visitTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisitTimeSpecified
        {
            get
            {
                return this.visitTimeFieldSpecified;
            }
            set
            {
                this.visitTimeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class Patient
    {

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string firstNameField;

        private string lastNameField;

        private string middleNameField;

        private string oMSNumberField;

        private string oMSSeriesField;

        private string sexField;

        private string snilsField;

        /// <remarks/>
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OMSNumber
        {
            get
            {
                return this.oMSNumberField;
            }
            set
            {
                this.oMSNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OMSSeries
        {
            get
            {
                return this.oMSSeriesField;
            }
            set
            {
                this.oMSSeriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Snils
        {
            get
            {
                return this.snilsField;
            }
            set
            {
                this.snilsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class Error
    {

        private string errorDescriptionField;

        private int idErrorField;

        private bool idErrorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ErrorDescription
        {
            get
            {
                return this.errorDescriptionField;
            }
            set
            {
                this.errorDescriptionField = value;
            }
        }

        /// <remarks/>
        public int IdError
        {
            get
            {
                return this.idErrorField;
            }
            set
            {
                this.idErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdErrorSpecified
        {
            get
            {
                return this.idErrorFieldSpecified;
            }
            set
            {
                this.idErrorFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HandleHomeCallRequestChangedResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetHomeCallAvailableSlotsResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchHomeCallRequestsResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateHomeCallRequestResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateHomeCallRequestResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidateHomeCallResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
    public partial class MethodResult
    {

        private Error[] errorListField;

        private System.Nullable<int> idHistoryField;

        private bool idHistoryFieldSpecified;

        private bool successField;

        private bool successFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Error[] ErrorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> IdHistory
        {
            get
            {
                return this.idHistoryField;
            }
            set
            {
                this.idHistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdHistorySpecified
        {
            get
            {
                return this.idHistoryFieldSpecified;
            }
            set
            {
                this.idHistoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuccessSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class HandleHomeCallRequestChangedResult : MethodResult
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class GetHomeCallAvailableSlotsResult : MethodResult
    {

        private string idSessionField;

        private Slot[] listSlotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSession
        {
            get
            {
                return this.idSessionField;
            }
            set
            {
                this.idSessionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2")]
        public Slot[] ListSlot
        {
            get
            {
                return this.listSlotField;
            }
            set
            {
                this.listSlotField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class SearchHomeCallRequestsResult : MethodResult
    {

        private int countField;

        private bool countFieldSpecified;

        private HomeCallRequest[] listHomeCallRequestField;

        /// <remarks/>
        public int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public HomeCallRequest[] ListHomeCallRequest
        {
            get
            {
                return this.listHomeCallRequestField;
            }
            set
            {
                this.listHomeCallRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class CreateHomeCallRequestResult : MethodResult
    {

        private string idHomeCallRequestField;

        private string idSessionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdHomeCallRequest
        {
            get
            {
                return this.idHomeCallRequestField;
            }
            set
            {
                this.idHomeCallRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSession
        {
            get
            {
                return this.idSessionField;
            }
            set
            {
                this.idSessionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class UpdateHomeCallRequestResult : MethodResult
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/HubService2.ContractsClasses.HomeCall")]
    public partial class ValidateHomeCallResult : MethodResult
    {

        private HomeCallDoctorWithSlots homeCallDoctorField;

        private string idDoctorPositionField;

        private string idPatField;

        private string idSessionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public HomeCallDoctorWithSlots HomeCallDoctor
        {
            get
            {
                return this.homeCallDoctorField;
            }
            set
            {
                this.homeCallDoctorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdDoctorPosition
        {
            get
            {
                return this.idDoctorPositionField;
            }
            set
            {
                this.idDoctorPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdPat
        {
            get
            {
                return this.idPatField;
            }
            set
            {
                this.idPatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSession
        {
            get
            {
                return this.idSessionField;
            }
            set
            {
                this.idSessionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void ValidateHomeCallCompletedEventHandler(object sender, ValidateHomeCallCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateHomeCallCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ValidateHomeCallCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ValidateHomeCallResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ValidateHomeCallResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void UpdateHomeCallRequestCompletedEventHandler(object sender, UpdateHomeCallRequestCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateHomeCallRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal UpdateHomeCallRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public UpdateHomeCallRequestResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((UpdateHomeCallRequestResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void CreateHomeCallRequestCompletedEventHandler(object sender, CreateHomeCallRequestCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateHomeCallRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateHomeCallRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CreateHomeCallRequestResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CreateHomeCallRequestResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void SearchHomeCallRequestsCompletedEventHandler(object sender, SearchHomeCallRequestsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchHomeCallRequestsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SearchHomeCallRequestsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SearchHomeCallRequestsResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SearchHomeCallRequestsResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void GetHomeCallAvailableSlotsCompletedEventHandler(object sender, GetHomeCallAvailableSlotsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHomeCallAvailableSlotsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetHomeCallAvailableSlotsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public GetHomeCallAvailableSlotsResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((GetHomeCallAvailableSlotsResult)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    public delegate void HandleHomeCallRequestChangedCompletedEventHandler(object sender, HandleHomeCallRequestChangedCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.7.3081.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HandleHomeCallRequestChangedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal HandleHomeCallRequestChangedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public HandleHomeCallRequestChangedResult Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((HandleHomeCallRequestChangedResult)(this.results[0]));
            }
        }
    }
}
