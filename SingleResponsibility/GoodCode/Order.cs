using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.GoodCode
{
    public class Order
    {
        public List<string> BasketItems { get; set; } = null!;
        public decimal TotalRevenue { get; set; }
    }
}
