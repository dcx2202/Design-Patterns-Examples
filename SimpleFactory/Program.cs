using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IDoor door = factory.makeDoor(20, 80);
            System.Console.WriteLine("Door dimensions: " + door.getHeight() + "x" + door.getWidth());

            System.Console.ReadLine();
        }
    }
}
