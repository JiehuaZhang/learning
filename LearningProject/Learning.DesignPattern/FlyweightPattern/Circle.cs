﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.FlyweightPattern
{
    public class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}
