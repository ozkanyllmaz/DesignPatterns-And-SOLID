using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.GoodCode
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
