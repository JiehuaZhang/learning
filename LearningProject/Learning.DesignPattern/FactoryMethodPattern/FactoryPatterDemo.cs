/*
 1.Product
    This is an interface for creating the objects.

2.ConcreteProduct
This is a class which implements the Product interface.

    3.Creator
This is an abstract class and declares the factory method, which returns an object of type Product.

4.ConcreteCreator
This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
*/


using System.Collections.Generic;

namespace Learning.DesignPattern.FactoryMethodPattern
{
    public class FactoryPatterDemo
    {
        public void TryPatter()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            var waitingList = new List<string> { "Scooter","Bike"};
            foreach (var vehicleName in waitingList)
            {
                var vehicle = factory.GetVehicle(vehicleName);
                vehicle.Drive(vehicleName.Length*10);
            }
        }
    }
}
