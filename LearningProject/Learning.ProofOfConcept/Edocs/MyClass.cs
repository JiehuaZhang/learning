using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ProofOfConcept.Edocs
{
    public class MyClass
    {
        public int ID => GetID();
        public string Name { get; set; }
        private int GetID()
        {
            var n = Name.Length;
            return n+1;
        }
     
    }

    public class UseGet
    {
        public void TryUse()
        {
            var myClass = new MyClass() { Name = "TEST"};
            Console.WriteLine(myClass.ID);
        }
    }
}
