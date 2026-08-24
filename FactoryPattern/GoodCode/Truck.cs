using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.GoodCode
{
    public class Truck : ITransport
    {
        public void Deliver() => Console.WriteLine("Karayolu ile taşıma.");
    }
}
