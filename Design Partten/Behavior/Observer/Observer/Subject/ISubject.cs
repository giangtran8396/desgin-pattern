using Observer.Observer;


namespace Observer.Subject
{
    public interface ISubject
    {
        void attach(IObserverUser observerUser);//them
        void detach(IObserverUser observerUser);//xoa
        void notifyAllObserver();//notify
    }
}
