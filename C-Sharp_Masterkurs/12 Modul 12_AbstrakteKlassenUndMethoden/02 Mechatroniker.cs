using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenUndMethoden
{
    public class Mechatroniker : Arbeiter
    {
        public Mechatroniker(string name, decimal gehalt) : base(name, gehalt)
        {
        }
        public override void ArbeitVerrichten()                                 //Arbeiter-Abstract: mit override muss man überschreiben bei abstract
        {
            Console.WriteLine("Der Mechatroniker " + Name + " betritt die Werkstatt.");
            Console.WriteLine("Er arbeitet dort mit Autos");
        }

        public override string ToString()                                       //Arbeiter-Virtuell: mit override kann man überschreiben bei virtuell wie hier bei der ToString() Methode
        {
            return "Es handelt sich um einen Mechatroniker! Sein Name ist " + Name;
        }
    }
}