using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Adapter.BadCode
{
    public class OldBankApi
    {
        public void PayWithXML(string xmlData)
        {
            Console.WriteLine($"Banka API'sine XML iletildi: {xmlData}");
        }
    }
}
