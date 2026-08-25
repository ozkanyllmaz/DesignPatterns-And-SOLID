using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class StockManager { public bool Check(int productId) => true; }
    public class PaymentGateway { public bool Pay(decimal amount) => true; }
    public class InvoiceSystem { public void CreateInvoice() => Console.WriteLine("Fatura kesildi."); }
    public class NotificationService { public void SendEmail() => Console.WriteLine("E-posta gönderildi."); }


}
