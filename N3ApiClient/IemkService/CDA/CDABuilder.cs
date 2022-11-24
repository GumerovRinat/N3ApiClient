using System;
using System.Xml;
using N3ApiClient.IemkService.CDA.DataContracts.POCD_MT000040ClinicalDocument;
using N3ApiClient.Tools;

namespace N3ApiClient.IemkService.CDA
{
    public class CdaBuilder
    {
        private POCD_MT000040ClinicalDocument clinicalDocument;
        private XmlHelper xmlHelper;
        private string moUid;

        public CdaBuilder(string _moUid)
        {
            clinicalDocument = new POCD_MT000040ClinicalDocument();
            xmlHelper = new XmlHelper();
            moUid = _moUid;
        }

        /// <summary>
        /// Добавление Заголовка документа
        /// </summary>
        /// <param name="clinicalDocumentTemplateId">Идентификатор Шаблона</param>
        /// <param name="documentId">Уникальный идентификатор документа</param>
        /// <param name="documentCodeId">Тип документа (CE code)</param>
        /// <param name="documentName">Тип документа (CE displayName)</param>
        /// <param name="dateCreate">Дата создания документа</param>
        public CdaBuilder AddTitle(
            
            string clinicalDocumentTemplateId,
            string documentId,
            string documentCodeId,
            string documentName,
            DateTime dateCreate)
        {
            //R [1..1] Область применения документа (Страна)
            clinicalDocument.realmCode = new CS[] { new CS() { code = "RU" } };
            //R [1..1] Указатель на использование CDA R2
            clinicalDocument.typeId = new POCD_MT000040InfrastructureRoottypeId { root = "2.16.840.1.113883.1.3", extension = "POCD_MT000040" };
            //R [1..1] Идентификатор Шаблона "Руководство по реализации CDA (Release 2) уровень 3 МЕДИЦИНСКОЕ СВИДЕТЕЛЬСТВО О СМЕРТИ Редакция 5"
            clinicalDocument.templateId = new II[] { new II { root = clinicalDocumentTemplateId } };
            //R[1..1] Уникальный идентификатор документа
            clinicalDocument.id = new II { root = moUid + ".100.1.1.51", extension = documentId };
            //R [1..1] Тип документа
            clinicalDocument.code = new CE
            {
                code = documentCodeId,
                codeSystem = "1.2.643.5.1.13.13.11.1522",
                codeSystemVersion = "4.44",
                codeSystemName = "Виды медицинской документации",
                displayName = documentName
            };
            //R [1..1] Заголовок документа
            clinicalDocument.title = new ST { Text = new string[] { documentName } };
            //R [1..1] Дата создания документа
            clinicalDocument.effectiveTime = new TS { value = dateCreate.ToString("yyyyMMddHHmm+0300") };
            //R [1..1] Уровень конфиденциальности медицинского документа
            clinicalDocument.confidentialityCode = new CE
            {
                code = "N",
                codeSystem = "1.2.643.5.1.13.13.99.2.285",
                codeSystemName = "Уровень конфиденциальности медицинского документа",
                codeSystemVersion = "1.1",
                displayName = "обычный"
            };
            //R [1..1] Язык документа
            clinicalDocument.languageCode = new CS { code = "ru-RU" };
            //R [1..1] Уникальный идентификатор набора версий документа
            clinicalDocument.setId = new II
            {
                root = moUid + ".100.1.1.50",
                extension = documentId
            };
            //R [1..1] Номер версии данного документа
            //clinicalDocument.versionNumber = new INT { value = documentVersion };
            clinicalDocument.versionNumber = new INT { value = "1" };

            return this;
        }

        public CdaBuilder AddRecordTarget(
            string patientId,
            string patientSS,
            string seriesDoc,
            string numberDoc,
            string givePlaceDoc,
            DateTime dateDoc,
            string policySeries,
            string policyNumber,
            bool gender)
        {
            //POCD_MT000040RecordTarget recordTarget = new POCD_MT000040RecordTarget();
            ////R R [1..1] Пациент (роль)
            //POCD_MT000040PatientRole patientRole = new POCD_MT000040PatientRole();
            ////  R [1..1] Уникальный идентификатор пациента в МИС 
            //patientRole.id = GetPatientII(patientId, patientSS);

            ////R [1..1] ЛОКАЛЬНЫЙ ЭЛЕМЕНТ: Документ, удостоверяющий личность умершего, серия, номер, кем выдан.
            ////TODO:Сделать соответствие для всех остальных видов ДУЛ
            //patientRole.IdentityDoc = GetPatientIdentityDoc(seriesDoc, numberDoc, givePlaceDoc, dateDoc);

            ////<!-- [1..1] Полис ОМС -->
            //patientRole.InsurancePolicy = GetPatientInsurancePolicy(policySeries, policyNumber);

            ////<!-- [1..1] Адрес постоянной регистрации умершего -->
            //patientRole.addr = GetPatientAdressWhithFiasCode(address);

            ////<!-- [0..1] Адрес фактического места жительства пациента -->

            ////<!-- R [1..1] ПАЦИЕНТ (человек) -->
            //POCD_MT000040Patient patient = new POCD_MT000040Patient();
            ////<!-- R [1..1] ФИО пациента -->
            //patient.name = GetPatientName(family, name, ot, true);

            ////<!-- R [1..1] Пол пациента -->
            //patient.administrativeGenderCode = GetAdministrativeGenderCode(gender);

            ////<!--R[1..1] Дата рождения -->
            //patient.birthTime = new TS { value = dateBd.ToString("yyyyMMdd") };

            ////<!-- R [1..1] Идентификатор организации, констатировавшей факт смерти -->
            //POCD_MT000040Organization providerOrganization = GetProviderOrganisation();
            //patientRole.providerOrganization = providerOrganization;
            //patientRole.patient = patient;
            //recordTarget.patientRole = patientRole;
            return this;
        }





        public XmlDocument Build()
        {
            return xmlHelper.SerializeObject(clinicalDocument);
        }

        #region Вспомогательные методы
        /// <summary>
        /// Возвращает блок Id в patientRole
        /// </summary>
        /// <param name="patientId">Id пациента</param>
        /// <param name="patientSS">СНИЛС</param>
        /// <returns></returns>
        private II[] GetPatientII(string patientId, string patientSS)
        {
            II patId = new II()
            {
                root = moUid + ".100.1.1.10",
                extension = patientId
            };
            //R [1..1] СНИЛС пациента 
            II snilsId = new II
            {
                root = "1.2.643.100.3",
                extension = patientSS.Replace("-", "").Replace(" ", "")
            };
            return new II[] { patId, snilsId };
        }

        /// <summary>
        /// Возвращает блок IdentityDoc в patientRole
        /// </summary>
        /// <param name="seriesDoc"></param>
        /// <param name="numberDoc"></param>
        /// <param name="givePlaceDoc"></param>
        /// <param name="dateDoc"></param>
        /// <returns></returns>
        private POCD_MT000040IdentityDoc GetPatientIdentityDoc(string seriesDoc, string numberDoc, string givePlaceDoc, DateTime dateDoc)
        {
            POCD_MT000040IdentityDoc identityDoc = new POCD_MT000040IdentityDoc();
            identityDoc.IdentityCardType = new ANY_IDENTITY[]
            {
                new CD_IDENTITY
                {
                    code = "1",
                    codeSystem = "1.2.643.5.1.13.13.99.2.48",
                    codeSystemVersion = "2.1",
                    codeSystemName = "Документы, удостоверяющие личность",
                    displayName = "Паспорт гражданина Российской Федерации"
                }
            };

            identityDoc.Series = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { seriesDoc.Trim() } } };
            identityDoc.Number = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { numberDoc.Trim() } } };

            string[] doc = givePlaceDoc.Split(';');
            if (doc.Length > 1 && doc[0].Length > 0 && doc[1].Length > 0)
            {
                identityDoc.IssueOrgName = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { doc[0] } } };
                identityDoc.IssueOrgCode = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { doc[1] } } };
            }
            else
            {
                identityDoc.IssueOrgName = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { givePlaceDoc } } };
                identityDoc.IssueOrgCode = new ANY_IDENTITY[] { new ST_IDENTITY { nullFlavor = "NI" } };
            }

            identityDoc.IssueDate = new ANY_IDENTITY[] { new TS_IDENTITY { value = dateDoc.ToString("yyyyMMdd") } };
            return identityDoc;
        }

        /// <summary>
        /// Возвращает блок InsurancePolicy в patientRole
        /// </summary>
        /// <param name="policySeries"></param>
        /// <param name="policyNumber"></param>
        /// <returns></returns>
        private POCD_MT000040InsurancePolicy GetPatientInsurancePolicy(string policySeries, string policyNumber)
        {
            POCD_MT000040InsurancePolicy insurancePolicy = new POCD_MT000040InsurancePolicy();
            insurancePolicy.InsurancePolicyType = new ANY_IDENTITY[]
            {
                new CD_IDENTITY
                {
                    code = "2",
                    codeSystem = "1.2.643.5.1.13.13.11.1035",
                    codeSystemName = "Виды полиса обязательного медицинского страхования",
                    displayName = "Полис ОМС единого образца, бессрочный",
                    codeSystemVersion = "1.3"
                }
            };
            if (!String.IsNullOrEmpty(policySeries))
                insurancePolicy.Series = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { policySeries } } };
            else
                insurancePolicy.Series = new ANY_IDENTITY[] { new ST_IDENTITY { nullFlavor = "NA" } };

            if (!String.IsNullOrEmpty(policyNumber))
                insurancePolicy.Number = new ANY_IDENTITY[] { new ST_IDENTITY { Text = new string[] { policyNumber } } };
            else
                insurancePolicy.Number = new ANY_IDENTITY[] { new ST_IDENTITY { nullFlavor = "NA" } };
            return insurancePolicy;
        }

        /// <summary>
        /// Возвращает блок AdministrativeGenderCode в patient
        /// </summary>
        /// <param name="gender"></param>
        private CE GetAdministrativeGenderCode(bool gender)
        {
            CE gend = new CE();
            if (gender)
            {
                gend.code = "1";
                gend.displayName = "Мужской";
            }
            else
            {
                gend.code = "2";
                gend.displayName = "Женский";
            }
            gend.codeSystem = "1.2.643.5.1.13.13.11.1040";
            gend.codeSystemVersion = "2.1";
            gend.codeSystemName = "Пол пациента";
            return gend;
        }

        /// <summary>
        /// Получение адреса пациента с кодами ФИАС
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        public AD[] GetPatientAdressWhithFiasCode(
            string addressString,
            string stateCode,
            string postIndex,
            string stateName,
            string aoGuid,
            string houseGuid,
            bool nulFlag
            )
        {
            if (!nulFlag)
            {
                return new AD[]
                {
                    new AD
                    {
                        Type = new ANY_ADRES[]
                        {
                            new CD_ADRES
                            {
                                code = "1",
                                codeSystem = "1.2.643.5.1.13.13.11.1504",
                                codeSystemVersion = "1.3",
                                codeSystemName = "Тип адреса пациента",
                                displayName = "Адрес по месту жительства (постоянной регистрации)"
                            }
                        },
                        Items = new ADXP[]
                        {
                            new adxpstreetAddressLine { Text = new string[] { addressString } },
                            new adxpstate { Text = new string[] { stateCode } },
                            new adxppostalCode { Text = new string[] { postIndex } }
                        },
                        stateCode = new ANY_ADRES[]
                        {
                            new CD_ADRES
                            {
                                code = stateCode,
                                codeSystem = "1.2.643.5.1.13.13.99.2.206",
                                codeSystemName = "Субъекты Российской Федерации",
                                codeSystemVersion = "6.2",
                                displayName = stateName
                            }
                        },
                        Address = new Address
                        {
                            AOGUID = aoGuid,
                            HOUSEGUID = houseGuid
                        }
                    }
                };
            }
            else
            {
                return new AD[]
                {
                    new AD { nullFlavor = "NI" }
                };
            }
        }
        #endregion
    }
}
