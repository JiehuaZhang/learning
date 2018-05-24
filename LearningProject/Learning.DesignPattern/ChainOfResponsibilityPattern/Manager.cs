using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ChainOfResponsibilityPattern
{
    public class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000.0)
            {
                Console.WriteLine($"{sender.GetType().Name} approved request# {e.Loan.Number}");
            }
            else if(Successor !=null)
            {
                Successor.LoanHandler(this, e);
            }
            else
            {
                Console.WriteLine($"Request# {e.Loan.Number} requires an excutive meeting");
            }
        }
    }
}
