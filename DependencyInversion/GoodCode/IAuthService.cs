using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.GoodCode
{
    public interface IAuthService
    {
        void Register(string email, string password);
    }
}
