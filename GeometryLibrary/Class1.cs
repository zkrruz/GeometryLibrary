using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Geometry
    {
        public static double GetArea(double[] sides)
        {
            if (sides.Length == 1)
            {
                return Math.PI * sides[0] * sides[0];
            }
            else if (sides.Length == 3)
            {
                double a = sides[0], b = sides[1], c = sides[2];
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }
            else
            {
                throw new ArgumentException("Invalid number of sides");
            }
        }

        public static bool IsRightTriangle(double[] sides)
        {
            if (sides.Length == 3)
            {
                Array.Sort(sides);
                double a = sides[0], b = sides[1], c = sides[2];
                return Math.Abs(c * c - a * a - b * b) < 0.0001;
            }
            else
            {
                throw new ArgumentException("Invalid number of sides");
            }
        }
    }
}
