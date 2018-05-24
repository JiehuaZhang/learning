using Learning.DesignPattern.AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.DesignPattern
{
    [TestClass]
    public class ActionProviderTest
    {
        [TestMethod]
        public void RunCaseStepTest()
        {
            IAction action = new CaseAdapter();
            var client = new ActionProvider(action);
            client.RunCaseStep();
        }
    }
}
