//using Facade;

//Console.WriteLine("BadCode Örneği");
//Console.WriteLine("-----------------");

//StockManager stock = new StockManager();
//if (stock.Check(1))
//{
//    PaymentGateway payment = new PaymentGateway();
//    if (payment.Pay(1500))
//    {
//        InvoiceSystem invoice = new InvoiceSystem();
//        invoice.CreateInvoice();

//        NotificationService notification = new NotificationService();
//        notification.SendEmail();
//    }
//}

//--------------------------------------------------------------------------------


using Facade.GoodCode;

Console.WriteLine("GoodCode Örneği");
Console.WriteLine("-----------------");

OrderFacade orderFacade = new OrderFacade();
orderFacade.Order(12, 1750.75m);
