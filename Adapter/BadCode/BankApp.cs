using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.BadCode
{
    public class BankApp
    {
        public void Checkout(decimal amount)
        {
            // Hata: Modern sistemin ortasında eski sistemin kurallarına uyumlu hale getirmek için
            // veri dönüştürme yapıyoruz. Sistemler sıkı sıkıya bağımlı.
            OldBankApi bankapi = new OldBankApi();
            
            string xml = $"<payment><amount>{amount}</amount></payment>";
            bankapi.PayWithXML(xml);
        }
    }
}
