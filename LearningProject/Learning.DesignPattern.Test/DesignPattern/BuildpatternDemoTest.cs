using System;
using Learning.DesignPattern.BuildDesignPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class BuildpatternDemoTest
    {
        [TestMethod]
        public void TryBuildPatternTest()
        {
            var demo = new BuildDesignPatternDemo();
            demo.TryBuildPattern();
        }
    }
}
