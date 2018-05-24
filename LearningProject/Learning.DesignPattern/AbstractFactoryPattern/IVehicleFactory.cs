using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    ///  The 'AbstractFactory' interface. 
    /// </summary>
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
    }
}
 