using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ChainOfResponsibilityPattern
{
    public class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 45000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {e.Loan.Number}");
            }
            else
            {
                Successor?.LoanHandler(this, e);
            }
        }
    }
}
