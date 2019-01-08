using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Whipp : IBeverage
    {
        IBeverage beverage;

        public Whipp(IBeverage bev)
        {
            beverage = bev;
        }

        public double getCost()
        {
            return beverage.getCost() + 0.10;
        }

        public string getDescription()
        {
            return beverage.getDescription() + ", whipp";
        }
    }
}
