using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CachingDecorator : ProductDecorator
    {
        public CachingDecorator(IProductService productService) : base(productService) {}

        public override void GetProducts()
        {
            Console.WriteLine("[CACHE] Önbellek kontrol ediliyor...");
            base.GetProducts();
            Console.WriteLine("[CACHE] Sonuçlar önbelleğe kaydedildi.");
        }
    }
}
