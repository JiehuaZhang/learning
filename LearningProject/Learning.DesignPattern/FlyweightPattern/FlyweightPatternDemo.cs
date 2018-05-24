using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.FlyweightPattern
{
    public class FlyweightPatternDemo
    {
        public void TryflyweightPattern()
        {
            var sof = new ShapeObjectFactory();

            var shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();


            Console.WriteLine("\nTotal No of Objects created = {0}", sof.TotalObhjectCreated);
        }
    }
}
