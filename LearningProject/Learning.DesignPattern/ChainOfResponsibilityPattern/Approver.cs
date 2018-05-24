using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ChainOfResponsibilityPattern
{
    public abstract class Approver
    {
        public EventHandler<LoanEventArgs> Loan;

        // Sets or gets the next approver
        public Approver Successor { get; set; }
        public abstract void LoanHandler(object sender, LoanEventArgs e);

        protected Approver()
        {
            Loan += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs{Loan = loan});
        }

        // Invoke the Loan event
        public virtual void OnLoan(LoanEventArgs e)
        {
            Loan?.Invoke(this, e);
        }
      
    }
}
