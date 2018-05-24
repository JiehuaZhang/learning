using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.CompositePattern
{
    public class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public void Dispay(string role)
        {
            Console.WriteLine(role +$" Contractor EmpID={EmpID}, Name={Name}");
        }
    }
}
