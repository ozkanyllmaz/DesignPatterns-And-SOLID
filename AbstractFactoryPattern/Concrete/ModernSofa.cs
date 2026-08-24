using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Concrete
{
    public class ModernSofa : ISofa
    {
        public void LieOn() => Console.WriteLine("Modern koltuğa uzanıldı.");
    }
}
