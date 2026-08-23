using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.GoodCode
{
    public class CreditCartPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Kredi kartı kullanılarak {amount}₺ ödeme gerçekleştirildi");
        }
    }
}
