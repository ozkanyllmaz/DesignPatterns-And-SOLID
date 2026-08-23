using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.GoodCode
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
