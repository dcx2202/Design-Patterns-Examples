using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class SoldOut : IState
    {
        GumballStateMachine machine;

        public SoldOut(GumballStateMachine gsm)
        {
            machine = gsm;
        }

        public void dispense()
        {
            System.Console.WriteLine("No gumballs left.");
        }

        public void ejectQuarter()
        {
            System.Console.WriteLine("Sold out.");
        }

        public void insertQuarter()
        {
            System.Console.WriteLine("Sold out.");
        }

        public void refill()
        {
            System.Console.WriteLine("Refilling gumball machine.");
            machine.addGumballs();
            machine.setState("NoQuarter");
        }

        public void turnCrank()
        {
            System.Console.WriteLine("Sold out.");
        }
    }
}
