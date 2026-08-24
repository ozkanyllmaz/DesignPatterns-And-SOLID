using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class LazyDbContext
    {
        private static LazyDbContext? context;

        private LazyDbContext()
        {
            Console.WriteLine("context nesnesi üretildi");
        }

        public static LazyDbContext GetInstance()
        {
            if(context == null)
            {
                context = new LazyDbContext();
            }
            return context;
        }
    }
}
