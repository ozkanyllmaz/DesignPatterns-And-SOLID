using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CryptoStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
            => Console.WriteLine($"{amount} TL Kripto ödeme yöntemiyle ödendi");
    }
}
