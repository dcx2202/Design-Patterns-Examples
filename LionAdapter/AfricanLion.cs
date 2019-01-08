using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionAdapter
{
    class AfricanLion : ILion
    {
        public void roar()
        {
            System.Console.WriteLine("Roars in african.");
        }
    }
}
