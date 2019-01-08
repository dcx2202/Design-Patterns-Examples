using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage coffee = new Coffee();
            coffee = new Whipp(coffee);
            coffee = new Whipp(coffee);
            coffee = new Milk(coffee);
            coffee = new Milk(coffee);

            System.Console.WriteLine("Beverage: " + coffee.getDescription() + "  Cost: " + coffee.getCost());

            System.Console.ReadLine();
        }
    }
}
