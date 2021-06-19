using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteSubject : ISubject
    {
        private List<IObserver> list = new List<IObserver>();
        private string lastUpdate = "";
        public void Register(IObserver observer)
        {
            list.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            list.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver item in list)
                item.Update(lastUpdate);
            
        }

        public void SendAnUpdate(string s) {
            lastUpdate = s;
            Notify();
        }

    }
}
