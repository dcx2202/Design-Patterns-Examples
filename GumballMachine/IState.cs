using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    interface IState
    {
        void refill();
        void turnCrank();
        void insertQuarter();
        void ejectQuarter();
        void dispense();
    }
}
