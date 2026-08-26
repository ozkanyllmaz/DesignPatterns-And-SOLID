using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ProductReceiver
    {
        public void InsertToDatabase(string productName, decimal price)
        {
            // Entity Framework veya Dapper kodları burada çalışır
            Console.WriteLine($"[DB_LOG] {productName} - {price} TL veritabanına eklendi.");
        }
    }
}
