using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Concrete
{
    public class VintageChair : IChair
    {
        public void SitOn() => Console.WriteLine("Vintage sandalyeye oturuldu.");
    }
}
