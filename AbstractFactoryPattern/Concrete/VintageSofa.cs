using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Concrete
{
    public class VintageSofa : ISofa
    {
        public void LieOn() => Console.WriteLine("Vintage koltuğa oturuldu.");
    }
}
