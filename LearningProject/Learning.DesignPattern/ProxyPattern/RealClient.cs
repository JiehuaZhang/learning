using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ProxyPattern
{
    public class RealClient :IClient
    {
        private readonly string Data;

        public RealClient()
        {
            Data = "Dot Net Tricks";
        }

        public string GetData()
        {
            return Data;
        }
    }
}
