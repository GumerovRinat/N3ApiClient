using N3ApiClient.IemkService.Abstractions;

namespace N3ApiClient.IemkService.ClientFactory
{
    public class EmkClientCreator : EmkClientFactory
    {
        public override IEmkClient CreateInstance()
        {
            return new EmkClient();
        }
    }
}
