using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.DesignPattern.ChainOfResponsibilityPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class ChainOfResponsibilityPatternTest
    {
        [TestMethod]
        public void TryChainOfResponsibilityPatternTest()
        {
            var demo = new ChainOfResponsibilityPatternDemo();
            demo.TryChainOfResponsibilityPattern();
        }
    }
}
