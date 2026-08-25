using Adapter.GoodCode;

Console.WriteLine("GoodCode");
Console.WriteLine("-------------");

OldBankApi oldBankApi = new OldBankApi();

IPaymentProcessor adaptor = new BankApiAdapter(oldBankApi);

BankApp app = new BankApp(adaptor);

app.Checkout(1500.50m);
