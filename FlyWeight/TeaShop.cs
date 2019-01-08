using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class TeaShop
    {
        TeaMaker teamaker = new TeaMaker();

        public void takeOrder(int table, string preference)
        {
            Tea order = teamaker.makeTea(preference);
            System.Console.WriteLine("Serving " + preference + " tea to table " + table);
        }
    }
}
