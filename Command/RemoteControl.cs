using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class RemoteControl
    {
        public void submit(ICommand command)
        {
            command.execute();
        }
    }
}
