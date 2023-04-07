using Hl7.Fhir.Model;
using N3ApiClient.OdliService.Dto;
using System.Collections.Generic;

namespace N3ApiClient.OdliService.Mappers
{
    public class BundleBuilder
    {
        private readonly Bundle _bundle;
        private readonly BundleRequestDto _bundleDto;
        private readonly List<Bundle.EntryComponent> _entries;

        public BundleBuilder(BundleRequestDto bundleDto)
        {
            _bundle = new Bundle();
            _bundleDto = bundleDto;
            _entries = new List<Bundle.EntryComponent>();
        }

        /// <summary>
        /// Метаинформация (meta.profile — ссылка на ресурс StructureDefinition.
        /// Необходимо всегда указывать ссылку на ресурс StructureDefinition 21f687dd-0b3b-4a7b-af8f-04be625c0201
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddMetaForResultWithoutOrder()
        {
            //Метаинформация (meta.profile — ссылка на ресурс StructureDefinition.
            //Необходимо всегда указывать ссылку на ресурс StructureDefinition
            AddMeta("21f687dd-0b3b-4a7b-af8f-04be625c0201");
            return this;
        }

        /// <summary>
        /// Метаинформация (meta.profile — ссылка на ресурс StructureDefinition.
        /// Необходимо всегда указывать ссылку на ресурс StructureDefinition cd45a667-bde0-490f-b602-8d780acf4aa2
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddMetaForOrder()
        {
            AddMeta("cd45a667-bde0-490f-b602-8d780acf4aa2");
            return this;
        }

        /// <summary>
        /// Ресурс Order предназначен для передачи общей информации о заявке
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddExistOrder()
        {
            var entry = new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_bundleDto.OrderId}",
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
                            System = $"urn:oid:{_bundleDto.SystemId}",
                            Value = _bundleDto.OrderMisId,
                            Assigner = new ResourceReference()
                            {
                                Reference = $"Organization/{_bundleDto.OrganisationId}"
                            }
                        }
                    },

                    //Дата заявки (yyyy-MM-ddTHH:mm:sszzz)
                    //Date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    Date = _bundleDto.DateOrder.ToString("yyyy-MM-ddTHH:mm:sszzz"),

                    //Соотнесение с пациентом.
                    Subject = new ResourceReference { Reference = $"Patient/{_bundleDto.PatientId}" },

                    //Соотнесение с автором заявки
                    Source = new ResourceReference { Reference = $"Practitioner/{_bundleDto.PractitionerId}" },

                    //Ссылка в формате Organization/GUID, где GUID – идентификатор организации по справочнику
                    //1.2.643.2.69.1.1.1.64 Соотнесение с целевой лабораторией.
                    Target = new ResourceReference { Reference = $"Organization/{_bundleDto.OrganisationId}" },

                    //Сведения о приоритете выполнения
                    When = new Order.WhenComponent
                    {
                        Code = new CodeableConcept
                        {
                            Coding = GetCoding("Routine", "1.2.643.2.69.1.1.1.30", "3")
                        }
                    },
                    Detail = new List<ResourceReference>()
                    {
                        //Ссылка. Соотнесение с клинической частью (DiagnosticOrder).
                        //Должен передаваться ресурс DiagnosticOrder в Bundle
                        new ResourceReference() { Reference = $"urn:uuid:{_bundleDto.DiagnosticOrderId}" }
                    }
                }
            };

            _entries.Add(entry);
            return this;
        }

        /// <summary>
        /// Ресурс Order предназначен для передачи общей информации о заявке
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddEmptyOrder()
        {
            var entry = new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_bundleDto.OrderId}",
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Order"
                },
                Resource = new Order()
                {
                    //Соотнесение с автором заявки
                    Source = new ResourceReference { Reference = $"Organization/{_bundleDto.OrganisationId}" },

                    //Ссылка в формате Organization/GUID, где GUID – идентификатор организации по справочнику
                    //1.2.643.2.69.1.1.1.64 Соотнесение с целевой лабораторией.
                    Target = new ResourceReference { Reference = $"Organization/{_bundleDto.OrganisationId}" },

                    Detail = new List<ResourceReference>()
                    {
                        //Ссылка. Соотнесение с клинической частью (DiagnosticOrder).
                        //Должен передаваться ресурс DiagnosticOrder в Bundle
                        new ResourceReference() { Reference = "" }
                    }
                }
            };
            _entries.Add(entry);
            return this;
        }

        /// <summary>
        /// Ресурс OrderResponse предназначен для передачи общей информации о результате исследований
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddEmptyOrderResponse()
        {
            var entry = new Bundle.EntryComponent();

            entry.FullUrl = "";
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "OrderResponse"
            };
            OrderResponse orderResp = new OrderResponse();

            //Идентификатор результата, передаваемого ЛИС в ОДЛИ. Должен быть уникален для данной МО
            orderResp.Identifier = new List<Identifier>()
            {
                new Identifier()
                {
                    System = _bundleDto.SystemId,
                    Value = _bundleDto.ResultMisId
                }
            };

            //Ссылка. Соотнесение с заявкой. Должна указываться ссылка на существующий в БД Order
            orderResp.Request = new ResourceReference()
            {
                Reference = $"urn:uuid:{_bundleDto.OrderId}"
            };

            //Дата-время авторизации результата
            orderResp.Date = _bundleDto.DateResult.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            //Ссылка. Соотнесение с лабораторией. Должна указываться ссылка на существующую в БД Organization
            orderResp.Who = new ResourceReference()
            {
                Reference = $"Organization/{_bundleDto.OrganisationId}"
            };

            //Статус выполнения заявки
            orderResp.OrderStatus_ = OrderResponse.OrderStatus.Completed;

            //Ссылка. Соотнесение с результатом по услуге. Должен передаваться ресурс DiagnosticReport
            orderResp.Fulfillment = new List<ResourceReference>()
            {
                new ResourceReference()
                {
                    Reference = $"urn:uuid:{_bundleDto.DiagnosticReport.Id}"
                }
            };

            entry.Resource = orderResp;
            _entries.Add(entry);
            return this;
        }

        /// <summary>
        /// В Bundle для передачи результата ресурс Observation предназначен для передачи результата теста
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddObservation()
        {
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = $"urn:uuid:{_bundleDto.Observation.Id}";
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
                        Code = _bundleDto.Observation.Interpretation.ToString()
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
                        Code = _bundleDto.Observation.LabTestCode
                    }
                }
            };

            //Дата-время выполнения теста
            observation.Issued = _bundleDto.Observation.DateIssued;

            //Ссылка. Соотнесение с врачом-исполнителем
            observation.Performer = new List<ResourceReference>
            {
                new ResourceReference() { Reference = $"Practitioner/{_bundleDto.PractitionerId}" }
            };

            //Текстовый результат теста
            //observation.Value = new FhirString
            //{
            //    Value = "848"
            //};
            observation.Value = new Quantity
            {
                Value = _bundleDto.Observation.ResultValue,
                Code = "136"
            };

            //Референтные значения для полученного результата. Должен иметь хотя бы нижнее(элемент low) либо
            //верхнее(элемент high) значение, либо элемент text
            observation.ReferenceRange = new List<Observation.ReferenceRangeComponent>
            {
                new Observation.ReferenceRangeComponent()
                {
                    Low = new SimpleQuantity { Value = _bundleDto.Observation.ReferenceLow, Code = "136" },
                    High = new SimpleQuantity {Value = _bundleDto.Observation.ReferenceHigh, Code = "136" }
                }
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

            entry.Resource = observation;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "Observation"
            };

            _entries.Add(entry);
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
            Bundle.EntryComponent entry = new Bundle.EntryComponent();

            entry.FullUrl = $"urn:uuid:{_bundleDto.DiagnosticReport.Id}";
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
                        Code = _bundleDto.DiagnosticReport.ServiceCode
                    }
                }
            };

            //Ссылка. Соотнесение с пациентом
            diagnosticReport.Subject = new ResourceReference() { Reference = $"Patient/{_bundleDto.PatientId}" };

            //Клинически значимое время результата: обычно дата-время сбора биоматериала(Specimen.collection.collectedDateTime),
            //если неизвестно(результат без заявки) -дата - время утверждения результата по услуге(DiagnosticReport.issued) –
            //для всех исследований, кроме гистологических
            diagnosticReport.Effective = new FhirDateTime() { Value = _bundleDto.DateResult.ToString("yyyy-MM-ddTHH:mm:ss.fff") };

            //Дата-время утверждения результата по услуге
            diagnosticReport.Issued = _bundleDto.Observation.DateIssued;

            //Ссылка. Соотнесение с врачом, утвердившим результат. Должен передаваться ресурс Practitioner в Bundle или
            //указывается ссылка на существующий Practitioner
            diagnosticReport.Performer = new ResourceReference()
            {
                Reference = $"Practitioner/{_bundleDto.PractitionerId}"
            };

            //Ссылка. Соотнесение с результатом теста. Должен передаваться ресурс Observation
            diagnosticReport.Result = new List<ResourceReference>() { new ResourceReference() { Reference = $"urn:uuid:{_bundleDto.Observation.Id}" } };

            //Ссылка на прикрепление
            diagnosticReport.PresentedForm = new List<Attachment>
            {
                new Attachment
                {
                    Url = $"urn:uuid:{_bundleDto.Binarys[0].Id}"
                }
            };

            entry.Resource = diagnosticReport;
            entry.Request = new Bundle.RequestComponent
            {
                Method = Bundle.HTTPVerb.POST,
                Url = "DiagnosticReport"
            };

            _entries.Add(entry);
            return this;
        }

        /// <summary>
        /// Создадим прикрепление результата
        /// </summary>
        /// <returns></returns>
        public BundleBuilder AddBinary()
        {
            var entry = new Bundle.EntryComponent
            {
                FullUrl = $"urn:uuid:{_bundleDto.Binarys[0].Id}",

                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.POST,
                    Url = "Binary"
                },

                Resource = new Binary
                {
                    ContentType = _bundleDto.Binarys[0].ContentType,
                    Content = _bundleDto.Binarys[0].Content
                }
            };
            _entries.Add(entry);
            return this;
        }

        public Bundle Build()
        {
            _bundle.Entry = _entries;
            return _bundle;
        }

        private void AddMeta(string structure)
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
    }

}
