using System;
using System.Text;
using System.Collections.Generic;
using Learning.ProofOfConcept.Edocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.DesignPattern.Test.ProofOfConcept
{
    /// <summary>
    /// Summary description for GetPropertyTEST
    /// </summary>
    [TestClass]
    public class GetPropertyTEST
    {
     

        [TestMethod]
        public void TestMethod1()
        {
            var test = new UseGet();
            test.TryUse();
        }
    }
}
