using System;
using System.Text;
using System.Collections.Generic;
using Learning.Tips.EnumLearning;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.Tips.Test
{
    /// <summary>
    /// Summary description for EnumFlagTest
    /// </summary>
    [TestClass]
    public class EnumFlagTest
    {
        public EnumFlagTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void CheckEventHappen()
        {
            var check = new EnumEntity();
            var result1 =check.CheckEventHappen(new DateTime(2018, 5, 14), "1,3");
            var result2=check.CheckEventHappen(new DateTime(2018, 5, 15), "3,4");
            var result3 =check.CheckEventHappen(new DateTime(2018, 5, 16), "1,2,3");
            var result4 =check.CheckEventHappen(new DateTime(2018, 5, 17), "1,2,3");
            var result5 =check.CheckEventHappen(new DateTime(2018, 5, 18), "1,3");
            var result6 =check.CheckEventHappen(new DateTime(2018, 5, 19), "4,5");
            var result0 =check.CheckEventHappen(new DateTime(2018, 5, 20), "4,0");
            var result7 =check.CheckEventHappen(new DateTime(2018, 5, 21), "1");
            var result8 =check.CheckEventHappen(new DateTime(2018, 5, 20), "");
            Assert.IsTrue(result0);
            Assert.IsTrue(result1);
            Assert.IsTrue(!result2);
            Assert.IsTrue(result3);
            Assert.IsTrue(result7);
            Assert.IsTrue(result8);
            Assert.IsTrue(!result4);
            Assert.IsTrue(!result5);
            Assert.IsTrue(!result6);
        }
    }
}
