using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.StrategyPattern.PatterCode
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public bool IsMatch(MyOrder order)
        {
            return order.ShippingMethod == ShippingOpteions.UPS;
        }

        public double Calculate(MyOrder order)
        {
            return 4.25d;
        }
    }
}
