using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.GoodCode
{
    // FACADE SINIFIMIZ
    public class OrderFacade
    {
        private readonly StockManager _stock;
        private readonly PaymentGateway _payment;
        private readonly InvoiceSystem _invoice;
        private readonly NotificationService _notification;

        public OrderFacade()
        {
            _stock = new StockManager();
            _payment = new PaymentGateway();
            _invoice = new InvoiceSystem();
            _notification = new NotificationService();
        }

        public void Order(int productId, decimal amount)
        {
            Console.WriteLine("Sipariş süreci başlatıldı...");

            if (!_stock.Check(productId))
            {
                Console.WriteLine("Stok yetersiz!");
                return;
            }

            if (_payment.Pay(amount))
            {
                _invoice.CreateInvoice();
                _notification.SendEmail();
                Console.WriteLine("Sipariş başarıyla tamamlandı!");
            }
        }

    }
}
