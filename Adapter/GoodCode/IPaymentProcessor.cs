using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GoodCode
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
