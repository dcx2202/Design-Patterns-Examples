using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaShop teashop = new TeaShop();

            teashop.takeOrder(1, "no sugar");
            teashop.takeOrder(2, "hot");

            System.Console.ReadLine();
        }
    }
}
