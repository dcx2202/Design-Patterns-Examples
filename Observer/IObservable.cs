using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObservable
    {
        void registerObserver(IObserver observer);
        void notifyObservers();
        void removeObserver(IObserver observer);
    }
}
