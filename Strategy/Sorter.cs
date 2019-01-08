using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Sorter
    {
        private ISort sortalg;

        public Sorter(ISort sorter)
        {
            sortalg = sorter;
        }

        public void sort()
        {
            sortalg.sort();
        }
    }
}
