using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    // TEMEL DEKORATÖR
    // Diğer tüm decoratorlar bundan miras alacak. İçinde her zaman bir IProductService olacak.
    // Abstract olmasının sebebi alt sınıfların bundan doğrudan (new ProductDecorator()) nesne üretmesini engellemektir.
    // ProductDecorator kendi başına özellik taşımaz. Diğer decoratorların türetileceği genel bir şablon, çatıdır.
    public abstract class ProductDecorator : IProductService
    {
        protected readonly IProductService _productService;

        public ProductDecorator(IProductService productService)
        {
            _productService = productService;
        }

        // virtual yapıyoruz ki alt sınıflar bunu ezebilsin.
        public virtual void GetProducts()
        {
            _productService.GetProducts();
        }
    }
}
