using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CreditCartPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
            => Console.WriteLine($"{amount} TL Kredi kartı ile ödendi");
    }
}
