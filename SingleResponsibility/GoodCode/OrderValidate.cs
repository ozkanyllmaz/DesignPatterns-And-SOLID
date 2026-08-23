using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.GoodCode
{
    public class OrderValidate
    {
        public void ValidateOrder(Order order)
        {
            Console.WriteLine("Sipariş validate edildi." + order);
        }
    }
}
