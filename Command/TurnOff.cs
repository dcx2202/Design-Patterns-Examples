using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TurnOff : ICommand
    {
        IDevice bulb;

        public TurnOff(IDevice device)
        {
            bulb = device;
        }

        public void execute()
        {
            bulb.turnOff();
        }

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            bulb.turnOn();
        }
    }
}
