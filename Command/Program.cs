using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice bulb = new Bulb();

            ICommand turnOn = new TurnOn(bulb);
            ICommand turnOff = new TurnOff(bulb);

            RemoteControl remote = new RemoteControl();
            remote.submit(turnOn);
            remote.submit(turnOff);

            System.Console.ReadLine();
        }
    }
}
