using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Factory
    {
        public IDoor makeDoor(int height, int width)
        {
            return new WoodenDoor(height, width);
        }
    }
}
