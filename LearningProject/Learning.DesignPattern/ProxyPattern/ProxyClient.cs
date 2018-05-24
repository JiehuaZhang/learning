using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ProxyPattern
{
    public class ProxyClient : IClient
    {
        private readonly RealClient client = new RealClient();

        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}
