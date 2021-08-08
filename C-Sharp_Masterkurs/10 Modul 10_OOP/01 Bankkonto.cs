using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class Bankkonto                                 //KlassenBeispiel (class)
    {
        //Eigenschaften
        public decimal Kontostand { get; set; }

        public string Besitzer { get; set; }

        //Metoden
        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
            Console.WriteLine("Es wurden " + betrag + " Euro auf das Konto eingezahlt!");
            Console.WriteLine("Der neue Kontostand beträgt " + Kontostand + " Euro!");
        }

        public void Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
            Console.WriteLine("Es wurden " + betrag + " Euro vom Konto abgehoben!");
            Console.WriteLine("Der neue Kontostand beträgt " + Kontostand + " Euro!");
        }
    }
}
