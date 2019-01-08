using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class HiringManager
    {
        public abstract IInterviewer makeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.makeInterviewer();
            interviewer.interview();
        }
    }
}
