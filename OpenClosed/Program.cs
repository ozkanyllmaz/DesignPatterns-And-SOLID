//using OpenClosed.BadCode;
using OpenClosed.GoodCode;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;


//Console.WriteLine("BadCode örneği");
//Console.WriteLine("-----------------");

//PaymentProcessor paymentProcessor = new PaymentProcessor();
//paymentProcessor.Pay("CreditCart");


//--------------------------------------------------------


Console.WriteLine("GoodCode örneği");
Console.WriteLine("-----------------");

PaymentProcessor processor = new PaymentProcessor();
IPaymentMethod myPayment = new DebitCartPayment();

processor.ProcessPayment(myPayment, 2450m);
