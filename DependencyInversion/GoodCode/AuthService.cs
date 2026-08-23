using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.GoodCode
{
    public class AuthService : IAuthService
    {
        private readonly IEmailService _emailService;

        public AuthService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Register(string email, string password)
        {
            Console.WriteLine($"Kullanıcı kaydı başarıyla oluştu. Email:{email} | Password:{password}");

            _emailService.SendEmail(email);
        }
    }
}
