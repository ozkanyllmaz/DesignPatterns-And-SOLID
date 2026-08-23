using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.GoodCode
{
    public interface IEmailService
    {
        void SendEmail(string email);
    }
}
