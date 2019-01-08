using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        public static Singleton singleton;

        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }
    }
}
