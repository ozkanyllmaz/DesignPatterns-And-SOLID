using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.GoodCode
{
    public abstract class Logistics
    {
        // Müdürlerin kendi aracını üretebileceği metot (Factory Method)
        public abstract ITransport CreateTransport();

        // Patronun teslimatı başlattığı yer
        public void PlanDelivery()
        {
            ITransport transport = CreateTransport(); // müdür aracı getirir.
            transport.Deliver(); // teslimat başlar.
        }
    }
}
