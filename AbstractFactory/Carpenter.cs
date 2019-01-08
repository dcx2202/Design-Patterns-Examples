using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Carpenter : IExpert
    {
        public void getDescription()
        {
            System.Console.WriteLine("I fit wooden doors.");
        }
    }
}
