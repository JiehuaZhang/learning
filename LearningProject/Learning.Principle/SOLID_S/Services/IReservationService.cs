using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Learning.Principle.SOLID_O;

namespace Learning.Principle.SOLID_S.Services
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
