using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.GoodCode
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email} adresine mail gönderildi.");
        }
    }
}
