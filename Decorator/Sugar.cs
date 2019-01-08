using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Sugar : IBeverage
    {
        IBeverage beverage;

        public Sugar(IBeverage bev)
        {
            beverage = bev;
        }

        public double getCost()
        {
            return beverage.getCost() + 0.05;
        }

        public string getDescription()
        {
            return beverage.getDescription() + ", sugar";
        }
    }
}
