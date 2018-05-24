using System;
using Learning.DesignPattern.FacadePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class FacadePartterTest
    {
        [TestMethod]
        public void CarFacadeTest()
        {
            var facade = new CarFacade();
            facade.CreateCompleteCar();
        }
    }
}
