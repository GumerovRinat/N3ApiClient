using System;
using System.Collections.Generic;

namespace N3ApiClient.OdliService.Dto
{
    public class BundleRequestDto
    {
        public string StructureDefinitionId { get; set; }

        public string OrderId { get; set;}

        public string OrganisationId { get; set;}

        public string SystemId { get; set;}

        public string OrderMisId { get; set;}

        public DateTime DateOrder { get; set;}

        public string PatientId { get; set;}

        public string PractitionerId { get; set;}

        public string DiagnosticOrderId { get; set;}

        public string ResultMisId { get; set;}

        public DateTime DateResult { get; set; }

        public ObservationDto Observation { get; set; }

        public DiagnosticReportDto DiagnosticReport { get; set;}

        public List<BinaryDto> Binarys { get; set;}
    }
}
