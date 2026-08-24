using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.GoodCode
{
    // kamyon üretecek şube müdürü
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Truck();
    }
}
