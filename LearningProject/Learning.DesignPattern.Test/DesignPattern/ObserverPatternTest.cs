using System;
using Learning.DesignPattern.ObserverPattern.Subscribe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class ObserverPatternTest
    {
        [TestMethod]
        public void TryObserverPattern()
        {
            var demo = new ObserverPatterDemo();
            demo.TryObserverPatter();
        }
    }
}
