using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Bulb : IDevice
    {
        public void turnOff()
        {
            System.Console.WriteLine("I'm off.");
        }

        public void turnOn()
        {
            System.Console.WriteLine("I'm on.");
        }
    }
}
