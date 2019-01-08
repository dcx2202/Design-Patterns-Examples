using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoor door = new Door();

            door.open();
            door.close();

            var SafeDoor = new SafeDoorProxy(door);

            SafeDoor.open("teste");
            SafeDoor.open("password");
            SafeDoor.close();

            System.Console.ReadLine();
        }
    }
}
