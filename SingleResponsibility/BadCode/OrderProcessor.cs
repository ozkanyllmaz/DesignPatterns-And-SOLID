using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.BadCode
{
    public class OrderProcessor
    {
        private string Order { get; set; } = null!;

        public OrderProcessor(string order)
        {
            Order = order;
        }

        public void OrderProcess()
        {
            ValidateOrder();
            SaveOrderToDatabase();
            SendNotification();
        }

        public void ValidateOrder()
        {
            Console.WriteLine("Sipariş doğrulandı: " + Order);
        }

        public void SaveOrderToDatabase()
        {
            Console.WriteLine("Sipariş veritabanına kaydedildi: " + Order);
        }

        public void SendNotification()
        {
            Console.WriteLine("Müşteriye bildirim gönderildi: " + Order);
        }
    }
}
