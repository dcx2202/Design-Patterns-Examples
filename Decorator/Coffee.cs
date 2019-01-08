using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Coffee : IBeverage
    {
        public Coffee()
        {

        }

        public double getCost()
        {
            return 0.65;
        }

        public string getDescription()
        {
            return "Coffee";
        }
    }
}
