using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenUndMethoden
{
    public class Rectangle : Shape
    {
        double Width { get; set; }
        double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rechteck mit einer Höhe von " + Height + " und Breite von " + Width + ".";
        }
    }
}
