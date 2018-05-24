using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.FlyweightPattern
{
    public class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();
        public int TotalObhjectCreated => shapes.Count;

        public IShape GetShape(string shapeName)
        {
            IShape shape;
            if (shapes.ContainsKey(shapeName))
            {
                shape = shapes[shapeName];
            }
            else
            {
                switch (shapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}
