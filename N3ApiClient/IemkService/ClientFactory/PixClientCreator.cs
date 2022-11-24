using N3ApiClient.IemkService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3ApiClient.IemkService.ClientFactory
{
    public class PixClientCreator : PixClientFactory
    {
        public override IPixClient CreateInstance()
        {
            return new PixClient();
        }
    }
}
