using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.BadCode
{
    public class Auth
    {
        public void Register(string email, string password)
        {
            Console.WriteLine($"Kullanıcı kaydı başarılı. Name: {email} Password: {password}");

            EmailService emailService = new EmailService();
            emailService.SendEmail("test123@gmail.com");
        }
    }
}
