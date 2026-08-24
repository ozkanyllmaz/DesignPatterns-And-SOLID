//using SingletonPattern;

//DbContext dbContext1 = DbContext.getInstance();
//DbContext dbContext2 = DbContext.getInstance();

//if(dbContext1 == dbContext2)
//{
//    Console.WriteLine("Bu nesneler birbiriyle aynı");
//} else
//{
//    Console.WriteLine("Bu nesneler birbirinden farklı");
//}


//-------------------------------------------------------------------

//// Lazy Singleton

//using SingletonPattern;

//LazyDbContext context1 = LazyDbContext.GetInstance();
//LazyDbContext context2 = LazyDbContext.GetInstance();

//if (context1 == context2)
//{
//    Console.WriteLine("Bu nesneler birbiriyle aynı");
//}
//else
//{
//    Console.WriteLine("Bu nesneler birbirinden farklı");
//}


//-------------------------------------------------------------------

// Lazy Singleton

using SingletonPattern;

ThreadSafeDbContext context1 = ThreadSafeDbContext.GetInstance();
ThreadSafeDbContext context2 = ThreadSafeDbContext.GetInstance();

if (context1 == context2)
{
    Console.WriteLine("Bu nesneler birbiriyle aynı");
}
else
{
    Console.WriteLine("Bu nesneler birbirinden farklı");
}