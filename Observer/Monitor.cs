using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Monitor : IObserver
    {
        public void update(double value)
        {
            System.Console.WriteLine("New value received: " + value);
        }
    }
}
