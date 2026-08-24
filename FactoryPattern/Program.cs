//using FactoryPattern.BadCode;

//Console.WriteLine("BadCode Örneği");
//Console.WriteLine("------------------");

//LogisticApp logisticApp = new LogisticApp();
//logisticApp.PlanDelivery("road");



//-----------------------------------------------------------

using FactoryPattern.BadCode;
using FactoryPattern.GoodCode;

Console.WriteLine("GoodCode Örneği");
Console.WriteLine("------------------");

Console.WriteLine("--- Karayolu Siparişi ---");
Logistics roadManager = new RoadLogistics();
roadManager.PlanDelivery();

Console.WriteLine("--- Denizyolu Siparişi ---");
Logistics seaManager = new SeaLogistics();
seaManager.PlanDelivery();

