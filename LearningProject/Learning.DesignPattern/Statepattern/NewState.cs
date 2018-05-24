using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.Statepattern
{
    public class NewState : IOrderState
    {
        public OrderStatus Status  =>OrderStatus.New;
        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            order.Change(new ShippedState());
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            order.Change(new CancelledState());
        }
    }
}
