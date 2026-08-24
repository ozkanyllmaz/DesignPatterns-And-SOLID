using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class ThreadSafeDbContext
    {
        private static ThreadSafeDbContext? context;

        private static readonly object _lock = new object();

        private ThreadSafeDbContext()
        {
            Console.WriteLine("thread-safe context nesnesi üretildi.");
        }

        public static ThreadSafeDbContext GetInstance()
        {
            if(context == null)
            {
                // içeriye giren ilk kişi kapıyı kilitler diğerleri sırada bekler.
                lock(_lock)
                {
                    // kapıda bekleyen içeri girdiğinde nesne 1.kişi tarafından üretilip üretilmediğini kontrol eder.
                    if(context == null)
                    {
                        context = new ThreadSafeDbContext();
                    }
                }
            }
            return context;
        }
    }
}
