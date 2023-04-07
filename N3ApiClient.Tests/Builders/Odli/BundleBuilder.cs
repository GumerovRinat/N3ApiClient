using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using N3ApiClient.OdliService.Dto;
using System;
using System.Collections.Generic;
using System.IO;

namespace N3ApiClient.Tests.Builders.Odli
{
    public class BundleBuilder
    {
        private Bundle _bundle;
        private List<Bundle.EntryComponent> _entries;

        //Значения идентификторов
        private string _orderMisId;
        private string _newOrderId;
        private string _encounterId;
        private string _encounterMisId;
        private string _newDiagnosticOrderId;
        private string _specimanId;
        private string _conditionId;
        private string _patientId = "Patient/abae7c44-9898-4f03-9213-6ecedd874e7f";
        private string _practicionerId = "Practitioner/a24ba513-b834-4784-bdf7-eb297f3a6b75";

        private string _orderId;
        private string _observationId;
        private string _misResultId;
        private string _orderResponseId;
        private string _diagnosticReportId;
        private string _dateResult;
        private string _diagnosticOrderId;
        private string _binaryId;

        public BundleBuilder()
        {
            _bundle = new Bundle();
            _entries = new List<Bundle.EntryComponent>();

            //Заполним значения идентификторов
            _orderMisId = Guid.NewGuid().ToString();
            _newOrderId = Guid.NewGuid().ToString();
            _encounterId = Guid.NewGuid().ToString();
            _encounterMisId = Guid.NewGuid().ToString();
            _newDiagnosticOrderId = Guid.NewGuid().ToString();
            _specimanId = Guid.NewGuid().ToString();
            _conditionId = Guid.NewGuid().ToString();
            _orderResponseId = Guid.NewGuid().ToString();

            //Заполним значения идентификторов
            _observationId = Guid.NewGuid().ToString();
            _misResultId = Guid.NewGuid().ToString();
            _orderId = "a41309e1-23c3-41c2-a15e-bdde06502b6f";
            _orderResponseId = Guid.NewGuid().ToString();
            _diagnosticReportId = Guid.NewGuid().ToString();
            _dateResult = "2023-03-11T12:52:44.945Z";
            _diagnosticOrderId = "DiagnosticOrder/a937e90c-1e48-415a-b1e1-db0f8bff9bf4";
            _binaryId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Добавление базовой заявки
        /// </summary>
        /// <returns></returns>
        public BundleBuilder CreateBaseAddBundle()
        {
            //Метаинформация (meta.profile — ссылка на ресурс StructureDefinition.
            //Необходимо всегда указывать ссылку на ресурс StructureDefinition с
            //идентификатором cd45a667-bde0-490f-b602-8d780acf4aa2
            CreateBaseBundle("cd45a667-bde0-490f-b602-8d780acf4aa2");
            return this;
        }

        /// <summary>
        /// Добавление базовой заявки
        /// </summary>
        /// <returns></returns>
        public BundleBuilder CreateBaseResultBundle()
        {
            //Метаинформация (meta.profile — ссылка на ресурс StructureDefinition.
            //Необходимо всегда указывать ссылку на ресурс StructureDefinition с
            //идентификатором 21f687dd-0b3b-4a7b-af8f-04be625c0201
            CreateBaseBundle("21f687dd-0b3b-4a7b-af8f-04be625c0201");
            return this;
        }

        /// <summary>
        /// Ресурс Order предназначен для передачи общей информации о заявке
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddOrder()
        {
            _entries.Add(GetOrderEntry());
            return this;
        }

        public BundleBuilder AddEmptyOrder()
        {
            _entries.Add(GetEmptyOrderEntry());
            return this;
        }

        /// <summary>
        /// Ресурс DiagnosticOrder предназначен для передачи информации о назначении и об
        /// источнике финансирования, ссылки на биоматериал, случай обслуживания, и ссылок на состояние пациента.
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddDiagnosticOrder()
        {
            //Ресурс DiagnosticOrder предназначен для передачи информации о назначении и об
            //источнике финансирования, ссылки на биоматериал, случай обслуживания, и ссылок на состояние пациента.
            _entries.Add(GetDiagnosticOrderEntry());
            return this;
        }

        /// <summary>
        /// Ресурс Specimen предназначен для передачи информации о забранном биоматериале
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddSpecimen()
        {
            _entries.Add(GetSpecimenEntry());
            return this;
        }

        /// <summary>
        /// Ресурс Encounter предназначен для передачи информации о случае обслуживания и ссылок на диагнозы пациента
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddEncounter()
        {
            _entries.Add(GetEncounterEntry());
            return this;
        }

        /// <summary>
        /// Ресурс Condition предназначен для передачи информации о состоянии пациента
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddCondition()
        {
            _entries.Add(GetConditionEntry());
            return this;
        }

        /// <summary>
        /// Ресурс OrderResponse предназначен для передачи общей информации о результате исследований
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddOrderResponse()
        {
            _entries.Add(GetOrderResponseEntry());
            return this;
        }

        /// <summary>
        /// Ресурс OrderResponse предназначен для передачи общей информации о результате исследований
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddEmptyOrderResponse()
        {
            _entries.Add(GetEmptyOrderResponseEntry());
            return this;
        }

        /// <summary>
        /// Ресурс DiagnosticReport предназначен для передачи информации о результате
        /// исследования в разрезе услуги и содержит ссылки на результаты каждого теста,
        /// выполненного по услуге
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddDiagnosticReport()
        {
            _entries.Add(GetDiagnosticReportEntry());
            return this;
        }

        /// <summary>
        /// Ресурс DiagnosticReport предназначен для передачи информации о результате
        /// исследования в разрезе услуги и содержит ссылки на результаты каждого теста,
        /// выполненного по услуге
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddEmptyDiagnosticReport()
        {
            _entries.Add(GetEmptyDiagnosticReportEntry());
            return this;
        }

        /// <summary>
        /// В Bundle для передачи результата ресурс Observation предназначен для передачи результата теста
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddObservation()
        {
            _entries.Add(GetObservationEntry());
            return this;
        }

        /// <summary>
        /// Создадим прикрепление результата
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddBinary()
        {
            _entries.Add(GetBinaryEntry());
            return this;
        }

        public Bundle Build()
        {
            _bundle.Entry = _entries;
            return _bundle;
        }

        private Bundle.EntryComponent GetOrderEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_newOrderId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Order"
                },
                Resource = new Order()
                {
                    Identifier = new List<Identifier>()
                    {
                        new Identifier()
                        {
                            System = $"urn:oid:{Constants.SYSTEM_ID}",
                            Value = _orderMisId,
                            Assigner = new ResourceReference()
                            {
                                Reference = Constants.ASSIGNER_RESOURCE
                            }
                        }
                    },

                    //Дата заявки (yyyy-MM-ddTHH:mm:sszzz)
                    //Date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    Date = new DateTime(2023, 3, 9, 8, 20, 0).ToString("yyyy-MM-ddTHH:mm:sszzz"),

                    //Соотнесение с пациентом.
                    Subject = new ResourceReference { Reference = _patientId },

                    //Соотнесение с автором заявки
                    Source = new ResourceReference { Reference = _practicionerId },

                    //Ссылка в формате Organization/GUID, где GUID – идентификатор организации по справочнику
                    //1.2.643.2.69.1.1.1.64 Соотнесение с целевой лабораторией.
                    Target = new ResourceReference { Reference = Constants.ASSIGNER_RESOURCE },

                    //Сведения о приоритете выполнения
                    When = new Order.WhenComponent
                    {
                        Code = new CodeableConcept
                        {
                           Coding  = GetCoding("Routine", "1.2.643.2.69.1.1.1.30", "3")
                        }
                    },
                    Detail = new List<ResourceReference>()
                    {
                        //Ссылка. Соотнесение с клинической частью (DiagnosticOrder).
                        //Должен передаваться ресурс DiagnosticOrder в Bundle
                        new ResourceReference() { Reference = $"urn:uuid:{_newDiagnosticOrderId}" }
                    }
                }
            };
        }

        private Bundle.EntryComponent GetEmptyOrderEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_newOrderId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Order"
                },
                Resource = new Order()
                {
                    //Соотнесение с автором заявки
                    Source = new ResourceReference { Reference = Constants.ASSIGNER_RESOURCE },

                    //Ссылка в формате Organization/GUID, где GUID – идентификатор организации по справочнику
                    //1.2.643.2.69.1.1.1.64 Соотнесение с целевой лабораторией.
                    Target = new ResourceReference { Reference = Constants.ASSIGNER_RESOURCE },

                    Detail = new List<ResourceReference>()
                    {
                        //Ссылка. Соотнесение с клинической частью (DiagnosticOrder).
                        //Должен передаваться ресурс DiagnosticOrder в Bundle
                        new ResourceReference() { Reference = "" }
                    }
                }
            };
        }

        private Bundle.EntryComponent GetDiagnosticOrderEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_newDiagnosticOrderId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST, 
                    Url = "DiagnosticOrder"
                },
                Resource = new DiagnosticOrder
                {
                    //Соотнесение с пациентом.
                    Subject = new ResourceReference { Reference = _patientId },

                    //Соотнесение с автором заявки
                    Orderer = new ResourceReference { Reference = _practicionerId },

                    //Соотнесение со случаем обслуживания
                    Encounter = new ResourceReference { Reference = $"urn:uuid:{_encounterId}" },

                    //Соотнесение с биоматериалом
                    Specimen = new List<ResourceReference> { new ResourceReference { Reference = $"urn:uuid:{_specimanId}" } },

                    //Статус DiagnosticOrder (справочник FHIR. OID справочника в сервисе Терминологии: 1.2.643.2.69.1.1.1.42).
                    //Всегда должен передаваться requested
                    Status = DiagnosticOrder.DiagnosticOrderStatus.Requested,

                    //Состав заявки
                    Item = new List<DiagnosticOrder.ItemComponent>()
                    {
                        new DiagnosticOrder.ItemComponent
                        {
                            //Сведения о запрашиваемой услуге
                            Code = new CodeableConcept
                            {
                                //Код услуги заявки (Номенклатура медицинских услуг) 1.2.643.2.69.1.1.1.31 или 1.2.643.5.1.13.13.11.1070
                                Coding = GetCoding("B03.016.004", "1.2.643.2.69.1.1.1.31", "124"),

                                //Источник финансирования
                                Extension = new List<Extension>
                                {
                                    new Extension
                                    {
                                        Url = "urn:oid:1.2.643.2.69.1.100.1",
                                        Value = new CodeableConcept
                                        {
                                            Coding = GetCoding("1", "1.2.643.2.69.1.1.1.32", "1")
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        private Bundle.EntryComponent GetSpecimenEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_specimanId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Specimen"
                },
                Resource = new Specimen
                {
                    //[1..1] Тип биоматериала (характер патологического процесса для гистологических исследований) 1.2.643.5.1.13.13.11.1081
                    Type = new CodeableConcept
                    {
                        Coding = GetCoding("105", "1.2.643.5.1.13.13.11.1081", "2.4")
                    },

                    //Соотнесение с пациентом.
                    Subject = new ResourceReference { Reference = _patientId },

                    //[0..1] Сведения о биоматериале
                    Collection = new Specimen.CollectionComponent
                    {
                        //Дата-время сбора биоматериала
                        Collected = new FhirDateTime { Value = "2023-03-09" }
                    },

                    //[0..1] Сведения о контейнере с биоматериалом (клиника, микробиология)
                    //Container = new List<Container>
                    //{
                    //    new Container
                    //    {

                    //    }
                    //}

                }
            };
        }

        private Bundle.EntryComponent GetEncounterEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_encounterId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Encounter"
                },
                Resource = new Encounter
                {
                    Identifier = new List<Identifier>
                    {
                        new Identifier
                        {
                            System = Constants.SYSTEM_ID,
                            Value = _encounterMisId
                        }
                    },
                    //Статус случая обслуживания (справочник FHIR. OID справочника в сервисе Терминологии: 1.2.643.2.69.1.1.1.43)
                    Status = Encounter.EncounterState.InProgress,

                    //Класс случая обслуживания (справочник FHIR. OID справочника в сервисе Терминологии: 1.2.643.2.69.1.1.1.44)
                    Class = Encounter.EncounterClass.Ambulatory,

                    //Тип случая обслуживания (региональный справочник типов случая обслуживания) 1.2.643.2.69.1.1.1.35
                    Type = new List<CodeableConcept>
                    {
                        new CodeableConcept
                        {
                            Coding = GetCoding("2", "1.2.643.2.69.1.1.1.35", "3")
                        }
                    },

                    //Соотнесение с пациентом.
                    Patient = new ResourceReference { Reference = _patientId },

                    //Ссылка. Соотнесение с кодом МО (или отделения)
                    ServiceProvider = new ResourceReference { Reference = Constants.ASSIGNER_RESOURCE },

                    //Соотнесение с диагнозами пациента. Должен передаваться ресурс Condition в Bundle
                    Indication = new List<ResourceReference>
                    {
                        new ResourceReference { Reference = $"urn:uuid:{_conditionId}" }
                    },

                    //Цель посещения (региональный справочник целей посещения) 1.2.643.2.69.1.1.1.19
                    Reason = new List<CodeableConcept>
                    {
                        new CodeableConcept { Coding = GetCoding("1", "1.2.643.2.69.1.1.1.19", "1") }
                    }

                }
            };
        }

        private Bundle.EntryComponent GetConditionEntry()
        {
            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_conditionId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Condition"
                },
                Resource = new Condition
                {
                    //Соотнесение с пациентом.
                    Patient = new ResourceReference { Reference = _patientId },

                    //В параметре system указывается OID справочника МКБ-10
                    Code = new CodeableConcept { Coding = GetCoding("Z01.7", "1.2.643.2.69.1.1.1.2", "62") },

                    //Указание типа ресурса (диагноз или признака менопаузы)
                    Category = new CodeableConcept { Coding = GetCoding("diagnosis", "1.2.643.2.69.1.1.1.36", "1") },

                    //Статус ресурса (справочник FHIR. OID справочника в сервисе Терминологии: 1.2.643.2.69.1.1.1.62).
                    //Передается «provisional» для предварительного диагноза, «confirmed» для окончательного
                    VerificationStatus = Condition.ConditionVerificationStatus.Confirmed
                }
            };
        }

        /// <summary>
        /// Ресурс OrderResponse предназначен для передачи общей информации о результате исследований
        /// </summary>
        /// <returns></returns>
        private Bundle.EntryComponent GetOrderResponseEntry()
        {
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = $"urn:uuid:{_orderResponseId}";
            OrderResponse orderResp = new OrderResponse();

            //Идентификатор результата, передаваемого ЛИС в ОДЛИ. Должен быть уникален для данной МО
            orderResp.Identifier = new List<Identifier>()
            {
                new Identifier()
                {
                    System = Constants.SYSTEM_ID,
                    Value = _misResultId
                }
            };

            //Ссылка. Соотнесение с заявкой. Должна указываться ссылка на существующий в БД Order
            orderResp.Request = new ResourceReference()
            {
                Reference = $"Order/{_orderId}"
            };

            //Дата-время авторизации результата
            orderResp.Date = _dateResult;

            //Ссылка. Соотнесение с лабораторией. Должна указываться ссылка на существующую в БД Organization
            orderResp.Who = new ResourceReference()
            {
                Reference = Constants.ASSIGNER_RESOURCE
            };

            //Статус выполнения заявки
            orderResp.OrderStatus_ = OrderResponse.OrderStatus.Accepted;

            //Ссылка. Соотнесение с результатом по услуге. Должен передаваться ресурс DiagnosticReport
            orderResp.Fulfillment = new List<ResourceReference>()
            {
                new ResourceReference()
                {
                    Reference = $"urn:uuid:{_diagnosticReportId}"
                }
            };

            entry.Resource = orderResp;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "OrderResponse"
            };
            return entry;
        }

        /// <summary>
        /// Ресурс OrderResponse предназначен для передачи общей информации о результате исследований
        /// </summary>
        /// <returns></returns>
        private Bundle.EntryComponent GetEmptyOrderResponseEntry()
        {
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = "";
            OrderResponse orderResp = new OrderResponse();

            //Идентификатор результата, передаваемого ЛИС в ОДЛИ. Должен быть уникален для данной МО
            orderResp.Identifier = new List<Identifier>()
            {
                new Identifier()
                {
                    System = Constants.SYSTEM_ID,
                    Value = _misResultId
                }
            };

            //Ссылка. Соотнесение с заявкой. Должна указываться ссылка на существующий в БД Order
            orderResp.Request = new ResourceReference()
            {
                Reference = $"urn:uuid:{_newOrderId}"
            };

            //Дата-время авторизации результата
            orderResp.Date = _dateResult;

            //Ссылка. Соотнесение с лабораторией. Должна указываться ссылка на существующую в БД Organization
            orderResp.Who = new ResourceReference()
            {
                Reference = Constants.ASSIGNER_RESOURCE
            };

            //Статус выполнения заявки
            orderResp.OrderStatus_ = OrderResponse.OrderStatus.Completed;

            //Ссылка. Соотнесение с результатом по услуге. Должен передаваться ресурс DiagnosticReport
            orderResp.Fulfillment = new List<ResourceReference>()
            {
                new ResourceReference()
                {
                    Reference = $"urn:uuid:{_diagnosticReportId}"
                }
            };

            entry.Resource = orderResp;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "OrderResponse"
            };
            return entry;
        }


        /// <summary>
        /// Ресурс DiagnosticReport предназначен для передачи информации о результате
        /// исследования в разрезе услуги и содержит ссылки на результаты каждого теста,
        /// выполненного по услуге
        /// </summary>
        /// <returns></returns>
        private Bundle.EntryComponent GetDiagnosticReportEntry()
        {
            var entry = GetEmptyDiagnosticReportEntry();
            //Ссылка. Соотнесение с назначением (DiagnosticOrder). Должна указываться ссылка на существующий в БД DiagnosticOrder.
            //Не передается в результате без заявки
            ((DiagnosticReport)entry.Resource).Request = new List<ResourceReference> { new ResourceReference() { Reference = _diagnosticOrderId } };
            return entry;
        }

        private Bundle.EntryComponent GetEmptyDiagnosticReportEntry()
        {
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = $"urn:uuid:{_diagnosticReportId}";
            DiagnosticReport diagnosticReport = new DiagnosticReport();

            //Метаданные ресурса с данными об уровне доступа к результату исследования
            //N – обычный, R - ограниченный, V - крайне ограниченный
            diagnosticReport.Meta = new Meta
            {
                Security = new List<Coding>
                {
                    new Coding { Code = "N" }
                }
            };

            //Статус результата. Передается status = final для выполненного исследования, cancelled для невыполненного
            //(отмена на стороне ЛИС) исследования
            diagnosticReport.Status = DiagnosticReport.DiagnosticReportStatus.Final;

            //Код услуги результата (Номенклатура медицинских услуг) 1.2.643.5.1.13.13.11.1070
            diagnosticReport.Code = new CodeableConcept()
            {
                Coding = new List<Coding>()
                {
                    new Coding
                    {
                        System = "urn:oid:1.2.643.2.69.1.1.1.31",
                        Version = "124",
                        Code = "A12.06.001.002"
                    }
                }
            };

            //Ссылка. Соотнесение с пациентом
            diagnosticReport.Subject = new ResourceReference()
            {
                Reference = _patientId
            };

            //Клинически значимое время результата: обычно дата-время сбора биоматериала(Specimen.collection.collectedDateTime),
            //если неизвестно(результат без заявки) -дата - время утверждения результата по услуге(DiagnosticReport.issued) –
            //для всех исследований, кроме гистологических
            diagnosticReport.Effective = new FhirDateTime() { Value = _dateResult };

            //Дата-время утверждения результата по услуге
            diagnosticReport.Issued = DateTimeOffset.Now;

            //Ссылка. Соотнесение с врачом, утвердившим результат. Должен передаваться ресурс Practitioner в Bundle или
            //указывается ссылка на существующий Practitioner
            diagnosticReport.Performer = new ResourceReference()
            {
                Reference = _practicionerId
            };

            //Ссылка. Соотнесение с результатом теста. Должен передаваться ресурс Observation
            diagnosticReport.Result = new List<ResourceReference>() { new ResourceReference() { Reference = $"urn:uuid:{_observationId}" } };

            //Ссылка на прикрепление
            diagnosticReport.PresentedForm = new List<Attachment>
            {
                new Attachment
                {
                    Url = $"urn:uuid:{_binaryId}"
                }
            };

            entry.Resource = diagnosticReport;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "DiagnosticReport"
            };
            return entry;
        }

        private Bundle.EntryComponent GetObservationEntry()
        {
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = $"urn:uuid:{_observationId}";
            Observation observation = new Observation();

            //Интерпретация результата теста: норма или выход за границы норм
            observation.Interpretation = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "urn:oid:1.2.643.5.1.13.13.11.1381",
                        Version = "1.1",
                        Code = "N"
                    }
                }
            };

            //Статус ресурса (справочник FHIR. OID справочника в сервисе Терминологии: 1.2.643.2.69.1.1.1.47).
            //Всегда передается статус final
            observation.Status = Observation.ObservationStatus.Final;

            //Код, для которого передается результат в Observation
            //В параметре system указывается OID справочника в сервисе Терминологии
            observation.Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "urn:oid:1.2.643.5.1.13.13.11.1080",
                        Version = "3.37",
                        Code = "1170570"
                    }
                }
            };

            //Дата-время выполнения теста
            observation.Issued = DateTimeOffset.Now;

            //Ссылка. Соотнесение с врачом-исполнителем
            observation.Performer = new List<ResourceReference>
            {
                new ResourceReference() { Reference = _practicionerId }
            };

            //Текстовый результат теста
            //observation.Value = new FhirString
            //{
            //    Value = "848"
            //};
            observation.Value = new Quantity
            {
                Value = 848,
                Code = "136"
            };



            //Методика исследования и/или использованные материалы 1.2.643.2.69.1.1.1.76 или 1.2.643.5.1.13.13.99.2.660
            observation.Method = new CodeableConcept()
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "urn:oid:1.2.643.2.69.1.1.1.76",
                        Version = "2",
                        Code = "1"
                    }
                }
            };

            //Референтные значения для полученного результата. Должен иметь хотя бы нижнее(элемент low) либо
            //верхнее(элемент high) значение, либо элемент text
            observation.ReferenceRange = new List<Observation.ReferenceRangeComponent>
            {
                new Observation.ReferenceRangeComponent()
                {
                    Low = new SimpleQuantity { Value = 500, Code = "136" },
                    High = new SimpleQuantity {Value = 1000, Code = "136" }
                }
            };


            entry.Resource = observation;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "Observation"
            };
            return entry;
        }

        private Bundle.EntryComponent GetBinaryEntry()
        {
            string filePath = @"D:\Result.pdf";
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            byte[] buffer = File.ReadAllBytes(filePath);

            return new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_binaryId}",

                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Binary"
                },

                Resource = new Binary
                {
                    ContentType = BinaryContentType.REMD_PDF,
                    Content = buffer
                }
            };
        }

        private List<Coding> GetCoding(string code, string oid, string version)
        {
            return new List<Coding>
            {
                new Coding
                {
                    Code = code,
                    System = $"urn:oid:{oid}",
                    Version = version
                }
            };
        }

        private void CreateBaseBundle(string structure)
        {
            _bundle.Meta = new Meta
            {
                Profile = new List<string>()
                {
                    $"StructureDefinition/{structure}"
                }
            };
            _bundle.Type = Bundle.BundleType.Transaction;
        }
    }
}
