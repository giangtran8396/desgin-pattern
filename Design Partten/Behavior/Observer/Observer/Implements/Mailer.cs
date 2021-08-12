using Observer.Models;
using Observer.Observer;
using System;

namespace Observer.Implements
{
    class Mailer : IObserverUser
    {
        public void update(User user)
        {
            Console.WriteLine($"Mailer: User {user.Email}");
        }
    }
}
