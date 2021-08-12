using Observer.Models;
using Observer.Observer;
using System;

namespace Observer.Implements
{
    public class Logger : IObserverUser
    {
        public void update(User user)
        {
            Console.WriteLine($"Logger {user.Ip}");
        }
    }
}
