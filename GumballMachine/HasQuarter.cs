using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class HasQuarter : IState
    {
        GumballStateMachine machine;

        public HasQuarter(GumballStateMachine gsm)
        {
            machine = gsm;
        }

        public void dispense()
        {
            System.Console.WriteLine("Not now.");
        }

        public void ejectQuarter()
        {
            System.Console.WriteLine("Ejected quarter");
            machine.setState("NoQuarter");
        }

        public void insertQuarter()
        {
            System.Console.WriteLine("You have already inserted a quarter.");
        }

        public void refill()
        {
            System.Console.WriteLine("Can't refill now");
        }

        public void turnCrank()
        {
            System.Console.WriteLine("Turning crank!");
            machine.setState("Sold");
        }
    }
}
