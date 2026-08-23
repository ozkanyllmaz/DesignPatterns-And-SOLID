using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.GoodCode
{
    public class AdvancedPrinter : IPrintAble, IScanable, IFaxable
    {
        public void Fax()
        {
            Console.WriteLine("Gelişmiş yazıcı fax yolluyor.");
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
