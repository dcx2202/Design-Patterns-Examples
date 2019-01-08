using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Developer : IInterviewer
    {
        public void interview()
        {
            System.Console.WriteLine("Dev interview.");
        }
    }
}
