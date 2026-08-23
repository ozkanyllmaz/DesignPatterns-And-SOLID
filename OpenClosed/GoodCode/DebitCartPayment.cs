using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.GoodCode
{
    public class DebitCartPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Banka kartı kullanarak {amount}₺ ödeme gerçekleştirildi");
        }
    }
}
