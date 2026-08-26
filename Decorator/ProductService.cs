using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ProductService : IProductService
    {
        public void GetProducts()
        {
            Console.WriteLine("Ürünler db den getirildi.");
        }
    }
}
