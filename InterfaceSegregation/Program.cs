using InterfaceSegregation.BadCode;

//Console.WriteLine("BadCode örneği");
//Console.WriteLine("-------------------");

//List<IMultifunctionalPrinter> printers = new List<IMultifunctionalPrinter>()
//{
//    new BasicPrinter(),
//    new AdvancedPrinter()
//};

//foreach(var printer in printers)
//{
//    try
//    {
//        printer.Fax();
//        printer.Scan();
//        printer.Print();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Hata oluştu: " + ex.Message);
//    }
//}


//----------------------------------------------------------------------------------------

Console.WriteLine("GoodCode örneği");
Console.WriteLine("-------------------");

BasicPrinter basicPrinter = new BasicPrinter();
basicPrinter.Print();

AdvancedPrinter advancedPrinter = new AdvancedPrinter();
advancedPrinter.Print();
advancedPrinter.Fax();
advancedPrinter.Scan();

