using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter(new BubbleSort());
            sorter.sort();

            sorter = new Sorter(new QuickSort());
            sorter.sort();

            System.Console.ReadLine();
        }
    }
}
