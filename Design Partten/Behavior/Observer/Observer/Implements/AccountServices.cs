using Observer.Models;
using Observer.Observer;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Implements
{
    public class AccountServices : ISubject
    {
        private readonly User _user;
        private readonly List<IObserverUser> _observerUsers;

        public AccountServices(string email,string ip)
        {
            this._user = new User();
            this._observerUsers = new List<IObserverUser>();
            this._user.Email = email;
            this._user.Ip = ip;
        }

        public void attach(IObserverUser observerUser)
        {
            this._observerUsers.Add(observerUser);
        }

        public void detach(IObserverUser observerUser)
        {
            if (this._observerUsers.Contains(observerUser))
                this._observerUsers.Remove(observerUser);
        }

        public void notifyAllObserver()
        {
            _observerUsers.ForEach(x => x.update(_user));
        }

        public void ChangeEmail(string email)
        {
            this._user.Email = email;
            this.notifyAllObserver();
        }

        public void ChangeIP(string ip)
        {
            this._user.Ip = ip;
            this.notifyAllObserver();
        }

        public void ShowUser()
        {
            Console.WriteLine($"Email: {this._user.Email}");
            Console.WriteLine($"IP: {this._user.Ip}");
        } 
    }
}
