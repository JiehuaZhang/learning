using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DesignPattern.StrategyPattern.PatterCode
{
    public class CostCalculationService_WithStrategy
    {
        private readonly List<IShippingStrategy> _shippingMethod;
        public CostCalculationService_WithStrategy()
        {
            _shippingMethod = new List<IShippingStrategy>
            {
                new FedexShippingStrategy(),
                new SchenkerShippingStrategy(),
                new UpsShippingStrategy()
            };
        }

        public double CalculateShippingCost(MyOrder order)
        {
            return _shippingMethod.First(x=>x.IsMatch(order)).Calculate(order);
        }

    }
}
