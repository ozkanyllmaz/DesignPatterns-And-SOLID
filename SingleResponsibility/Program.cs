using SingleResponsibility.BadCode;
using SingleResponsibility.GoodCode;

//Console.WriteLine("Bad Code");
//Console.WriteLine("-----------------------------");

//var order = "Sapriş id: 12";

//OrderProcessor orderProcessor = new OrderProcessor(order);
//orderProcessor.OrderProcess();


Console.WriteLine("Good Code");
Console.WriteLine("-----------------------------");

Order myOrder = new Order
{
    BasketItems = new List<string> { "Laptop", "Mouse" },
    TotalRevenue = 14950m
};

OrderValidate orderValidate = new OrderValidate();
OrderSave orderSave = new OrderSave();
OrderNotification orderNotification = new OrderNotification();

SingleResponsibility.GoodCode.OrderProcessor processor = new SingleResponsibility.GoodCode.OrderProcessor(orderValidate, orderSave, orderNotification, myOrder);
processor.Process();