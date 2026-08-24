using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.GoodCode
{
    public class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("Denizyolu ile taşıma.");
    }
}
