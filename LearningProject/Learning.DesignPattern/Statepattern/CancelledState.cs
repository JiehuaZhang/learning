using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.Statepattern
{
    public class CancelledState : IOrderState
    {
        public OrderStatus Status =>OrderStatus.Cancelled;
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Cannot ship the order");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Already cancelled.");
        }
    }
}
