//using DependencyInversion.BadCode;

//Console.WriteLine("BadCode Örneği");
//Console.WriteLine("----------------");

//Auth auth = new Auth();
//auth.Register("test123@gmail.com", "password");



//------------------------------------------------------------------


using DependencyInversion.GoodCode;


Console.WriteLine("GoodCode Örneği");
Console.WriteLine("----------------");

EmailService emailService = new EmailService();
AuthService authService = new AuthService(emailService);

authService.Register("test123@gmail.com", "password");