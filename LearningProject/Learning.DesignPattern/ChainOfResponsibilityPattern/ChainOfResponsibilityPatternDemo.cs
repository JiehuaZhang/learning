using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ChainOfResponsibilityPattern
{
    public class ChainOfResponsibilityPatternDemo
    {
        public void TryChainOfResponsibilityPattern()
        {
            Approver clerk = new Clerk();
            Approver assistant = new AssistantManager();
            Approver manager = new Manager();

            clerk.Successor = assistant;
            assistant.Successor = manager;


            var loanList = new List<Loan>
            {
                new Loan {Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan"},
                new Loan {Number = 2035, Amount = 42000.10, Purpose = "Bike Loan"},
                new Loan {Number = 2036, Amount = 156200.00, Purpose = "House Loan"}
            };

            foreach (var loan in loanList)
            {
                clerk.ProcessRequest(loan);
            }
        }
    }
}
