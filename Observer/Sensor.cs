using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Sensor : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        double value;

        public Sensor(double v)
        {
            value = v;
        }

        public void setValue(double v)
        {
            value = v;
            notifyObservers();
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.update(value);
        }

        public void registerObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}
