using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class NoQuarter : IState
    {
        GumballStateMachine machine;

        public NoQuarter(GumballStateMachine gsm)
        {
            machine = gsm;
        }

        public void dispense()
        {
            System.Console.WriteLine("No quarter.");
        }

        public void ejectQuarter()
        {
            System.Console.WriteLine("No quarter to eject.");
        }

        public void insertQuarter()
        {
            System.Console.WriteLine("You inserted a quarter!");
            machine.setState("HasQuarter");
        }

        public void refill()
        {
            System.Console.WriteLine("Can't refill now.");
        }

        public void turnCrank()
        {
            System.Console.WriteLine("Insert a quarter first!");
        }
    }
}
