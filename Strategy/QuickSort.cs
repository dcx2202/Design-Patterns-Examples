﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuickSort : ISort
    {
        public void sort()
        {
            System.Console.WriteLine("Sorting with quick sort.");
        }
    }
}
