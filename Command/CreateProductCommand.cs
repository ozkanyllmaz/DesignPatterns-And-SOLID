using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class CreateProductCommand : ICommand
    {
        private readonly ProductReceiver _productReceiver;
        private readonly string _productName;
        private readonly decimal _price;

        public CreateProductCommand(ProductReceiver productReceiver, string productName, decimal price)
        {
            _productReceiver = productReceiver;
            _productName = productName;
            _price = price;
        }

        public void Execute()
        {
            Console.WriteLine("Komut çalışıyor: Ürün ekleme isteği doğrulandı.");
            _productReceiver.InsertToDatabase(_productName, _price);
        }
    }
}
