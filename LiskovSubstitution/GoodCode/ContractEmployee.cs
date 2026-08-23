using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.GoodCode
{
    public class ContractEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Sözleşmeli personel maaşı hesaplandı");
        }
    }
}
