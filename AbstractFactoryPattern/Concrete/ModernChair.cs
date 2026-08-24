using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Concrete
{
    public class ModernChair : IChair
    {
        public void SitOn() => Console.WriteLine("Modern sandalyeye oturuldu.");
    }
}
