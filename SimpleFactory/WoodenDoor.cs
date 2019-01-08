using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class WoodenDoor : IDoor
    {
        int Height { get; set; }
        int Width { get; set; }

        public WoodenDoor(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int getHeight()
        {
            return Height;
        }

        public int getWidth()
        {
            return Width;
        }
    }
}
