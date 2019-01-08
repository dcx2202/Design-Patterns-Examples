using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProxy
{
    class SafeDoorProxy
    {
        IDoor door;

        public SafeDoorProxy(IDoor aDoor)
        {
            door = aDoor;
        }

        public void close()
        {
            door.close();
        }

        public void open(string code)
        {
            if (code == "password")
                door.open();
            else
                System.Console.WriteLine("Password errada, tente novamente!");
        }
    }
}
