using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.GoodCode
{
    // ADAPTÖRÜMÜZ!
    // Bizim arayüzümüzü uygular ama arka planda bankanın dilini konuşur.
    public class BankApiAdapter : IPaymentProcessor
    {
        private readonly OldBankApi _oldBankApi;

        public BankApiAdapter(OldBankApi oldBankApi)
        {
            _oldBankApi = oldBankApi;
        }

        public void ProcessPayment(decimal amount)
        {
            // Veriyi bankanın anladığı formata (XML) dönüştürüyoruz
            string xmlFormat = $"<payment><amount>{amount}</amount></payment>";

            // Bankanın metodunu çağırıyoruz
            _oldBankApi.PayWithXML(xmlFormat);
        }
    }
}
