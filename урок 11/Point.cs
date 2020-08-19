using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_11
{
    class Point
    {
        public int x { get;}
        public int y { get;}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator==(Point p1, Point p2)
        {
            if(p1.x == p2.x|| p1.y == p2.y)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        public static bool operator !=(Point p1, Point p2)
        {

            return false;

        }
    }
}
