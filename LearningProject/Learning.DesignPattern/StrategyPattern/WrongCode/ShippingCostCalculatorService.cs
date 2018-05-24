using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.StrategyPattern
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(MyOrder order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingOpteions.FedEx:
                    return CalculateForFedEx(order);
                case ShippingOpteions.UPS:
                    return CalculateForFedEx(order);
                case ShippingOpteions.Schenker:
                    return CalculateForFedEx(order);
                default:
                    Console.WriteLine("Unknown carrier");
                    return 0;
            }
        }
        double CalculateForSchenker(MyOrder order)
        {
            return 3.00d;
        }

        double CalculateForUPS(MyOrder order)
        {
            return 4.25d;
        }

        double CalculateForFedEx(MyOrder order)
        {
            return 5.00d;
        }
    }
}
