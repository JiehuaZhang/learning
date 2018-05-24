using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Principle.SOLID_O;
using Learning.Principle.SOLID_S.Services;

namespace Learning.Principle.SOLID_S
{
    public class CreditCardOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        public CreditCardOrder(ShoppingCart shoppingCart, IPaymentService paymentService, PaymentDetails paymentDetails) : base(shoppingCart)
        {
            _paymentService = paymentService;
            _paymentDetails = paymentDetails;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            base.Checkout();
        }
    }
}
