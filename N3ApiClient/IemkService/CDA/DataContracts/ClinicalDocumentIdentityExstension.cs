using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.IemkService.CDA.DataContracts.POCD_MT000040ClinicalDocument
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HXIT_CE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVLevent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CV))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CD", Namespace = "urn:hl7-ru:identity")]
    public partial class CD_IDENTITY : ANY_IDENTITY
    {

        private ED originalTextField;

        private CR[] qualifierField;

        private CD[] translationField;

        private string codeField;

        private string codeSystemField;

        private string codeSystemNameField;

        private string codeSystemVersionField;

        private string displayNameField;

        /// <remarks/>
        public ED originalText
        {
            get
            {
                return this.originalTextField;
            }
            set
            {
                this.originalTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("qualifier")]
        public CR[] qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("translation")]
        public CD[] translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSystem
        {
            get
            {
                return this.codeSystemField;
            }
            set
            {
                this.codeSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSystemName
        {
            get
            {
                return this.codeSystemNameField;
            }
            set
            {
                this.codeSystemNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSystemVersion
        {
            get
            {
                return this.codeSystemVersionField;
            }
            set
            {
                this.codeSystemVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpprecinct))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostBox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcensusTract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcareOf))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdirection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumber))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostalCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcounty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcountry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ST", Namespace = "urn:hl7-ru:identity")]
    public partial class ST_IDENTITY : ED_IDENTITY
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpprecinct))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostBox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcensusTract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcareOf))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdirection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumber))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostalCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcounty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcountry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(thumbnail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ED", Namespace = "urn:hl7-ru:identity")]
    public partial class ED_IDENTITY : BIN_IDENTITY
    {

        private TEL referenceField;

        private thumbnail thumbnailField;

        private string mediaTypeField;

        private string languageField;

        private CompressionAlgorithm compressionField;

        private bool compressionFieldSpecified;

        private byte[] integrityCheckField;

        private IntegrityCheckAlgorithm integrityCheckAlgorithmField;

        public ED_IDENTITY()
        {
            this.mediaTypeField = "text/plain";
            this.integrityCheckAlgorithmField = IntegrityCheckAlgorithm.SHA1;
        }

        /// <remarks/>
        public TEL reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public thumbnail thumbnail
        {
            get
            {
                return this.thumbnailField;
            }
            set
            {
                this.thumbnailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("text/plain")]
        public string mediaType
        {
            get
            {
                return this.mediaTypeField;
            }
            set
            {
                this.mediaTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CompressionAlgorithm compression
        {
            get
            {
                return this.compressionField;
            }
            set
            {
                this.compressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compressionSpecified
        {
            get
            {
                return this.compressionFieldSpecified;
            }
            set
            {
                this.compressionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] integrityCheck
        {
            get
            {
                return this.integrityCheckField;
            }
            set
            {
                this.integrityCheckField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(IntegrityCheckAlgorithm.SHA1)]
        public IntegrityCheckAlgorithm integrityCheckAlgorithm
        {
            get
            {
                return this.integrityCheckAlgorithmField;
            }
            set
            {
                this.integrityCheckAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpprecinct))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostBox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcensusTract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcareOf))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdirection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumber))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostalCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcounty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcountry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(thumbnail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BIN", Namespace = "urn:hl7-ru:identity")]
    public abstract partial class BIN_IDENTITY : ANY_IDENTITY
    {

        private BinaryDataEncoding representationField;

        private string[] textField;

        public BIN_IDENTITY()
        {
            this.representationField = BinaryDataEncoding.TXT;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BinaryDataEncoding.TXT)]
        public BinaryDataEncoding representation
        {
            get
            {
                return this.representationField;
            }
            set
            {
                this.representationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UVP_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXPR_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TS", Namespace = "urn:hl7-ru:identity")]
    public partial class TS_IDENTITY : QTY_IDENTITY
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_MO_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_PQ_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_QTY_QTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(POCD_MT000040RegionOfInterestvalue))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQ_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HXIT_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UVP_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_TS_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_TS_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXPR_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS_IDENTITY))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QTY", Namespace = "urn:hl7-ru:identity")]
    public abstract partial class QTY_IDENTITY : ANY_IDENTITY
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HXIT_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PQ", Namespace = "urn:hl7-ru:identity")]
    public partial class PQ_IDENTITY : QTY_IDENTITY
    {

        private PQR[] translationField;

        private string valueField;

        private string unitField;

        public PQ_IDENTITY()
        {
            this.unitField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("translation")]
        public PQR[] translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IVL_TS", Namespace = "urn:hl7-ru:identity")]
    public partial class IVL_TS_IDENTITY : SXCM_TS_IDENTITY
    {

        private QTY_IDENTITY[] itemsField;

        private ItemsChoiceType2_IDENTITY[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center", typeof(TS_IDENTITY))]
        [System.Xml.Serialization.XmlElementAttribute("high", typeof(IVXB_TS_IDENTITY))]
        [System.Xml.Serialization.XmlElementAttribute("low", typeof(IVXB_TS_IDENTITY))]
        [System.Xml.Serialization.XmlElementAttribute("width", typeof(PQ_IDENTITY))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public QTY_IDENTITY[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2_IDENTITY[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IVXB_TS", Namespace = "urn:hl7-ru:identity")]
    public partial class IVXB_TS_IDENTITY : TS_IDENTITY
    {

        private bool inclusiveField;

        public IVXB_TS_IDENTITY()
        {
            this.inclusiveField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS_IDENTITY))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SXCM_TS", Namespace = "urn:hl7-ru:identity")]
    public partial class SXCM_TS_IDENTITY : TS_IDENTITY
    {

        private SetOperator operatorField;

        public SXCM_TS_IDENTITY()
        {
            this.operatorField = SetOperator.I;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SetOperator.I)]
        public SetOperator @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CD_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TS_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS_IDENTITY))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ANY", Namespace = "urn:hl7-ru:identity")]
    public abstract partial class ANY_IDENTITY
    {

        private string nullFlavorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "POCD_MT000040.IdentityDoc", Namespace = "urn:hl7-ru:identity")]
    public partial class POCD_MT000040IdentityDoc
    {
        private ANY_IDENTITY[] identityCardTypeField;

        private ANY_IDENTITY[] seriesField;

        private ANY_IDENTITY[] numberField;

        private ANY_IDENTITY[] issueOrgNameField;

        private ANY_IDENTITY[] issueOrgCodeField;

        private ANY_IDENTITY[] issueDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityCardType", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IdentityCardType
        {
            get
            {
                return this.identityCardTypeField;
            }
            set
            {
                this.identityCardTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IdentityCardTypeId", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IdentityCardTypeId
        {
            get
            {
                return this.identityCardTypeField;
            }
            set
            {
                this.identityCardTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Series", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Number", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IssueOrgName", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IssueOrgName
        {
            get
            {
                return this.issueOrgNameField;
            }
            set
            {
                this.issueOrgNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IssueOrgCode", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IssueOrgCode
        {
            get
            {
                return this.issueOrgCodeField;
            }
            set
            {
                this.issueOrgCodeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "POCD_MT000040.DocInfo", Namespace = "urn:hl7-ru:identity")]
    public partial class POCD_MT000040DocInfo
    {
        private ANY_IDENTITY[] identityDocTypeField;

        private ANY_IDENTITY[] insurancePolicyTypeField;

        private ANY_IDENTITY[] seriesField;

        private ANY_IDENTITY[] numberField;

        private ANY_IDENTITY[] innField;

        private ANY_IDENTITY[] effectiveTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityDocType", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] IdentityDocType
        {
            get
            {
                return this.identityDocTypeField;
            }
            set
            {
                this.identityDocTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("InsurancePolicyType", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] InsurancePolicyType
        {
            get
            {
                return this.insurancePolicyTypeField;
            }
            set
            {
                this.insurancePolicyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Series", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Number", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INN", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] INN
        {
            get
            {
                return this.innField;
            }
            set
            {
                this.innField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("effectivetime", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] effectivetime
        {
            get
            {
                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "POCD_MT000040.InsurancePolicy", Namespace = "urn:hl7-ru:identity")]
    public partial class POCD_MT000040InsurancePolicy
    {
        private ANY_IDENTITY[] insurancePolicyTypeField;

        private ANY_IDENTITY[] seriesField;

        private ANY_IDENTITY[] numberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InsurancePolicyType", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] InsurancePolicyType
        {
            get
            {
                return this.insurancePolicyTypeField;
            }
            set
            {
                this.insurancePolicyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Series", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Number", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "POCD_MT000040.Props", Namespace = "urn:hl7-ru:identity")]
    public partial class POCD_MT000040Props
    {
        private ANY_IDENTITY[] ogrnField;

        private ANY_IDENTITY[] okatoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ogrn", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Ogrn
        {
            get
            {
                return ogrnField;
            }
            set
            {
                ogrnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Okato", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Okato
        {
            get
            {
                return okatoField;
            }
            set
            {
                okatoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "POCD_MT000040.PatientName", Namespace = "urn:hl7-org:v3")]
    public partial class POCD_MT000040PatientName : EN
    {
        private ANY_IDENTITY[] patronymicField;

        [System.Xml.Serialization.XmlElementAttribute("Patronymic", Namespace = "urn:hl7-ru:identity")]
        public ANY_IDENTITY[] Patronymic
        {
            get
            {
                return patronymicField;
            }
            set
            {
                patronymicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:hl7-ru:identity", IncludeInSchema = false)]
    public enum ItemsChoiceType2_IDENTITY
    {

        /// <remarks/>
        center,

        /// <remarks/>
        high,

        /// <remarks/>
        low,

        /// <remarks/>
        width,
    }

}
