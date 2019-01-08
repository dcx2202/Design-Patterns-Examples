using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WoodenDoor : IDoor
    {
        public void getDescription()
        {
            System.Console.WriteLine("I am a wooden door.");
        }
    }
}
