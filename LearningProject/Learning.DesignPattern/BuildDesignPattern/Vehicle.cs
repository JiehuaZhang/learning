using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.BuildDesignPattern
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine("Accessories: ");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
