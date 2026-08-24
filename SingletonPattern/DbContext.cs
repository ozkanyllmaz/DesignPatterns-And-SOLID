using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class DbContext
    {
        private static DbContext dbContext = new DbContext();

        private DbContext()
        {
            Console.WriteLine("dbContext nesnesi oluşturuldu.");
        }

        public static DbContext getInstance()
        {
            return dbContext;
        }
    }
}

