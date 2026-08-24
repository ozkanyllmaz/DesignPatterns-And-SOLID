using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.GoodCode
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Ship();
    }
}
