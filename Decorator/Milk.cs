using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Milk : IBeverage
    {
        IBeverage beverage;

        public Milk(IBeverage bev)
        {
            beverage = bev;
        }

        public double getCost()
        {
            return beverage.getCost() + 0.15;
        }

        public string getDescription()
        {
            return beverage.getDescription() + ", milk";
        }
    }
}
