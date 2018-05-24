using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.CompositePattern
{
    public interface IEmployed 
    {
        int EmpID { get; set; }
        string Name { get; set; }
        void Dispay(string role);
    }
}
