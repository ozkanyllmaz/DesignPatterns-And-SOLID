using Strategy;

Console.WriteLine("Strategy Pattern");
Console.WriteLine("-------------------");

ShoppingCart cart = new ShoppingCart();

Console.WriteLine("Müşteri kredi kartını seçiyor..");
cart.SetPaymentStrategy(new CreditCartPayment());
cart.checkout(1500m);


Console.WriteLine("Müşteri kripto yöntemini seçiyor..");
cart.SetPaymentStrategy(new CryptoStrategy());
cart.checkout(1850m);

