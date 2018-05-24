using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.DecoratorPattern
{
    public class HondaCity : IVehicle
    {
        public string Make => "HondaCity";

        public string Model => "CNG";
        public double Price => 1000000;
    }
}
