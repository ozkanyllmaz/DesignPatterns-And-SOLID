using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.BadCode
{
    public class Manager : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine("Yönetici primi hesaplandı");
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Yönetici maaşı hesaplandı");
        }
    }
}
