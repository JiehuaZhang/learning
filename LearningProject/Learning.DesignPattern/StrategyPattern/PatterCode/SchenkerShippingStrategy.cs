using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.StrategyPattern.PatterCode
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public bool IsMatch(MyOrder order)
        {
            return order.ShippingMethod == ShippingOpteions.Schenker;
        }

        public double Calculate(MyOrder order)
        {
            return 3.00d;
        }
    }
}
