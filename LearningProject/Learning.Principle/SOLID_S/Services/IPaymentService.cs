using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Principle.SOLID_O;

namespace Learning.Principle.SOLID_S.Services
{
    public interface IPaymentService
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount);
    }
}
