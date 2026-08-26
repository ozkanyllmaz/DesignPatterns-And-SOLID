using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class LoggingDecorator : ProductDecorator
    {
        public LoggingDecorator(IProductService productService) : base(productService) { }

        public override void GetProducts()
        {
            Console.WriteLine("[LOG] İşlem başlatıldı: Tarih - " + DateTime.Now);
            base.GetProducts();
            Console.WriteLine("[LOG] İşlem başarıyla bitti.");
        }
    }
}
