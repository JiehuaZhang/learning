using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.DecoratorPattern
{
    public abstract class VehicleDecorator :IVehicle
    {
        private readonly IVehicle _vehicle;

        protected VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Make => _vehicle.Make;

        public string Model => _vehicle.Model;
        public double Price => _vehicle.Price;
    }
}
