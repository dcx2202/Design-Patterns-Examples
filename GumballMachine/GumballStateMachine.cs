using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class GumballStateMachine
    {
        Dictionary<string, IState> states = new Dictionary<string, IState>();
        IState current;
        int nGumballs = 0;
        int refillAmount = 5;

        public GumballStateMachine(int gumballs)
        {
            states.Add("HasQuarter", new HasQuarter(this));
            states.Add("NoQuarter", new NoQuarter(this));
            states.Add("Sold", new Sold(this));
            states.Add("SoldOut", new SoldOut(this));
            if(gumballs == 0)
                current = states["SoldOut"];
            else
            {
                nGumballs = gumballs;
                current = states["NoQuarter"];
            }
        }

        public int getGumballsCount()
        {
            return nGumballs;
        }

        public void setState(string state)
        {
            current = states[state];
        }

        public void refill()
        {
            current.refill();
        }

        public void addGumballs()
        {
            nGumballs += refillAmount;
        }

        public void removeGumball()
        {
            nGumballs--;
        }

        public void turnCrank()
        {
            current.turnCrank();
            current.dispense();
        }

        public void insertQuarter()
        {
            current.insertQuarter();
        }

        public void ejectQuarter()
        {
            current.ejectQuarter();
        }
    }
}
