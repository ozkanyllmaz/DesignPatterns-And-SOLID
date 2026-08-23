using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.BadCode
{
    public class ContractEmployee : Employee
    {
        public override void CalculateBonus()
        {
            throw new NotImplementedException("Sözleşmeli personel prim alamaz!");
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Sözleşmeli personelin maaşı hesaplandı");
        }
    }
}
