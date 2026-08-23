using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.GoodCode
{
    public class Manager : IEmployee, ICalculateBonus
    {
        public void CalculateBonus()
        {
            Console.WriteLine("Manager primi hesaplandı");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Manager maaşı hesaplandı");
        }
    }
}
