using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Principle.SOLID_S.Services
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(ShoppingCart cart);
    }
}
