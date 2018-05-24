using System;
using Learning.DesignPattern.PrototypePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class PrototypePatternDemoTest
    {
        [TestMethod]
        public void TryPrototypePatternTest()
        {
            var demo = new PrototypePatternDemo();
            demo.TryPrototypePattern();
        }
    }
}
