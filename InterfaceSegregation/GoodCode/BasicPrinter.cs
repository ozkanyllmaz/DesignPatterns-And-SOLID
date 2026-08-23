using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.GoodCode
{
    public class BasicPrinter : IPrintAble
    {
        public void Print()
        {
            Console.WriteLine("Basic yazıcı çıktı alıyor.");
        }
    }
}
