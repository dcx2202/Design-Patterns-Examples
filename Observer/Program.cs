using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor(1.5);
            IObserver monitor = new Monitor();

            sensor.registerObserver(monitor);
            sensor.setValue(2.1);

            System.Console.ReadLine();
        }
    }
}
