using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DevelopmentManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }
}
