using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.Statepattern
{
    public class StatePatternDemo
    {
        public void TryStatePattern()
        {
            var order = new Order(new NewState());
            Console.WriteLine(order.Status);

            order.Ship();
            Console.WriteLine(order.Status);
            order.Cancel();
            Console.WriteLine(order.Status);
            order.Ship();
            Console.WriteLine(order.Status);
        }
    }
}
