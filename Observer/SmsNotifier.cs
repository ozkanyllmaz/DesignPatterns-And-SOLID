using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SmsNotifier : IObserver
    {
        public void Update(string message)
            => Console.WriteLine($"[SMS GÖNDERİLDİ]: {message}");
    }
}
