using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    static class AreaCalculator
    {
        public static double GetRectangleArea(double highR, double broadR)
        {
            return highR * broadR;
        }

        public static double GetSquareArea(double sidelenght)
        {
            return sidelenght * sidelenght;
        }

        public static double GetCircleArea(double radius)
        {
            return ((radius * radius) * Math.PI);
        }

        public static double GetTriangleArea(double baselengh, double highT)
        {
            return ((baselengh * highT) / 2);
        }
    }
}
