using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TurnOn : ICommand
    {
        IDevice bulb;

        public TurnOn(IDevice device)
        {
            bulb = device;
        }

        public void execute()
        {
            bulb.turnOn();
        }

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            bulb.turnOff();
        }
    }
}
