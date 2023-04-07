namespace N3ApiClient.OdliService.Dto
{
    public class BinaryDto
    {
        public string Id { get; set; }

        public byte[] Content { get; set; }

        public string ContentType { get; set; }

        public string DocumentTypeCode { get; set; }
    }
}
