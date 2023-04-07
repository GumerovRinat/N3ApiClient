using System;

namespace N3ApiClient.OdliService.Dto
{
    public class ObservationDto
    {
        /// <summary>
        /// ИД Результата
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Интерпретация результата теста: норма или выход за границы норм
        /// </summary>
        public Interpretation Interpretation { get; set; }

        /// <summary>
        /// Код, для которого передается результат в Observation (1.2.643.5.1.13.13.11.1080)
        /// </summary>
        public string LabTestCode { get; set; }

        /// <summary>
        /// Дата-время выполнения теста
        /// </summary>
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Результат теста
        /// </summary>
        public decimal ResultValue { get; set; }

        /// <summary>
        /// Референсное значение Верх
        /// </summary>
        public decimal ReferenceHigh { get; set; }

        /// <summary>
        /// Референсное значение Низ
        /// </summary>
        public decimal ReferenceLow { get; set; }
    }

    public enum Interpretation 
    {
        N,
        H,
        L
    }
}
