using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.BuildDesignPattern
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class HeroBuilder :IVehicleBuilder
    {
        private readonly Vehicle objectVehicle = new Vehicle();
        public void SetModel()
        {
            objectVehicle.Model = "Hero";
        }

        public void SetEngine()
        {
            objectVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objectVehicle.Transmission = "120 km/hr";
        }

        public void SetBody()
        {
            objectVehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            objectVehicle.Accessories.Add("Seat Cover");
            objectVehicle.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return objectVehicle;
        }
    }
}
