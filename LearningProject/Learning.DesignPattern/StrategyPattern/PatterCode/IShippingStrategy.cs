using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.StrategyPattern.PatterCode
{
    public interface IShippingStrategy
    {
        bool IsMatch(MyOrder order);
        double Calculate(MyOrder order);
    }
}
