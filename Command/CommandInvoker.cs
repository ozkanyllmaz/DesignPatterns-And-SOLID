using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // Komutu alıp çalıştıran merkezdir. Komutun ne iş yaptığını bilmez, sadece Execute demeyi bilir.
    public class CommandInvoker
    {
        public void Send(ICommand command)
        {
            Console.WriteLine("Invoker: Komut işleme alınıyor...");
            command.Execute();
            Console.WriteLine("Invoker: Komut başarıyla tamamlandı.\n");
        }
    }
}
