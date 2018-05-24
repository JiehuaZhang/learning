using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.StrategyPattern
{
    public class MyOrder
    {
        public ShippingOpteions ShippingMethod { get; set; }
        public Address Desination { get; set; }
        public Address Origin { get; set; }
    }
}
