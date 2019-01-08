using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory WoodenDoorFactory = new WoodenDoorFactory();
            IFactory IronDoorFactory = new IronDoorFactory();

            IDoor WoodenDoor = WoodenDoorFactory.makeDoor();
            IDoor IronDoor = IronDoorFactory.makeDoor();

            IExpert Carpenter = WoodenDoorFactory.makeExpert();
            IExpert Welder = IronDoorFactory.makeExpert();

            WoodenDoor.getDescription();
            Carpenter.getDescription();

            IronDoor.getDescription();
            Welder.getDescription();

            System.Console.ReadLine();
        }
    }
}
