using System;
using System.Text;
using System.Collections.Generic;
using Learning.DesignPattern.StrategyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    /// <summary>
    /// Summary description for StrategyPatternTest
    /// </summary>
    [TestClass]
    public class StrategyPatternTest
    {

        [TestMethod]
        public void TryStrategyPatternTest()
        {
            var demo = new StrategyPatternDemo();
            demo.TryStrategyPattern();
        }
    }
}
