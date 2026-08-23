using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.BadCode
{
    public class EmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email} adresine mail başarılıyla iletildi");
        }
    }
}
