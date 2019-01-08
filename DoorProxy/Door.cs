using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorProxy
{
    class Door : IDoor
    {
        public void close()
        {
            System.Console.WriteLine("Closing door.");
        }

        public void open()
        {
            System.Console.WriteLine("Opening door.");
        }
    }
}
