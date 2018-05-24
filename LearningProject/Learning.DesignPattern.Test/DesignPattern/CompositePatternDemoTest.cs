using System;
using Learning.DesignPattern.CompositePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class CompositePatternDemoTest
    {
        [TestMethod]
        public void TryCompositePatternTest()
        {
            var demo = new CompositePatternDemo();
            demo.TryCompositePattern();
        }
    }
}
