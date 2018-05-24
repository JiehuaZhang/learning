using System;
using Learning.DesignPattern.Statepattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class StatePatternTest
    {
        [TestMethod]
        public void TryStatePatterTest()
        {
            var demo = new StatePatternDemo();
            demo.TryStatePattern();
        }
    }
}
