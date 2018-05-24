using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Principle.SOLID_S
{
    public abstract class Order
    {
        protected Order(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
        }

        public ShoppingCart ShoppingCart { get; }

        public virtual void Checkout()
        {
            
        }
    }
}
