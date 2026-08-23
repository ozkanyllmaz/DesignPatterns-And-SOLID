//using LiskovSubstitution.BadCode;

//Console.WriteLine("BadCode örneği");
//Console.WriteLine("------------------");

//List<Employee> employees = new List<Employee>()
//{
//    new Manager(),
//    new ContractEmployee(),
//};


//foreach(var employee in employees)
//{
//    employee.CalculateSalary();
//    employee.CalculateBonus();
//}


//-----------------------------------------------------------------------

using LiskovSubstitution.GoodCode;

Console.WriteLine("GoodCode örneği");
Console.WriteLine("------------------");

List<IEmployee> employees = new List<IEmployee>()
{
    new Manager(),
    new ContractEmployee(),
};

Console.WriteLine("Tüm personellerin maaşları hesaplanıyor..");
foreach (var employee in employees)
{
    employee.CalculateSalary();
    
}

List<ICalculateBonus> calculateBonusEmployees = new List<ICalculateBonus>()
{
    new Manager()
};

Console.WriteLine("Kadrolu personellerin prim hesaplamaları yapılıyor..");
foreach (var employee in calculateBonusEmployees)
{
    employee.CalculateBonus();
}
