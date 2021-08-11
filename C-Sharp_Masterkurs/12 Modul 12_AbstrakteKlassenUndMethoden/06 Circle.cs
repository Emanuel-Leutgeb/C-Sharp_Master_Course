using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenUndMethoden
{
    public class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return "Kreis mit einem Radius von " + Radius + ".";
        }
    }
}
