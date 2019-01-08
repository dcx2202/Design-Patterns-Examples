using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WoodenDoorFactory : IFactory
    {
        public IDoor makeDoor()
        {
            return new WoodenDoor();
        }

        public IExpert makeExpert()
        {
            return new Carpenter();
        }
    }
}
