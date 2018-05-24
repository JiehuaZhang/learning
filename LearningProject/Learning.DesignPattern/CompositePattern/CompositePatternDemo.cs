using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.CompositePattern
{
    public class CompositePatternDemo
    {
        public void TryCompositePattern()
        {
            var Rahul = new Employee { EmpID = 1, Name = "Rahul" };

            var Amit = new Employee { EmpID = 2, Name = "Amit" };
            var Mohan = new Employee { EmpID = 3, Name = "Mohan" };

            var Rita = new Employee { EmpID = 4, Name = "Rita" };
            var Hari = new Employee { EmpID = 5, Name = "Hari" };

            var Kamal = new Employee { EmpID = 6, Name = "Kamal" };
            var Raj = new Employee { EmpID = 7, Name = "Raj" };

            var Sam = new Contractor { EmpID = 8, Name = "Sam" };
            var tim = new Contractor { EmpID = 9, Name = "Tim" };


            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Rahul.Dispay("CEO");


        }
    }
}
