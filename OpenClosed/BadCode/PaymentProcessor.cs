using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.BadCode
{
    public class PaymentProcessor
    {
        public void Pay(string paymentType)
        {
            switch (paymentType)
            {
                case "CreditCart":
                    Console.WriteLine($"Ödeme yöntemi: {paymentType}");
                    break;

                case "DebitCart":
                    Console.WriteLine($"Ödeme yöntemi: {paymentType}");
                    break;

                case "PayPal":
                    Console.WriteLine($"Ödeme yöntemi: {paymentType}");
                    break;

                default:
                    Console.WriteLine("Ödeme yöntemi geçersiz");
                    break;
            }
        }
    }
}
