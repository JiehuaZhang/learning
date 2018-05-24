using System;
using Learning.DesignPattern.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class DecoratorPatternTest
    {
        [TestMethod]
        public void TryDecoratorPatternDemo()
        {
            var demo = new DecoratorPatternDemo();
            demo.TryDecoratorPattern();
        }
    }
}
