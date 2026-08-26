using Command;

Console.WriteLine("Command Pattern");
Console.WriteLine("------------------");

ProductReceiver dbReceiver = new ProductReceiver();
CommandInvoker mediator = new CommandInvoker(); // Kendi mini MediatR'ımız

// isteği komut nesnesine dönüştür: request -> command
ICommand command1 = new CreateProductCommand(dbReceiver, "Klavye", 2500m);
ICommand command2 = new CreateProductCommand(dbReceiver, "Mouse", 1500m);

// komutları gönder
mediator.Send(command1);
mediator.Send(command2);
