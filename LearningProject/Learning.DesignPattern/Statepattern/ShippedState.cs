using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.Statepattern
{
    public class ShippedState : IOrderState
    {
        public OrderStatus Status =>OrderStatus.Shipped;    
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Already shipped.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Already shipped, cannot cancel.");
        }
    }
}
