using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Rectangle
    {
        int width, height;
        public Rectangle()
        {
            width= height=0;
        }
        public Rectangle(int w, int h)
        {
            width = w;
            height =h ;
        }
        public Rectangle(int x)
        {
            width = height = x;
        }
    }
}
