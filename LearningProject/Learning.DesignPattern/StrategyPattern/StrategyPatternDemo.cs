using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.DesignPattern.StrategyPattern.PatterCode;

namespace Learning.DesignPattern.StrategyPattern
{
    public class StrategyPatternDemo
    {
      
        public void TryStrategyPattern()
        {
            var newOrder1 = new MyOrder{ShippingMethod = ShippingOpteions.FedEx};
            var newOrder2 = new MyOrder{ShippingMethod = ShippingOpteions.UPS};
            var newOrder3 = new MyOrder{ ShippingMethod = ShippingOpteions.Schenker};
            
            var shippingCostService = new CostCalculationService_WithStrategy();
            var shippingPrice1 = shippingCostService.CalculateShippingCost(newOrder1);
            var shippingPrice2 = shippingCostService.CalculateShippingCost(newOrder2);
            var shippingPrice3 = shippingCostService.CalculateShippingCost(newOrder3);
            Console.WriteLine(shippingPrice1);
            Console.WriteLine(shippingPrice2);
            Console.WriteLine(shippingPrice3);
        }
    }
}
