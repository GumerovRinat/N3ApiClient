using N3ApiClient.IemkService.Abstractions;

namespace N3ApiClient.IemkService.DataContracts
{
    namespace N3.Shared.Core
    {
        using System.Runtime.Serialization;

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "VersionInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.Shared.Core")]
        public partial class VersionInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string DatabaseVersionField;

            private string ServiceVersionField;

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
    }
    namespace N3.EMK.Dto.Case
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CaseBase", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Case")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Case.CaseAmb))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Case.CaseStat))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Case.CaseAcps))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Case.CaseTmc))]
        public partial class CaseBase : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private System.DateTime OpenDateField;

            private System.DateTime CloseDateField;

            private string HistoryNumberField;

            private string IdCaseMisField;

            private byte IdCaseAidTypeField;

            private byte IdPaymentTypeField;

            private byte ConfidentialityField;

            private byte DoctorConfidentialityField;

            private byte CuratorConfidentialityField;

            private string IdLpuField;

            private byte IdCaseResultField;

            private string CommentField;

            private N3.EMK.Dto.MedicalStaff DoctorInChargeField;

            private N3.EMK.Dto.Participant AuthenticatorField;

            private N3.EMK.Dto.Participant AuthorField;

            private N3.EMK.Dto.Participant LegalAuthenticatorField;

            private N3.EMK.Dto.Guardian GuardianField;

            private string IdPatientMisField;

            private byte AdmissionConditionField;

            private byte CaseVisitTypeField;

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
            public System.DateTime OpenDate
            {
                get
                {
                    return this.OpenDateField;
                }
                set
                {
                    this.OpenDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.DateTime CloseDate
            {
                get
                {
                    return this.CloseDateField;
                }
                set
                {
                    this.CloseDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string HistoryNumber
            {
                get
                {
                    return this.HistoryNumberField;
                }
                set
                {
                    this.HistoryNumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public byte IdCaseAidType
            {
                get
                {
                    return this.IdCaseAidTypeField;
                }
                set
                {
                    this.IdCaseAidTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public byte IdPaymentType
            {
                get
                {
                    return this.IdPaymentTypeField;
                }
                set
                {
                    this.IdPaymentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public byte Confidentiality
            {
                get
                {
                    return this.ConfidentialityField;
                }
                set
                {
                    this.ConfidentialityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public byte DoctorConfidentiality
            {
                get
                {
                    return this.DoctorConfidentialityField;
                }
                set
                {
                    this.DoctorConfidentialityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public byte CuratorConfidentiality
            {
                get
                {
                    return this.CuratorConfidentialityField;
                }
                set
                {
                    this.CuratorConfidentialityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
            public byte IdCaseResult
            {
                get
                {
                    return this.IdCaseResultField;
                }
                set
                {
                    this.IdCaseResultField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
            public N3.EMK.Dto.MedicalStaff DoctorInCharge
            {
                get
                {
                    return this.DoctorInChargeField;
                }
                set
                {
                    this.DoctorInChargeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
            public N3.EMK.Dto.Participant Authenticator
            {
                get
                {
                    return this.AuthenticatorField;
                }
                set
                {
                    this.AuthenticatorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 14)]
            public N3.EMK.Dto.Participant Author
            {
                get
                {
                    return this.AuthorField;
                }
                set
                {
                    this.AuthorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 15)]
            public N3.EMK.Dto.Participant LegalAuthenticator
            {
                get
                {
                    return this.LegalAuthenticatorField;
                }
                set
                {
                    this.LegalAuthenticatorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 16)]
            public N3.EMK.Dto.Guardian Guardian
            {
                get
                {
                    return this.GuardianField;
                }
                set
                {
                    this.GuardianField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 17)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 18)]
            public byte AdmissionCondition
            {
                get
                {
                    return this.AdmissionConditionField;
                }
                set
                {
                    this.AdmissionConditionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 19)]
            public byte CaseVisitType
            {
                get
                {
                    return this.CaseVisitTypeField;
                }
                set
                {
                    this.CaseVisitTypeField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CaseAmb", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Case")]
        public partial class CaseAmb : N3.EMK.Dto.Case.CaseBase
        {

            private byte IdCasePurposeField;

            private byte IdCaseTypeField;

            private byte IdAmbResultField;

            private bool IsActiveField;

            private N3.EMK.Dto.Step.StepAmb[] StepsField;

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdCasePurpose
            {
                get
                {
                    return this.IdCasePurposeField;
                }
                set
                {
                    this.IdCasePurposeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdCaseType
            {
                get
                {
                    return this.IdCaseTypeField;
                }
                set
                {
                    this.IdCaseTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public byte IdAmbResult
            {
                get
                {
                    return this.IdAmbResultField;
                }
                set
                {
                    this.IdAmbResultField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public N3.EMK.Dto.Step.StepAmb[] Steps
            {
                get
                {
                    return this.StepsField;
                }
                set
                {
                    this.StepsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CaseStat", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Case")]
        public partial class CaseStat : N3.EMK.Dto.Case.CaseBase
        {

            private string DeliveryCodeField;

            private byte IdIntoxicationTypeField;

            private byte IdTypeFromDiseaseStartField;

            private byte IdRepetitionField;

            private byte HospitalizationOrderField;

            private byte IdTransportInternField;

            private N3.EMK.Dto.Step.StepStat[] StepsField;

            private byte HospResultField;

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            private byte IdHospChannelField;

            private bool RW1MarkField;

            private bool AIDSMarkField;

            private byte[] PrehospitalDefectsField;

            private string AdmissionCommentField;

            private byte DischargeConditionField;

            private string DischargeCommentField;

            private string DietCommentField;

            private string TreatCommentField;

            private string WorkCommentField;

            private string OtherCommentField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DeliveryCode
            {
                get
                {
                    return this.DeliveryCodeField;
                }
                set
                {
                    this.DeliveryCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdIntoxicationType
            {
                get
                {
                    return this.IdIntoxicationTypeField;
                }
                set
                {
                    this.IdIntoxicationTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdTypeFromDiseaseStart
            {
                get
                {
                    return this.IdTypeFromDiseaseStartField;
                }
                set
                {
                    this.IdTypeFromDiseaseStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public byte IdRepetition
            {
                get
                {
                    return this.IdRepetitionField;
                }
                set
                {
                    this.IdRepetitionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public byte HospitalizationOrder
            {
                get
                {
                    return this.HospitalizationOrderField;
                }
                set
                {
                    this.HospitalizationOrderField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public byte IdTransportIntern
            {
                get
                {
                    return this.IdTransportInternField;
                }
                set
                {
                    this.IdTransportInternField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public N3.EMK.Dto.Step.StepStat[] Steps
            {
                get
                {
                    return this.StepsField;
                }
                set
                {
                    this.StepsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public byte HospResult
            {
                get
                {
                    return this.HospResultField;
                }
                set
                {
                    this.HospResultField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
            public byte IdHospChannel
            {
                get
                {
                    return this.IdHospChannelField;
                }
                set
                {
                    this.IdHospChannelField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
            public bool RW1Mark
            {
                get
                {
                    return this.RW1MarkField;
                }
                set
                {
                    this.RW1MarkField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
            public bool AIDSMark
            {
                get
                {
                    return this.AIDSMarkField;
                }
                set
                {
                    this.AIDSMarkField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
            public byte[] PrehospitalDefects
            {
                get
                {
                    return this.PrehospitalDefectsField;
                }
                set
                {
                    this.PrehospitalDefectsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
            public string AdmissionComment
            {
                get
                {
                    return this.AdmissionCommentField;
                }
                set
                {
                    this.AdmissionCommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 14)]
            public byte DischargeCondition
            {
                get
                {
                    return this.DischargeConditionField;
                }
                set
                {
                    this.DischargeConditionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 15)]
            public string DischargeComment
            {
                get
                {
                    return this.DischargeCommentField;
                }
                set
                {
                    this.DischargeCommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 16)]
            public string DietComment
            {
                get
                {
                    return this.DietCommentField;
                }
                set
                {
                    this.DietCommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 17)]
            public string TreatComment
            {
                get
                {
                    return this.TreatCommentField;
                }
                set
                {
                    this.TreatCommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 18)]
            public string WorkComment
            {
                get
                {
                    return this.WorkCommentField;
                }
                set
                {
                    this.WorkCommentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 19)]
            public string OtherComment
            {
                get
                {
                    return this.OtherCommentField;
                }
                set
                {
                    this.OtherCommentField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CaseAcps", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Case")]
        public partial class CaseAcps : N3.EMK.Dto.Case.CaseBase
        {

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CaseTmc", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Case")]
        public partial class CaseTmc : N3.EMK.Dto.Case.CaseBase
        {

            private string TmcIDField;

            private byte TmcFormField;

            private byte TmcGoalField;

            private N3.EMK.Dto.Initiator InitiatorField;

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string TmcID
            {
                get
                {
                    return this.TmcIDField;
                }
                set
                {
                    this.TmcIDField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public byte TmcForm
            {
                get
                {
                    return this.TmcFormField;
                }
                set
                {
                    this.TmcFormField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public byte TmcGoal
            {
                get
                {
                    return this.TmcGoalField;
                }
                set
                {
                    this.TmcGoalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public N3.EMK.Dto.Initiator Initiator
            {
                get
                {
                    return this.InitiatorField;
                }
                set
                {
                    this.InitiatorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }
        }
    }
    namespace N3.EMK.Dto
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedicalStaff", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class MedicalStaff : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private N3.EMK.Dto.PersonWithIdentity PersonField;

            private string IdLpuField;

            private ushort IdSpecialityField;

            private ushort IdPositionField;

            private int IdMedicalStaffField;

            private string SpecialityNameField;

            private string PositionNameField;

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
            public N3.EMK.Dto.PersonWithIdentity Person
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public ushort IdSpeciality
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public ushort IdPosition
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int IdMedicalStaff
            {
                get
                {
                    return this.IdMedicalStaffField;
                }
                set
                {
                    this.IdMedicalStaffField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string SpecialityName
            {
                get
                {
                    return this.SpecialityNameField;
                }
                set
                {
                    this.SpecialityNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public string PositionName
            {
                get
                {
                    return this.PositionNameField;
                }
                set
                {
                    this.PositionNameField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Participant", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class Participant : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            private byte IdRoleField;

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
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdRole
            {
                get
                {
                    return this.IdRoleField;
                }
                set
                {
                    this.IdRoleField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Guardian", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class Guardian : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private N3.EMK.Dto.PersonWithIdentity PersonField;

            private byte IdRelationTypeField;

            private string UnderlyingDocumentField;

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
            public N3.EMK.Dto.PersonWithIdentity Person
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public byte IdRelationType
            {
                get
                {
                    return this.IdRelationTypeField;
                }
                set
                {
                    this.IdRelationTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string UnderlyingDocument
            {
                get
                {
                    return this.UnderlyingDocumentField;
                }
                set
                {
                    this.UnderlyingDocumentField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PersonWithIdentity", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class PersonWithIdentity : N3.EMK.Dto.Person
        {

            private N3.EMK.Dto.IdentityDocument[] DocumentsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.IdentityDocument[] Documents
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Person", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.PersonWithIdentity))]
        public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private N3.EMK.Dto.HumanName HumanNameField;

            private byte SexField;

            private System.Nullable<System.DateTime> BirthdateField;

            private string IdPersonMisField;

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
            public N3.EMK.Dto.HumanName HumanName
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
            public byte Sex
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.Nullable<System.DateTime> Birthdate
            {
                get
                {
                    return this.BirthdateField;
                }
                set
                {
                    this.BirthdateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "HumanName", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class HumanName : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string GivenNameField;

            private string MiddleNameField;

            private string FamilyNameField;

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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "IdentityDocument", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class IdentityDocument : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string DocNField;

            private string DocSField;

            private string DocumentNameField;

            private System.Nullable<System.DateTime> ExpiredDateField;

            private byte IdDocumentTypeField;

            private System.Nullable<int> IdProviderField;

            private System.Nullable<System.DateTime> IssuedDateField;

            private string ProviderNameField;

            private string RegionCodeField;

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
            public string DocumentName
            {
                get
                {
                    return this.DocumentNameField;
                }
                set
                {
                    this.DocumentNameField = value;
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
            public byte IdDocumentType
            {
                get
                {
                    return this.IdDocumentTypeField;
                }
                set
                {
                    this.IdDocumentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<int> IdProvider
            {
                get
                {
                    return this.IdProviderField;
                }
                set
                {
                    this.IdProviderField = value;
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
            public string RegionCode
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "Quantity", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class Quantity : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int IdUnitField;

            private decimal ValueField;

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
            public int IdUnit
            {
                get
                {
                    return this.IdUnitField;
                }
                set
                {
                    this.IdUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Initiator", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto")]
        public partial class Initiator : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte InitiatorTypeField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

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
            public byte InitiatorType
            {
                get
                {
                    return this.InitiatorTypeField;
                }
                set
                {
                    this.InitiatorTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }
        }
    }
    namespace N3.EMK.Dto.Step
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "StepAmb", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Step")]
        public partial class StepAmb : N3.EMK.Dto.Step.StepBase
        {

            private byte IdVisitPlaceField;

            private byte IdVisitPurposeField;

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdVisitPlace
            {
                get
                {
                    return this.IdVisitPlaceField;
                }
                set
                {
                    this.IdVisitPlaceField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdVisitPurpose
            {
                get
                {
                    return this.IdVisitPurposeField;
                }
                set
                {
                    this.IdVisitPurposeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "StepBase", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Step")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Step.StepStat))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.Step.StepAmb))]
        public partial class StepBase : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private System.DateTime DateStartField;

            private System.Nullable<System.DateTime> DateEndField;

            private string CommentField;

            private byte IdPaymentTypeField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            private string IdStepMisField;

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
            public System.DateTime DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.Nullable<System.DateTime> DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public byte IdPaymentType
            {
                get
                {
                    return this.IdPaymentTypeField;
                }
                set
                {
                    this.IdPaymentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string IdStepMis
            {
                get
                {
                    return this.IdStepMisField;
                }
                set
                {
                    this.IdStepMisField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "StepStat", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Step")]
        public partial class StepStat : N3.EMK.Dto.Step.StepBase
        {

            private string HospitalDepartmentNameField;

            private string IdHospitalDepartmentField;

            private byte IdRegimenField;

            private string WardNumberField;

            private string BedNumberField;

            private int BedProfileField;

            private ushort DaySpendField;

            private N3.EMK.Dto.MedRec.MedRecord[] MedRecordsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string HospitalDepartmentName
            {
                get
                {
                    return this.HospitalDepartmentNameField;
                }
                set
                {
                    this.HospitalDepartmentNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdHospitalDepartment
            {
                get
                {
                    return this.IdHospitalDepartmentField;
                }
                set
                {
                    this.IdHospitalDepartmentField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdRegimen
            {
                get
                {
                    return this.IdRegimenField;
                }
                set
                {
                    this.IdRegimenField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string WardNumber
            {
                get
                {
                    return this.WardNumberField;
                }
                set
                {
                    this.WardNumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public string BedNumber
            {
                get
                {
                    return this.BedNumberField;
                }
                set
                {
                    this.BedNumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public int BedProfile
            {
                get
                {
                    return this.BedProfileField;
                }
                set
                {
                    this.BedProfileField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public ushort DaySpend
            {
                get
                {
                    return this.DaySpendField;
                }
                set
                {
                    this.DaySpendField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public N3.EMK.Dto.MedRec.MedRecord[] MedRecords
            {
                get
                {
                    return this.MedRecordsField;
                }
                set
                {
                    this.MedRecordsField = value;
                }
            }
        }
    }
    namespace N3.EMK.Dto.MedRec
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedRecord", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.DeathInfo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Problem))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AppointedMedication))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.TfomsInfo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Service))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.NonDrugTreatment))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Procedure))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Immunize))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Vaccination))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Reaction))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedicalExemption))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.ImmunizationPlan))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.ResInstr))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Scores))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AllergyBase))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AllergyDrug))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AllergyNonDrug))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.SocialAnamnesis))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.MedDocument))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.ConsultNote))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DischargeSummary))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.LaboratoryReport))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.SickList))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryBase))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOne))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryTwo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOnceByTwoYears))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.AmbulanceInfo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Referral))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form027U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form106_2U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form103U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form106U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.PacsResult))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DeathCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.ReferralMSE))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.BirthCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DriveCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.PrenatalDeathCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.Diagnosis))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.ClinicMainDiagnosis))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.AnatomopathologicalClinicMainDiagnosis))]
        public partial class MedRecord : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DeathInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class DeathInfo : N3.EMK.Dto.MedRec.MedRecord
        {

            private string MkbCodeField;

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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Problem", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Problem : N3.EMK.Dto.MedRec.MedRecord
        {

            private string IdProblemMisField;

            private string DiagnosisMkbField;

            private System.DateTime DateField;

            private N3.EMK.Dto.MedicalStaff PerformerField;

            private string CommentField;

            private bool StatusField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdProblemMis
            {
                get
                {
                    return this.IdProblemMisField;
                }
                set
                {
                    this.IdProblemMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public string DiagnosisMkb
            {
                get
                {
                    return this.DiagnosisMkbField;
                }
                set
                {
                    this.DiagnosisMkbField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.DateTime Date
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public N3.EMK.Dto.MedicalStaff Performer
            {
                get
                {
                    return this.PerformerField;
                }
                set
                {
                    this.PerformerField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public bool Status
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "AppointedMedication", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class AppointedMedication : N3.EMK.Dto.MedRec.MedRecord
        {

            private string AnatomicTherapeuticChemicalClassificationField;

            private N3.EMK.Dto.Quantity CourseDoseField;

            private N3.EMK.Dto.Quantity DayDoseField;

            private ushort DaysCountField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            private System.DateTime IssuedDateField;

            private string MedicineIssueTypeField;

            private string MedicineNameField;

            private ushort MedicineTypeField;

            private byte MedicineUseWayField;

            private string NumberField;

            private N3.EMK.Dto.Quantity OneTimeDoseField;

            private int IdINNField;

            private string SeriaField;

            private System.Nullable<bool> StatusField;

            private System.Nullable<System.DateTime> CourseStartDateField;

            private System.Nullable<System.DateTime> CourseEndDateField;

            private string FrequencyAdmissionField;

            private System.Nullable<int> TradeNameField;

            private System.Nullable<int> CancellationReasonField;

            private System.Nullable<System.DateTime> CancellationDateField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string AnatomicTherapeuticChemicalClassification
            {
                get
                {
                    return this.AnatomicTherapeuticChemicalClassificationField;
                }
                set
                {
                    this.AnatomicTherapeuticChemicalClassificationField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.Quantity CourseDose
            {
                get
                {
                    return this.CourseDoseField;
                }
                set
                {
                    this.CourseDoseField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.Quantity DayDose
            {
                get
                {
                    return this.DayDoseField;
                }
                set
                {
                    this.DayDoseField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public ushort DaysCount
            {
                get
                {
                    return this.DaysCountField;
                }
                set
                {
                    this.DaysCountField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime IssuedDate
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
            public string MedicineIssueType
            {
                get
                {
                    return this.MedicineIssueTypeField;
                }
                set
                {
                    this.MedicineIssueTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MedicineName
            {
                get
                {
                    return this.MedicineNameField;
                }
                set
                {
                    this.MedicineNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public ushort MedicineType
            {
                get
                {
                    return this.MedicineTypeField;
                }
                set
                {
                    this.MedicineTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte MedicineUseWay
            {
                get
                {
                    return this.MedicineUseWayField;
                }
                set
                {
                    this.MedicineUseWayField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Number
            {
                get
                {
                    return this.NumberField;
                }
                set
                {
                    this.NumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.Quantity OneTimeDose
            {
                get
                {
                    return this.OneTimeDoseField;
                }
                set
                {
                    this.OneTimeDoseField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
            public int IdINN
            {
                get
                {
                    return this.IdINNField;
                }
                set
                {
                    this.IdINNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
            public string Seria
            {
                get
                {
                    return this.SeriaField;
                }
                set
                {
                    this.SeriaField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 14)]
            public System.Nullable<bool> Status
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 15)]
            public System.Nullable<System.DateTime> CourseStartDate
            {
                get
                {
                    return this.CourseStartDateField;
                }
                set
                {
                    this.CourseStartDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 16)]
            public System.Nullable<System.DateTime> CourseEndDate
            {
                get
                {
                    return this.CourseEndDateField;
                }
                set
                {
                    this.CourseEndDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 17)]
            public string FrequencyAdmission
            {
                get
                {
                    return this.FrequencyAdmissionField;
                }
                set
                {
                    this.FrequencyAdmissionField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 18)]
            public System.Nullable<int> TradeName
            {
                get
                {
                    return this.TradeNameField;
                }
                set
                {
                    this.TradeNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 19)]
            public System.Nullable<int> CancellationReason
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 20)]
            public System.Nullable<System.DateTime> CancellationDate
            {
                get
                {
                    return this.CancellationDateField;
                }
                set
                {
                    this.CancellationDateField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "TfomsInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class TfomsInfo : N3.EMK.Dto.MedRec.MedRecord
        {

            private int CountField;

            private string IdTfomsTypeField;

            private decimal TariffField;

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
            public string IdTfomsType
            {
                get
                {
                    return this.IdTfomsTypeField;
                }
                set
                {
                    this.IdTfomsTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal Tariff
            {
                get
                {
                    return this.TariffField;
                }
                set
                {
                    this.TariffField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Service", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Service : N3.EMK.Dto.MedRec.MedRecord
        {

            private System.DateTime DateEndField;

            private System.DateTime DateStartField;

            private string IdServiceTypeField;

            private N3.EMK.Dto.MedRec.Param[] ParamsField;

            private N3.EMK.Dto.MedRec.PaymentInfo PaymentInfoField;

            private N3.EMK.Dto.Participant PerformerField;

            private string ServiceNameField;

            private System.Nullable<bool> StatusField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdServiceType
            {
                get
                {
                    return this.IdServiceTypeField;
                }
                set
                {
                    this.IdServiceTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.Param[] Params
            {
                get
                {
                    return this.ParamsField;
                }
                set
                {
                    this.ParamsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.PaymentInfo PaymentInfo
            {
                get
                {
                    return this.PaymentInfoField;
                }
                set
                {
                    this.PaymentInfoField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.Participant Performer
            {
                get
                {
                    return this.PerformerField;
                }
                set
                {
                    this.PerformerField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ServiceName
            {
                get
                {
                    return this.ServiceNameField;
                }
                set
                {
                    this.ServiceNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<bool> Status
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "NonDrugTreatment", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class NonDrugTreatment : N3.EMK.Dto.MedRec.MedRecord
        {

            private string NameField;

            private string SchemeField;

            private System.Nullable<System.DateTime> StartField;

            private System.Nullable<System.DateTime> EndField;

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
            public string Scheme
            {
                get
                {
                    return this.SchemeField;
                }
                set
                {
                    this.SchemeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> Start
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public System.Nullable<System.DateTime> End
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Procedure", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Procedure : N3.EMK.Dto.MedRec.MedRecord
        {

            private string CodeField;

            private System.Nullable<System.DateTime> DateField;

            private N3.EMK.Dto.MedicalStaff PerformerField;

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
            public N3.EMK.Dto.MedicalStaff Performer
            {
                get
                {
                    return this.PerformerField;
                }
                set
                {
                    this.PerformerField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Immunize", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Vaccination))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Reaction))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedicalExemption))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.ImmunizationPlan))]
        public partial class Immunize : N3.EMK.Dto.MedRec.MedRecord
        {

            private N3.EMK.Dto.MedicalStaff PerformerField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedicalStaff Performer
            {
                get
                {
                    return this.PerformerField;
                }
                set
                {
                    this.PerformerField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Vaccination", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Vaccination : N3.EMK.Dto.MedRec.Immunize
        {

            private string LpuField;

            private System.DateTime DateField;

            private int CodeField;

            private string VacTypeField;

            private int[] InfField;

            private string IdVaccinationMisField;

            private int StatusField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Lpu
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.DateTime Date
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int Code
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string VacType
            {
                get
                {
                    return this.VacTypeField;
                }
                set
                {
                    this.VacTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int[] Inf
            {
                get
                {
                    return this.InfField;
                }
                set
                {
                    this.InfField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string IdVaccinationMis
            {
                get
                {
                    return this.IdVaccinationMisField;
                }
                set
                {
                    this.IdVaccinationMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public int Status
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "Reaction", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Reaction : N3.EMK.Dto.MedRec.Immunize
        {

            private string LpuField;

            private int ReactionTypeField;

            private System.DateTime DateField;

            private int CodeField;

            private int[] InfField;

            private System.Nullable<int> MedicalReactionTypeField;

            private string MedicalReactionValueField;

            private string IdReactionMisField;

            private int StatusField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Lpu
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
            public int ReactionType
            {
                get
                {
                    return this.ReactionTypeField;
                }
                set
                {
                    this.ReactionTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.DateTime Date
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public int Code
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int[] Inf
            {
                get
                {
                    return this.InfField;
                }
                set
                {
                    this.InfField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public System.Nullable<int> MedicalReactionType
            {
                get
                {
                    return this.MedicalReactionTypeField;
                }
                set
                {
                    this.MedicalReactionTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public string MedicalReactionValue
            {
                get
                {
                    return this.MedicalReactionValueField;
                }
                set
                {
                    this.MedicalReactionValueField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public string IdReactionMis
            {
                get
                {
                    return this.IdReactionMisField;
                }
                set
                {
                    this.IdReactionMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public int Status
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedicalExemption", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class MedicalExemption : N3.EMK.Dto.MedRec.Immunize
        {

            private System.DateTime DateStartField;

            private System.Nullable<System.DateTime> DateEndField;

            private int ExemptionTypeField;

            private int[] ExemptionInfField;

            private int ExemptionReasonField;

            private string ExemptionDiseaseField;

            private string IdMedicalExemptionMisField;

            private int StatusField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.Nullable<System.DateTime> DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int ExemptionType
            {
                get
                {
                    return this.ExemptionTypeField;
                }
                set
                {
                    this.ExemptionTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public int[] ExemptionInf
            {
                get
                {
                    return this.ExemptionInfField;
                }
                set
                {
                    this.ExemptionInfField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int ExemptionReason
            {
                get
                {
                    return this.ExemptionReasonField;
                }
                set
                {
                    this.ExemptionReasonField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string ExemptionDisease
            {
                get
                {
                    return this.ExemptionDiseaseField;
                }
                set
                {
                    this.ExemptionDiseaseField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public string IdMedicalExemptionMis
            {
                get
                {
                    return this.IdMedicalExemptionMisField;
                }
                set
                {
                    this.IdMedicalExemptionMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public int Status
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
        [System.Runtime.Serialization.DataContractAttribute(Name = "ImmunizationPlan", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class ImmunizationPlan : N3.EMK.Dto.MedRec.Immunize
        {

            private N3.EMK.Dto.MedRec.ImmunizationType ImmunizationTypeField;

            private int[] InfField;

            private System.DateTime DateField;

            private string VacTypeField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.ImmunizationType ImmunizationType
            {
                get
                {
                    return this.ImmunizationTypeField;
                }
                set
                {
                    this.ImmunizationTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public int[] Inf
            {
                get
                {
                    return this.InfField;
                }
                set
                {
                    this.InfField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.DateTime Date
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string VacType
            {
                get
                {
                    return this.VacTypeField;
                }
                set
                {
                    this.VacTypeField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ResInstr", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class ResInstr : N3.EMK.Dto.MedRec.MedRecord
        {

            private System.DateTime DateField;

            private int TypeField;

            private int PriorityField;

            private string TextField;

            private N3.EMK.Dto.MedicalStaff PerformerField;

            private N3.EMK.Dto.MedRec.ResInstr.Activity[] ActivitiesField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime Date
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int Priority
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string Text
            {
                get
                {
                    return this.TextField;
                }
                set
                {
                    this.TextField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public N3.EMK.Dto.MedicalStaff Performer
            {
                get
                {
                    return this.PerformerField;
                }
                set
                {
                    this.PerformerField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public N3.EMK.Dto.MedRec.ResInstr.Activity[] Activities
            {
                get
                {
                    return this.ActivitiesField;
                }
                set
                {
                    this.ActivitiesField = value;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
            [System.Runtime.Serialization.DataContractAttribute(Name = "ResInstr.Activity", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
            public partial class Activity : object, System.Runtime.Serialization.IExtensibleDataObject
            {

                private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

                private string CodeField;

                private System.DateTime DateField;

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
                public System.DateTime Date
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
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Scores", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Scores : N3.EMK.Dto.MedRec.MedRecord
        {

            private System.DateTime DateField;

            private string ScaleField;

            private string ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime Date
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
            public string Scale
            {
                get
                {
                    return this.ScaleField;
                }
                set
                {
                    this.ScaleField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AllergyBase", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AllergyDrug))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.AllergyNonDrug))]
        public partial class AllergyBase : N3.EMK.Dto.MedRec.MedRecord
        {

            private int TypeField;

            private string CommentField;

            private System.DateTime TimeField;

            private int ReactionCodeField;

            private int IdStepField;

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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.DateTime Time
            {
                get
                {
                    return this.TimeField;
                }
                set
                {
                    this.TimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public int ReactionCode
            {
                get
                {
                    return this.ReactionCodeField;
                }
                set
                {
                    this.ReactionCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int IdStep
            {
                get
                {
                    return this.IdStepField;
                }
                set
                {
                    this.IdStepField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AllergyDrug", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class AllergyDrug : N3.EMK.Dto.MedRec.AllergyBase
        {

            private int IdINNField;

            private int IdField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public int IdINN
            {
                get
                {
                    return this.IdINNField;
                }
                set
                {
                    this.IdINNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AllergyNonDrug", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class AllergyNonDrug : N3.EMK.Dto.MedRec.AllergyBase
        {

            private string DescriptionField;

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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "SocialAnamnesis", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class SocialAnamnesis : N3.EMK.Dto.MedRec.MedRecord
        {

            private N3.EMK.Dto.MedRec.Privilege[] PrivilegesField;

            private N3.EMK.Dto.MedRec.Disability DisabilityField;

            private int[] SocialRiskFactorsField;

            private int[] OccupationalHazardsField;

            private int[] BadHabitsField;

            private int RegistryAreaField;

            private N3.EMK.Dto.MedRec.SocialGroup SocialGroupField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.Privilege[] Privileges
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public N3.EMK.Dto.MedRec.Disability Disability
            {
                get
                {
                    return this.DisabilityField;
                }
                set
                {
                    this.DisabilityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int[] SocialRiskFactors
            {
                get
                {
                    return this.SocialRiskFactorsField;
                }
                set
                {
                    this.SocialRiskFactorsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public int[] OccupationalHazards
            {
                get
                {
                    return this.OccupationalHazardsField;
                }
                set
                {
                    this.OccupationalHazardsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public int[] BadHabits
            {
                get
                {
                    return this.BadHabitsField;
                }
                set
                {
                    this.BadHabitsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public int RegistryArea
            {
                get
                {
                    return this.RegistryAreaField;
                }
                set
                {
                    this.RegistryAreaField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public N3.EMK.Dto.MedRec.SocialGroup SocialGroup
            {
                get
                {
                    return this.SocialGroupField;
                }
                set
                {
                    this.SocialGroupField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PaymentInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class PaymentInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte HealthCareUnitField;

            private byte IdPaymentTypeField;

            private byte PaymentStateField;

            private int QuantityField;

            private decimal TariffField;

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
            public byte HealthCareUnit
            {
                get
                {
                    return this.HealthCareUnitField;
                }
                set
                {
                    this.HealthCareUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte IdPaymentType
            {
                get
                {
                    return this.IdPaymentTypeField;
                }
                set
                {
                    this.IdPaymentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte PaymentState
            {
                get
                {
                    return this.PaymentStateField;
                }
                set
                {
                    this.PaymentStateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public int Quantity
            {
                get
                {
                    return this.QuantityField;
                }
                set
                {
                    this.QuantityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal Tariff
            {
                get
                {
                    return this.TariffField;
                }
                set
                {
                    this.TariffField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Param", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Param : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int CodeField;

            private string ValueField;

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
            public int Code
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
            public string Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ImmunizationType", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.ReactionType))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.VaccinationType))]
        public partial class ImmunizationType : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ReactionType", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class ReactionType : N3.EMK.Dto.MedRec.ImmunizationType
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "VaccinationType", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class VaccinationType : N3.EMK.Dto.MedRec.ImmunizationType
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Disability", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Disability : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int CodeField;

            private System.DateTime DateField;

            private System.Nullable<int> OrderField;

            private string CausingDiseaseField;

            private System.Nullable<System.DateTime> LastMedicalExaminationDateField;

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
            public int Code
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
            public System.DateTime Date
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
            public System.Nullable<int> Order
            {
                get
                {
                    return this.OrderField;
                }
                set
                {
                    this.OrderField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string CausingDisease
            {
                get
                {
                    return this.CausingDiseaseField;
                }
                set
                {
                    this.CausingDiseaseField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public System.Nullable<System.DateTime> LastMedicalExaminationDate
            {
                get
                {
                    return this.LastMedicalExaminationDateField;
                }
                set
                {
                    this.LastMedicalExaminationDateField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "SocialGroup", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class SocialGroup : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int CodeField;

            private string TextField;

            private System.Nullable<int> ProfessionCodeField;

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
            public int Code
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
            public string Text
            {
                get
                {
                    return this.TextField;
                }
                set
                {
                    this.TextField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.Nullable<int> ProfessionCode
            {
                get
                {
                    return this.ProfessionCodeField;
                }
                set
                {
                    this.ProfessionCodeField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Privilege", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec")]
        public partial class Privilege : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int CodeField;

            private System.DateTime StartField;

            private System.DateTime EndField;

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
            public int Code
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
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
        }
    }
    namespace N3.EMK.Dto.MedRec.MedDoc
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedDocument", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.ConsultNote))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DischargeSummary))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.LaboratoryReport))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.SickList))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryBase))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOne))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryTwo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOnceByTwoYears))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.AmbulanceInfo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Referral))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form027U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form106_2U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form103U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.Form106U))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.PacsResult))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DeathCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.ReferralMSE))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.BirthCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DriveCertificate))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.PrenatalDeathCertificate))]
        public partial class MedDocument : N3.EMK.Dto.MedRec.MedRecord
        {

            private N3.EMK.Dto.MedRec.MedDoc.MedDocumentDtoDocumentAttachment[] AttachmentsField;

            private N3.EMK.Dto.MedicalStaff AuthorField;

            private System.DateTime CreationDateField;

            private string FhirMedDocumentTypeField;

            private string HeaderField;

            private string IdDocumentMisField;

            private System.Nullable<byte> IdMedDocumentTypeField;

            private N3.EMK.Dto.MedRec.MedDoc.Observation[] ObservationsField;

            private string[] RelatedMedDocField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.MedDocumentDtoDocumentAttachment[] Attachments
            {
                get
                {
                    return this.AttachmentsField;
                }
                set
                {
                    this.AttachmentsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedicalStaff Author
            {
                get
                {
                    return this.AuthorField;
                }
                set
                {
                    this.AuthorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime CreationDate
            {
                get
                {
                    return this.CreationDateField;
                }
                set
                {
                    this.CreationDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string FhirMedDocumentType
            {
                get
                {
                    return this.FhirMedDocumentTypeField;
                }
                set
                {
                    this.FhirMedDocumentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Header
            {
                get
                {
                    return this.HeaderField;
                }
                set
                {
                    this.HeaderField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string IdDocumentMis
            {
                get
                {
                    return this.IdDocumentMisField;
                }
                set
                {
                    this.IdDocumentMisField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<byte> IdMedDocumentType
            {
                get
                {
                    return this.IdMedDocumentTypeField;
                }
                set
                {
                    this.IdMedDocumentTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.Observation[] Observations
            {
                get
                {
                    return this.ObservationsField;
                }
                set
                {
                    this.ObservationsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string[] RelatedMedDoc
            {
                get
                {
                    return this.RelatedMedDocField;
                }
                set
                {
                    this.RelatedMedDocField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ConsultNote", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class ConsultNote : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DischargeSummary", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DischargeSummary : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "LaboratoryReport", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class LaboratoryReport : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "SickList", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class SickList : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private N3.EMK.Dto.MedRec.MedDoc.SickListInfo SickListInfoField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.SickListInfo SickListInfo
            {
                get
                {
                    return this.SickListInfoField;
                }
                set
                {
                    this.SickListInfoField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DispensaryBase", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOne))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryTwo))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DispensaryOnceByTwoYears))]
        public partial class DispensaryBase : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private bool IsGuestedField;

            private bool HasExtraResearchRefferalField;

            private bool IsUnderObservationField;

            private bool HasExpertCareRefferalField;

            private bool HasPrescribeCureField;

            private bool HasHealthResortRefferalField;

            private N3.EMK.Dto.MedRec.MedDoc.HealthGroup HealthGroupField;

            private N3.EMK.Dto.MedRec.MedDoc.Recommendation[] RecommendationsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool IsGuested
            {
                get
                {
                    return this.IsGuestedField;
                }
                set
                {
                    this.IsGuestedField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public bool HasExtraResearchRefferal
            {
                get
                {
                    return this.HasExtraResearchRefferalField;
                }
                set
                {
                    this.HasExtraResearchRefferalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public bool IsUnderObservation
            {
                get
                {
                    return this.IsUnderObservationField;
                }
                set
                {
                    this.IsUnderObservationField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public bool HasExpertCareRefferal
            {
                get
                {
                    return this.HasExpertCareRefferalField;
                }
                set
                {
                    this.HasExpertCareRefferalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public bool HasPrescribeCure
            {
                get
                {
                    return this.HasPrescribeCureField;
                }
                set
                {
                    this.HasPrescribeCureField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public bool HasHealthResortRefferal
            {
                get
                {
                    return this.HasHealthResortRefferalField;
                }
                set
                {
                    this.HasHealthResortRefferalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public N3.EMK.Dto.MedRec.MedDoc.HealthGroup HealthGroup
            {
                get
                {
                    return this.HealthGroupField;
                }
                set
                {
                    this.HealthGroupField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public N3.EMK.Dto.MedRec.MedDoc.Recommendation[] Recommendations
            {
                get
                {
                    return this.RecommendationsField;
                }
                set
                {
                    this.RecommendationsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DispensaryOne", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DispensaryOne : N3.EMK.Dto.MedRec.MedDoc.DispensaryBase
        {

            private bool HasSecondStageRefferalField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool HasSecondStageRefferal
            {
                get
                {
                    return this.HasSecondStageRefferalField;
                }
                set
                {
                    this.HasSecondStageRefferalField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DispensaryTwo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DispensaryTwo : N3.EMK.Dto.MedRec.MedDoc.DispensaryBase
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DispensaryOnceByTwoYears", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DispensaryOnceByTwoYears : N3.EMK.Dto.MedRec.MedDoc.DispensaryBase
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AmbulanceInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class AmbulanceInfo : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private string SubAmbulanceField;

            private string BrigadeNumberField;

            private System.Nullable<short> MedResultField;

            private N3.EMK.Dto.MedRec.MedDoc.AssisNote[] AssisListField;

            private System.Nullable<System.DateTime> TransportTimeField;

            private string HospitalNameField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string SubAmbulance
            {
                get
                {
                    return this.SubAmbulanceField;
                }
                set
                {
                    this.SubAmbulanceField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public string BrigadeNumber
            {
                get
                {
                    return this.BrigadeNumberField;
                }
                set
                {
                    this.BrigadeNumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.Nullable<short> MedResult
            {
                get
                {
                    return this.MedResultField;
                }
                set
                {
                    this.MedResultField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public N3.EMK.Dto.MedRec.MedDoc.AssisNote[] AssisList
            {
                get
                {
                    return this.AssisListField;
                }
                set
                {
                    this.AssisListField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public System.Nullable<System.DateTime> TransportTime
            {
                get
                {
                    return this.TransportTimeField;
                }
                set
                {
                    this.TransportTimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string HospitalName
            {
                get
                {
                    return this.HospitalNameField;
                }
                set
                {
                    this.HospitalNameField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Referral", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Referral : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private N3.EMK.Dto.MedRec.MedDoc.ReferralInfo ReferralInfoField;

            private N3.EMK.Dto.MedicalStaff DepartmentHeadField;

            private string IdSourceLpuField;

            private string IdTargetLpuField;

            private string ReferralIDField;

            private string RelatedIDField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.ReferralInfo ReferralInfo
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public N3.EMK.Dto.MedicalStaff DepartmentHead
            {
                get
                {
                    return this.DepartmentHeadField;
                }
                set
                {
                    this.DepartmentHeadField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string IdSourceLpu
            {
                get
                {
                    return this.IdSourceLpuField;
                }
                set
                {
                    this.IdSourceLpuField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string IdTargetLpu
            {
                get
                {
                    return this.IdTargetLpuField;
                }
                set
                {
                    this.IdTargetLpuField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public string ReferralID
            {
                get
                {
                    return this.ReferralIDField;
                }
                set
                {
                    this.ReferralIDField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string RelatedID
            {
                get
                {
                    return this.RelatedIDField;
                }
                set
                {
                    this.RelatedIDField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Form027U", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Form027U : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Form106_2U", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Form106_2U : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Form103U", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Form103U : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Form106U", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Form106U : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PacsResult", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class PacsResult : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private System.DateTime ProtocolDateField;

            private string CodeField;

            private N3.EMK.Dto.MedRec.MedDoc.PacsResult.ImageData ImageField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime ProtocolDate
            {
                get
                {
                    return this.ProtocolDateField;
                }
                set
                {
                    this.ProtocolDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public N3.EMK.Dto.MedRec.MedDoc.PacsResult.ImageData Image
            {
                get
                {
                    return this.ImageField;
                }
                set
                {
                    this.ImageField = value;
                }
            }

            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
            [System.Runtime.Serialization.DataContractAttribute(Name = "PacsResult.ImageData", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
            public partial class ImageData : object, System.Runtime.Serialization.IExtensibleDataObject
            {

                private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

                private string UidField;

                private string PacsField;

                private string ConclusionField;

                private string StatusReportField;

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
                public string Uid
                {
                    get
                    {
                        return this.UidField;
                    }
                    set
                    {
                        this.UidField = value;
                    }
                }

                [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
                public string Pacs
                {
                    get
                    {
                        return this.PacsField;
                    }
                    set
                    {
                        this.PacsField = value;
                    }
                }

                [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
                public string Conclusion
                {
                    get
                    {
                        return this.ConclusionField;
                    }
                    set
                    {
                        this.ConclusionField = value;
                    }
                }

                [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
                public string StatusReport
                {
                    get
                    {
                        return this.StatusReportField;
                    }
                    set
                    {
                        this.StatusReportField = value;
                    }
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DeathCertificate", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DeathCertificate : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private string DeathReasonField;

            private System.Nullable<System.DateTime> CertificateDateField;

            private string CertificateSField;

            private string CertificateNField;

            private System.Nullable<System.DateTime> DeathDateField;

            private string DeathReasonImmediateField;

            private string DeathReasonIntermediateField;

            private string DeathReasonInitialField;

            private string DeathReasonExternalField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DeathReason
            {
                get
                {
                    return this.DeathReasonField;
                }
                set
                {
                    this.DeathReasonField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.Nullable<System.DateTime> CertificateDate
            {
                get
                {
                    return this.CertificateDateField;
                }
                set
                {
                    this.CertificateDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string CertificateS
            {
                get
                {
                    return this.CertificateSField;
                }
                set
                {
                    this.CertificateSField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string CertificateN
            {
                get
                {
                    return this.CertificateNField;
                }
                set
                {
                    this.CertificateNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public System.Nullable<System.DateTime> DeathDate
            {
                get
                {
                    return this.DeathDateField;
                }
                set
                {
                    this.DeathDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string DeathReasonImmediate
            {
                get
                {
                    return this.DeathReasonImmediateField;
                }
                set
                {
                    this.DeathReasonImmediateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public string DeathReasonIntermediate
            {
                get
                {
                    return this.DeathReasonIntermediateField;
                }
                set
                {
                    this.DeathReasonIntermediateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public string DeathReasonInitial
            {
                get
                {
                    return this.DeathReasonInitialField;
                }
                set
                {
                    this.DeathReasonInitialField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public string DeathReasonExternal
            {
                get
                {
                    return this.DeathReasonExternalField;
                }
                set
                {
                    this.DeathReasonExternalField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ReferralMSE", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class ReferralMSE : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "BirthCertificate", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class BirthCertificate : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private System.Nullable<System.DateTime> CertificateDateField;

            private string CertificateSField;

            private string CertificateNField;

            private System.Nullable<System.DateTime> BirthDateField;

            private System.Nullable<int> SexField;

            private System.Nullable<int> BirthOrderField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> CertificateDate
            {
                get
                {
                    return this.CertificateDateField;
                }
                set
                {
                    this.CertificateDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string CertificateS
            {
                get
                {
                    return this.CertificateSField;
                }
                set
                {
                    this.CertificateSField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string CertificateN
            {
                get
                {
                    return this.CertificateNField;
                }
                set
                {
                    this.CertificateNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public System.Nullable<int> Sex
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public System.Nullable<int> BirthOrder
            {
                get
                {
                    return this.BirthOrderField;
                }
                set
                {
                    this.BirthOrderField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DriveCertificate", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DriveCertificate : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "PrenatalDeathCertificate", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class PrenatalDeathCertificate : N3.EMK.Dto.MedRec.MedDoc.MedDocument
        {

            private System.Nullable<System.DateTime> CertificateDateField;

            private string CertificateSField;

            private string CertificateNField;

            private System.Nullable<System.DateTime> DeathDateField;

            private string CodeMainPrenatalField;

            private string CodeOtherPrenatalField;

            private string CodeMainMotherField;

            private string CodeOtherMotherField;

            private string DeathReasonPrenatalField;

            private string DeathReasonMotherField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> CertificateDate
            {
                get
                {
                    return this.CertificateDateField;
                }
                set
                {
                    this.CertificateDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string CertificateS
            {
                get
                {
                    return this.CertificateSField;
                }
                set
                {
                    this.CertificateSField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string CertificateN
            {
                get
                {
                    return this.CertificateNField;
                }
                set
                {
                    this.CertificateNField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public System.Nullable<System.DateTime> DeathDate
            {
                get
                {
                    return this.DeathDateField;
                }
                set
                {
                    this.DeathDateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public string CodeMainPrenatal
            {
                get
                {
                    return this.CodeMainPrenatalField;
                }
                set
                {
                    this.CodeMainPrenatalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public string CodeOtherPrenatal
            {
                get
                {
                    return this.CodeOtherPrenatalField;
                }
                set
                {
                    this.CodeOtherPrenatalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public string CodeMainMother
            {
                get
                {
                    return this.CodeMainMotherField;
                }
                set
                {
                    this.CodeMainMotherField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public string CodeOtherMother
            {
                get
                {
                    return this.CodeOtherMotherField;
                }
                set
                {
                    this.CodeOtherMotherField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public string DeathReasonPrenatal
            {
                get
                {
                    return this.DeathReasonPrenatalField;
                }
                set
                {
                    this.DeathReasonPrenatalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
            public string DeathReasonMother
            {
                get
                {
                    return this.DeathReasonMotherField;
                }
                set
                {
                    this.DeathReasonMotherField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedDocumentDto.DocumentAttachment", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class MedDocumentDtoDocumentAttachment : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte[] DataField;

            private byte[] OrganizationSignField;

            private N3.EMK.Dto.MedRec.MedDoc.MedDocumentDtoPersonalSign[] PersonalSignsField;

            private string MimeTypeField;

            private System.Uri UrlField;

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
            public byte[] Data
            {
                get
                {
                    return this.DataField;
                }
                set
                {
                    this.DataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public byte[] OrganizationSign
            {
                get
                {
                    return this.OrganizationSignField;
                }
                set
                {
                    this.OrganizationSignField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.MedDocumentDtoPersonalSign[] PersonalSigns
            {
                get
                {
                    return this.PersonalSignsField;
                }
                set
                {
                    this.PersonalSignsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string MimeType
            {
                get
                {
                    return this.MimeTypeField;
                }
                set
                {
                    this.MimeTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public System.Uri Url
            {
                get
                {
                    return this.UrlField;
                }
                set
                {
                    this.UrlField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Observation", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Observation : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int CodeField;

            private N3.EMK.Dto.MedRec.MedDoc.ValueQuantity ValueQuantityField;

            private System.DateTime DateTimeField;

            private string InterpretationField;

            private N3.EMK.Dto.MedRec.MedDoc.ReferenceRange[] ReferenceRangesField;

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
            public int Code
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
            public N3.EMK.Dto.MedRec.MedDoc.ValueQuantity ValueQuantity
            {
                get
                {
                    return this.ValueQuantityField;
                }
                set
                {
                    this.ValueQuantityField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public System.DateTime DateTime
            {
                get
                {
                    return this.DateTimeField;
                }
                set
                {
                    this.DateTimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public string Interpretation
            {
                get
                {
                    return this.InterpretationField;
                }
                set
                {
                    this.InterpretationField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public N3.EMK.Dto.MedRec.MedDoc.ReferenceRange[] ReferenceRanges
            {
                get
                {
                    return this.ReferenceRangesField;
                }
                set
                {
                    this.ReferenceRangesField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "MedDocumentDto.PersonalSign", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class MedDocumentDtoPersonalSign : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte[] SignField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

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
            public byte[] Sign
            {
                get
                {
                    return this.SignField;
                }
                set
                {
                    this.SignField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ValueQuantity", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.CodeableValue))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.NumericalValue))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.StringValue))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.FloatValue))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.BooleanValue))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.MedDoc.DateTimeValue))]
        public partial class ValueQuantity : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ReferenceRange", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class ReferenceRange : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private int RangeTypeField;

            private System.Nullable<int> IdUnitField;

            private string ValueField;

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
            public int RangeType
            {
                get
                {
                    return this.RangeTypeField;
                }
                set
                {
                    this.RangeTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.Nullable<int> IdUnit
            {
                get
                {
                    return this.IdUnitField;
                }
                set
                {
                    this.IdUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "CodeableValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class CodeableValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private System.Nullable<int> IdUnitField;

            private string ValueSystemField;

            private string ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<int> IdUnit
            {
                get
                {
                    return this.IdUnitField;
                }
                set
                {
                    this.IdUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string ValueSystem
            {
                get
                {
                    return this.ValueSystemField;
                }
                set
                {
                    this.ValueSystemField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "NumericalValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class NumericalValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private System.Nullable<int> IdUnitField;

            private int ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<int> IdUnit
            {
                get
                {
                    return this.IdUnitField;
                }
                set
                {
                    this.IdUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public int Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "StringValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class StringValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private string ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "FloatValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class FloatValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private System.Nullable<int> IdUnitField;

            private float ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<int> IdUnit
            {
                get
                {
                    return this.IdUnitField;
                }
                set
                {
                    this.IdUnitField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public float Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "BooleanValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class BooleanValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private bool ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DateTimeValue", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class DateTimeValue : N3.EMK.Dto.MedRec.MedDoc.ValueQuantity
        {

            private System.DateTime ValueField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime Value
            {
                get
                {
                    return this.ValueField;
                }
                set
                {
                    this.ValueField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "SickListInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class SickListInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string NumberField;

            private System.DateTime DateStartField;

            private N3.EMK.Dto.Guardian CaregiverField;

            private System.DateTime DateEndField;

            private byte DisabilityDocReasonField;

            private byte DisabilityDocStateField;

            private System.Nullable<bool> IsPatientTakerField;

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
            public string Number
            {
                get
                {
                    return this.NumberField;
                }
                set
                {
                    this.NumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.DateTime DateStart
            {
                get
                {
                    return this.DateStartField;
                }
                set
                {
                    this.DateStartField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public N3.EMK.Dto.Guardian Caregiver
            {
                get
                {
                    return this.CaregiverField;
                }
                set
                {
                    this.CaregiverField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public System.DateTime DateEnd
            {
                get
                {
                    return this.DateEndField;
                }
                set
                {
                    this.DateEndField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public byte DisabilityDocReason
            {
                get
                {
                    return this.DisabilityDocReasonField;
                }
                set
                {
                    this.DisabilityDocReasonField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public byte DisabilityDocState
            {
                get
                {
                    return this.DisabilityDocStateField;
                }
                set
                {
                    this.DisabilityDocStateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public System.Nullable<bool> IsPatientTaker
            {
                get
                {
                    return this.IsPatientTakerField;
                }
                set
                {
                    this.IsPatientTakerField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "HealthGroup", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class HealthGroup : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            private N3.EMK.Dto.MedRec.MedDoc.HealthGroupInfo HealthGroupInfoField;

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
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.MedDoc.HealthGroupInfo HealthGroupInfo
            {
                get
                {
                    return this.HealthGroupInfoField;
                }
                set
                {
                    this.HealthGroupInfoField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Recommendation", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class Recommendation : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private System.DateTime DateField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            private string TextField;

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
            public System.DateTime Date
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
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Text
            {
                get
                {
                    return this.TextField;
                }
                set
                {
                    this.TextField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "HealthGroupInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class HealthGroupInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte IdHealthGroupField;

            private System.DateTime DateField;

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
            public byte IdHealthGroup
            {
                get
                {
                    return this.IdHealthGroupField;
                }
                set
                {
                    this.IdHealthGroupField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.DateTime Date
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
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AssisNote", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class AssisNote : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private System.DateTime AssisTimestampField;

            private string MedAssistanceField;

            private string EffectField;

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
            public System.DateTime AssisTimestamp
            {
                get
                {
                    return this.AssisTimestampField;
                }
                set
                {
                    this.AssisTimestampField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MedAssistance
            {
                get
                {
                    return this.MedAssistanceField;
                }
                set
                {
                    this.MedAssistanceField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public string Effect
            {
                get
                {
                    return this.EffectField;
                }
                set
                {
                    this.EffectField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ReferralInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.MedDoc")]
        public partial class ReferralInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string ReasonField;

            private string IdReferralMisField;

            private byte IdReferralTypeField;

            private System.DateTime IssuedDateTimeField;

            private byte HospitalizationOrderField;

            private string MkbCodeField;

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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public byte IdReferralType
            {
                get
                {
                    return this.IdReferralTypeField;
                }
                set
                {
                    this.IdReferralTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public System.DateTime IssuedDateTime
            {
                get
                {
                    return this.IssuedDateTimeField;
                }
                set
                {
                    this.IssuedDateTimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public byte HospitalizationOrder
            {
                get
                {
                    return this.HospitalizationOrderField;
                }
                set
                {
                    this.HospitalizationOrderField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
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
        }
    }
    namespace N3.EMK.Dto.MedRec.Diag
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Diagnosis", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.Diag")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.ClinicMainDiagnosis))]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.AnatomopathologicalClinicMainDiagnosis))]
        public partial class Diagnosis : N3.EMK.Dto.MedRec.MedRecord
        {

            private N3.EMK.Dto.MedRec.Diag.DiagnosisInfo DiagnosisInfoField;

            private N3.EMK.Dto.MedicalStaff DoctorField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.Diag.DiagnosisInfo DiagnosisInfo
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

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedicalStaff Doctor
            {
                get
                {
                    return this.DoctorField;
                }
                set
                {
                    this.DoctorField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ClinicMainDiagnosis", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.Diag")]
        [System.Runtime.Serialization.KnownTypeAttribute(typeof(N3.EMK.Dto.MedRec.Diag.AnatomopathologicalClinicMainDiagnosis))]
        public partial class ClinicMainDiagnosis : N3.EMK.Dto.MedRec.Diag.Diagnosis
        {

            private N3.EMK.Dto.MedRec.Diag.Diagnosis[] ComplicationsField;

            [System.Runtime.Serialization.DataMemberAttribute()]
            public N3.EMK.Dto.MedRec.Diag.Diagnosis[] Complications
            {
                get
                {
                    return this.ComplicationsField;
                }
                set
                {
                    this.ComplicationsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "AnatomopathologicalClinicMainDiagnosis", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.Diag")]
        public partial class AnatomopathologicalClinicMainDiagnosis : N3.EMK.Dto.MedRec.Diag.ClinicMainDiagnosis
        {
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "DiagnosisInfo", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.MedRec.Diag")]
        public partial class DiagnosisInfo : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private byte IdDiseaseTypeField;

            private System.DateTime DiagnosedDateField;

            private byte IdDiagnosisTypeField;

            private string CommentField;

            private byte DiagnosisChangeReasonField;

            private byte DiagnosisStageField;

            private byte IdDispensaryStateField;

            private byte IdTraumaTypeField;

            private byte MESImplementationFeatureField;

            private int MedicalStandardField;

            private N3.EMK.Dto.MedRec.Param[] ParamsField;

            private string MkbCodeField;

            private System.Nullable<byte> DiseaseStatusField;

            private string MkbCodeChangeField;

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
            public byte IdDiseaseType
            {
                get
                {
                    return this.IdDiseaseTypeField;
                }
                set
                {
                    this.IdDiseaseTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public System.DateTime DiagnosedDate
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public byte IdDiagnosisType
            {
                get
                {
                    return this.IdDiagnosisTypeField;
                }
                set
                {
                    this.IdDiagnosisTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 4)]
            public byte DiagnosisChangeReason
            {
                get
                {
                    return this.DiagnosisChangeReasonField;
                }
                set
                {
                    this.DiagnosisChangeReasonField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 5)]
            public byte DiagnosisStage
            {
                get
                {
                    return this.DiagnosisStageField;
                }
                set
                {
                    this.DiagnosisStageField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 6)]
            public byte IdDispensaryState
            {
                get
                {
                    return this.IdDispensaryStateField;
                }
                set
                {
                    this.IdDispensaryStateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 7)]
            public byte IdTraumaType
            {
                get
                {
                    return this.IdTraumaTypeField;
                }
                set
                {
                    this.IdTraumaTypeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 8)]
            public byte MESImplementationFeature
            {
                get
                {
                    return this.MESImplementationFeatureField;
                }
                set
                {
                    this.MESImplementationFeatureField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 9)]
            public int MedicalStandard
            {
                get
                {
                    return this.MedicalStandardField;
                }
                set
                {
                    this.MedicalStandardField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 10)]
            public N3.EMK.Dto.MedRec.Param[] Params
            {
                get
                {
                    return this.ParamsField;
                }
                set
                {
                    this.ParamsField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 11)]
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

            [System.Runtime.Serialization.DataMemberAttribute(Order = 12)]
            public System.Nullable<byte> DiseaseStatus
            {
                get
                {
                    return this.DiseaseStatusField;
                }
                set
                {
                    this.DiseaseStatusField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 13)]
            public string MkbCodeChange
            {
                get
                {
                    return this.MkbCodeChangeField;
                }
                set
                {
                    this.MkbCodeChangeField = value;
                }
            }
        }
    }
    namespace N3.EMK.Dto.Common
    {
        using System.Runtime.Serialization;


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        public partial class RequestFault : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string PropertyNameField;

            private string MessageField;

            private int ErrorCodeField;

            private N3.EMK.Dto.Common.RequestFault[] ErrorsField;

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
            public string PropertyName
            {
                get
                {
                    return this.PropertyNameField;
                }
                set
                {
                    this.PropertyNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public string Message
            {
                get
                {
                    return this.MessageField;
                }
                set
                {
                    this.MessageField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int ErrorCode
            {
                get
                {
                    return this.ErrorCodeField;
                }
                set
                {
                    this.ErrorCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public N3.EMK.Dto.Common.RequestFault[] Errors
            {
                get
                {
                    return this.ErrorsField;
                }
                set
                {
                    this.ErrorsField = value;
                }
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        public partial class RequestWarning : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private string PropertyNameField;

            private string MessageField;

            private int WarningCodeField;

            private N3.EMK.Dto.Common.RequestWarning[] WarningsField;

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
            public string PropertyName
            {
                get
                {
                    return this.PropertyNameField;
                }
                set
                {
                    this.PropertyNameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 1)]
            public string Message
            {
                get
                {
                    return this.MessageField;
                }
                set
                {
                    this.MessageField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 2)]
            public int WarningCode
            {
                get
                {
                    return this.WarningCodeField;
                }
                set
                {
                    this.WarningCodeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute(Order = 3)]
            public N3.EMK.Dto.Common.RequestWarning[] Warnings
            {
                get
                {
                    return this.WarningsField;
                }
                set
                {
                    this.WarningsField = value;
                }
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IEmkService")]
    public interface IEmkService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceSupport/GetVersion", ReplyAction = "http://tempuri.org/IServiceSupport/GetVersionResponse")]
        N3.Shared.Core.VersionInfo GetVersion();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiceSupport/GetVersion", ReplyAction = "http://tempuri.org/IServiceSupport/GetVersionResponse")]
        System.Threading.Tasks.Task<N3.Shared.Core.VersionInfo> GetVersionAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddCase", ReplyAction = "http://tempuri.org/IEmkService/AddCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/AddCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/AddCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/AddCaseRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/AddCaseListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void AddCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddCase", ReplyAction = "http://tempuri.org/IEmkService/AddCaseResponse")]
        System.Threading.Tasks.Task AddCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CreateCase", ReplyAction = "http://tempuri.org/IEmkService/CreateCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/CreateCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/CreateCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/CreateCaseRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/CreateCaseListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void CreateCase(string guid, N3.EMK.Dto.Case.CaseBase createCaseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CreateCase", ReplyAction = "http://tempuri.org/IEmkService/CreateCaseResponse")]
        System.Threading.Tasks.Task CreateCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase createCaseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CloseCase", ReplyAction = "http://tempuri.org/IEmkService/CloseCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/CloseCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/CloseCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/CloseCaseRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/CloseCaseListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void CloseCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CloseCase", ReplyAction = "http://tempuri.org/IEmkService/CloseCaseResponse")]
        System.Threading.Tasks.Task CloseCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/UpdateCase", ReplyAction = "http://tempuri.org/IEmkService/UpdateCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/UpdateCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/UpdateCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/UpdateCaseRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/UpdateCaseListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void UpdateCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/UpdateCase", ReplyAction = "http://tempuri.org/IEmkService/UpdateCaseResponse")]
        System.Threading.Tasks.Task UpdateCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddMedRecord", ReplyAction = "http://tempuri.org/IEmkService/AddMedRecordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/AddMedRecordRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/AddMedRecordListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/AddMedRecordRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/AddMedRecordListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void AddMedRecord(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.MedRec.MedRecord medRecord, System.Nullable<byte> confidentiality);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddMedRecord", ReplyAction = "http://tempuri.org/IEmkService/AddMedRecordResponse")]
        System.Threading.Tasks.Task AddMedRecordAsync(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.MedRec.MedRecord medRecord, System.Nullable<byte> confidentiality);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddStepToCase", ReplyAction = "http://tempuri.org/IEmkService/AddStepToCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/AddStepToCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/AddStepToCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning), Action = "http://tempuri.org/IEmkService/AddStepToCaseRequestWarningFault", Name = "RequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestWarning[]), Action = "http://tempuri.org/IEmkService/AddStepToCaseListOf_RequestWarningFault", Name = "ArrayOfRequestWarning", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void AddStepToCase(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.Step.StepBase step);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/AddStepToCase", ReplyAction = "http://tempuri.org/IEmkService/AddStepToCaseResponse")]
        System.Threading.Tasks.Task AddStepToCaseAsync(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.Step.StepBase step);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CancelCase", ReplyAction = "http://tempuri.org/IEmkService/CancelCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault), Action = "http://tempuri.org/IEmkService/CancelCaseRequestFaultFault", Name = "RequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        [System.ServiceModel.FaultContractAttribute(typeof(N3.EMK.Dto.Common.RequestFault[]), Action = "http://tempuri.org/IEmkService/CancelCaseListOf_RequestFaultFault", Name = "ArrayOfRequestFault", Namespace = "http://schemas.datacontract.org/2004/07/N3.EMK.Dto.Common")]
        void CancelCase(string guid, string idLpu, string idPatientMis, string idCaseMis);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IEmkService/CancelCase", ReplyAction = "http://tempuri.org/IEmkService/CancelCaseResponse")]
        System.Threading.Tasks.Task CancelCaseAsync(string guid, string idLpu, string idPatientMis, string idCaseMis);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmkServiceChannel : IEmkService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmkServiceClient : System.ServiceModel.ClientBase<IEmkService>, IEmkService, INetrikaServiceClient
    {

        public EmkServiceClient()
        {
        }

        public EmkServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public EmkServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public EmkServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public EmkServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public N3.Shared.Core.VersionInfo GetVersion()
        {
            return base.Channel.GetVersion();
        }

        public System.Threading.Tasks.Task<N3.Shared.Core.VersionInfo> GetVersionAsync()
        {
            return base.Channel.GetVersionAsync();
        }

        public void AddCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            base.Channel.AddCase(guid, caseDto);
        }

        public System.Threading.Tasks.Task AddCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            return base.Channel.AddCaseAsync(guid, caseDto);
        }

        public void CreateCase(string guid, N3.EMK.Dto.Case.CaseBase createCaseDto)
        {
            base.Channel.CreateCase(guid, createCaseDto);
        }

        public System.Threading.Tasks.Task CreateCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase createCaseDto)
        {
            return base.Channel.CreateCaseAsync(guid, createCaseDto);
        }

        public void CloseCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            base.Channel.CloseCase(guid, caseDto);
        }

        public System.Threading.Tasks.Task CloseCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            return base.Channel.CloseCaseAsync(guid, caseDto);
        }

        public void UpdateCase(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            base.Channel.UpdateCase(guid, caseDto);
        }

        public System.Threading.Tasks.Task UpdateCaseAsync(string guid, N3.EMK.Dto.Case.CaseBase caseDto)
        {
            return base.Channel.UpdateCaseAsync(guid, caseDto);
        }

        public void AddMedRecord(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.MedRec.MedRecord medRecord, System.Nullable<byte> confidentiality)
        {
            base.Channel.AddMedRecord(guid, idLpu, idPatientMis, idCaseMis, medRecord, confidentiality);
        }

        public System.Threading.Tasks.Task AddMedRecordAsync(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.MedRec.MedRecord medRecord, System.Nullable<byte> confidentiality)
        {
            return base.Channel.AddMedRecordAsync(guid, idLpu, idPatientMis, idCaseMis, medRecord, confidentiality);
        }

        public void AddStepToCase(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.Step.StepBase step)
        {
            base.Channel.AddStepToCase(guid, idLpu, idPatientMis, idCaseMis, step);
        }

        public System.Threading.Tasks.Task AddStepToCaseAsync(string guid, string idLpu, string idPatientMis, string idCaseMis, N3.EMK.Dto.Step.StepBase step)
        {
            return base.Channel.AddStepToCaseAsync(guid, idLpu, idPatientMis, idCaseMis, step);
        }

        public void CancelCase(string guid, string idLpu, string idPatientMis, string idCaseMis)
        {
            base.Channel.CancelCase(guid, idLpu, idPatientMis, idCaseMis);
        }

        public System.Threading.Tasks.Task CancelCaseAsync(string guid, string idLpu, string idPatientMis, string idCaseMis)
        {
            return base.Channel.CancelCaseAsync(guid, idLpu, idPatientMis, idCaseMis);
        }
    }
}
