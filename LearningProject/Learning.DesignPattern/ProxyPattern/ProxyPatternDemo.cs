using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ProxyPattern
{
    public class ProxyPatternDemo
    {
        public void TryProxyPattern()
        {
            var proxy = new ProxyClient();
            Console.WriteLine($"Data from Proxy Client = {proxy.GetData()}");
        }
}
}
