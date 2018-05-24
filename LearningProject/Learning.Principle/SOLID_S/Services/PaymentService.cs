using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Principle.SOLID_O;

namespace Learning.Principle.SOLID_S.Services
{
    public class PaymentService : IPaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }

        public void Change()
        {
            throw new AccountBalanceMismatchException();
        }

        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount)
        {
            throw new NotImplementedException();
        }
    }
    public class AccountBalanceMismatchException : Exception
    {
    }
}
