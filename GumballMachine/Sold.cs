using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class Sold : IState
    {
        GumballStateMachine machine;

        public Sold(GumballStateMachine gsm)
        {
            machine = gsm;
        }

        public void dispense()
        {
            if (machine.getGumballsCount() > 0)
            {
                System.Console.WriteLine("Dispensing one gumball.");
                machine.removeGumball();
                if (machine.getGumballsCount() == 0)
                    machine.setState("SoldOut");
                else
                    machine.setState("NoQuarter");
            }
            else
            {
                System.Console.WriteLine("Out of gumballs.");
                machine.setState("HasQuarter");
                machine.ejectQuarter();
                machine.setState("SoldOut");
            }
        }

        public void ejectQuarter()
        {
            System.Console.WriteLine("Can't eject quarter now.");
        }

        public void insertQuarter()
        {
            System.Console.WriteLine("Can't insert quarter now.");
        }

        public void refill()
        {
            System.Console.WriteLine("Can't refill now.");
        }

        public void turnCrank()
        {
            System.Console.WriteLine("Can't turn the crank now.");
        }
    }
}
