using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Principle.SOLID_S.Services
{
    public class InventoryService
    {
        public void Reserve(string identifier, int quantity)
        {
            throw new InsufficientExecutionStackException();
        }
    }
    public class InsufficientInventoryException: Exception { }
}
