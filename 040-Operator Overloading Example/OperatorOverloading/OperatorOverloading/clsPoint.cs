using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class clsPoint(int X, int Y)
    {
        public int x { get; set; } = X;
        public int y { get; set; } = Y;

        public static clsPoint  operator +(clsPoint P1, clsPoint P2)
        {
            return new clsPoint(P1.x + P2.x, P1.y + P2.y);
        }
        public static clsPoint operator -(clsPoint P1, clsPoint P2)
        {
            return new clsPoint(P1.x - P2.x, P1.y - P2.y);
        }
        public static clsPoint operator *(clsPoint P1, clsPoint P2)
        {
            return new clsPoint(P1.x * P2.x, P1.y * P2.y);
        }
        public static clsPoint operator /(clsPoint P1, clsPoint P2)
        {
            return new clsPoint(P1.x / P2.x, P1.y / P2.y);
        }
        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
}
