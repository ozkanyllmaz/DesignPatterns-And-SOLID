using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void checkout(decimal amount)
        {
            if(_paymentStrategy == null)
            {
                Console.WriteLine("Önce ödeme yöntemi seçiniz.");
                return;
            }

            Console.WriteLine("Ödeme işlemi başlatılıyor...");
            // Sepet arka planda Kredi Kartı mı Kripto mu var BİLMEZ. Sadece tetikler.
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
