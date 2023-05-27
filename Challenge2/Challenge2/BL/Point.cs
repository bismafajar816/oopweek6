using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
