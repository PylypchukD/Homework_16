using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point2.Y + point1.Y, point1.Z + point2.Z);
        }
    }
}
