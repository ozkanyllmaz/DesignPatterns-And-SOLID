using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.BadCode
{
    public interface IMultifunctionalPrinter
    {
        void Print();
        void Scan();
        void Fax();
    }
}
