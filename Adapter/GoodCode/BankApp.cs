using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GoodCode
{
    public class BankApp
    {
        private readonly IPaymentProcessor _processor;

        public BankApp(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void Checkout(decimal amount)
        {
            Console.WriteLine("Ödeme süreci başlatılıyor...");

            // Arka planda banka mı var, kripto mu var, XML mi gidiyor BİLMİYORUZ!
            _processor.ProcessPayment(amount);
        }
    }
}
