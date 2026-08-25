using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GoodCode
{
    public class OldBankApi
    {
        public void PayWithXML(string xmlData)
        {
            Console.WriteLine($"Banka API'sine işlem yapıldı: {xmlData}");
        }
    }
}
