using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.BadCode
{
    public class BasicPrinter : IMultifunctionalPrinter
    {
        public void Fax()
        {
            throw new NotImplementedException("Basit yazıcı fax çekemiyor.");
        }

        public void Print()
        {
            Console.WriteLine("Basit yazıcı çıktı alıyor.");
        }

        public void Scan()
        {
            throw new NotImplementedException("Basit yazıcı tarama yapamıyor.");
        }
    }
}
