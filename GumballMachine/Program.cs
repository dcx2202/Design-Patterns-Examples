using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballStateMachine machine = new GumballStateMachine(2);
            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.ejectQuarter();
            machine.insertQuarter();
            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.turnCrank();
            machine.refill();
            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.ejectQuarter();
            machine.insertQuarter();
            machine.insertQuarter();
            machine.turnCrank();

            System.Console.ReadLine();
        }
    }
}
