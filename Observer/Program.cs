using Observer;

Console.WriteLine("Observer Pattern");
Console.WriteLine("-------------------");

Product laptop = new Product();

// Aboneleri (Gözlemcileri)
IObserver emailSystem = new EmailNotifier();
IObserver smsSystem = new SmsNotifier();

// Aboneleri ürüne kaydet
laptop.Attach(emailSystem);
laptop.Attach(smsSystem);

// Stoğu güncelle
laptop.UpdateStock(50);

// Sms sistemini abonelikten çıkaralım
laptop.Detach(smsSystem);
laptop.UpdateStock(100); // Artık sadece Email gidecek
