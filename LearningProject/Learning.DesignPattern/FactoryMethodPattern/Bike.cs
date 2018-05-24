using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.FactoryMethodPattern
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike: IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike: "+miles +"km");
        }
    }
}
