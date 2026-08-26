using Decorator;

Console.WriteLine("Decorator Pattern");
Console.WriteLine("-------------------");


IProductService service = new ProductService();
service.GetProducts();

Console.WriteLine("-- Log Eklenmiş Hali --");
IProductService logging = new LoggingDecorator(new ProductService());
logging.GetProducts();

Console.WriteLine("-- Cache Yapılmış Hali --");
IProductService caching = new CachingDecorator(new ProductService());
caching.GetProducts();

