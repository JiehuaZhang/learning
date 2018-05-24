using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.PrototypePattern
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
