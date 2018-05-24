namespace Learning.DesignPattern.StrategyPattern.PatterCode
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public bool IsMatch(MyOrder order)
        {
            return order.ShippingMethod == ShippingOpteions.FedEx;
        }

        public double Calculate(MyOrder order)
        {
            return 5.00d;
        }
    }
}
