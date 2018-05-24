using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.Tips.Test
{
    [TestClass]
    public class EqualityTest
    {
        [TestMethod]
        public void ToDictionaryTest()
        {
            var a = new TestObject { ID = 1, Name= "test 1"};
            var b = new TestObject { ID = 1, Name = "test 2" };
            var c = new TestObject { ID = 2, Name = "test 3" };
            var d = new TestObject { ID = 3, Name = "test 4" };
            var e = new TestObject { ID = 4, Name = "test 5" };
            var list = new List<TestObject> {a, b,c,d,e};
            var idList = new List<int> {3, 4};
             list.RemoveAll(x =>idList.Contains(x.ID));
            var dic = list.GroupBy(x=>x.ID).ToDictionary(x=>x.Key, x => x.ToList()[0].Name);
        }
    }

    public class TestObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
