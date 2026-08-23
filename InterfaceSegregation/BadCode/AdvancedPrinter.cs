using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.BadCode
{
    public class AdvancedPrinter : IMultifunctionalPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Gelişmiş yazıcı fax çekiyor.");
        }

        public void Print()
        {
            Console.WriteLine("Gelişmiş yazıcı çıktı alıyor.");
        }

        public void Scan()
        {
            Console.WriteLine("Gelişmiş yazıcı tarama yapıyor.");
        }
    }
}
