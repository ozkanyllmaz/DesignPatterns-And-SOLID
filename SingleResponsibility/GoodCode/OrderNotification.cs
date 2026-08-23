using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.GoodCode
{
    public class OrderNotification
    {
        public void SendNotification(Order order)
        {
            Console.WriteLine("Müşteriye bildirim gönderildi." + order);
        }
    }
}
