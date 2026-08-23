using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.GoodCode
{
    public class OrderSave
    {
        public void OrderSaveToDatabase(Order order)
        {
            foreach (var item in order.BasketItems)
            {
                Console.WriteLine("Sipariş ürünleri veritabanına kaydedildi: " + item);
            }
            Console.WriteLine("Toplam sipariş tutarı: " + order.TotalRevenue);
        }
    }
}
