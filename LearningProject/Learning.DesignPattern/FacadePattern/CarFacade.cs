using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.FacadePattern
{
    public class CarFacade
    {
        private CarModel model;
        private CarEngine engine;
        private CarBody body;
        private CarAssessories accessories;

        public CarFacade( )
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAssessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();
            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
