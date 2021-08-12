using Observer.Implements;
using Observer.Subject;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountServices AccountService = new AccountServices("demo1", "127.0.0.1");
            AccountService.attach(new Mailer());
            AccountService.attach(new Logger());
            AccountService.ShowUser();
            Console.WriteLine("-------");
            AccountService.ChangeEmail("demo2");
            Console.WriteLine("-------");
            AccountService.ChangeIP("192.168.1.1");
            Console.ReadLine();
        }
    }
}
