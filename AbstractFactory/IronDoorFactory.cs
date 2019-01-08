using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class IronDoorFactory : IFactory
    {
        public IDoor makeDoor()
        {
            return new IronDoor();
        }

        public IExpert makeExpert()
        {
            return new Welder();
        }
    }
}
