using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class Hund2
    {
        //Eigenschaften
        public int Alter { get; set; }

        public string Name { get; set; }

        public string Rasse { get; set; }

        //Methode

        public void Fressen()
        {
            Console.WriteLine("Der Hund " + Name + " frisst gerade!");
        }
        public void Bellen()
        {
            Console.WriteLine("Der Hund " + Name + " bellt gerade!");
        }
    }

    class Wachhund : Hund2      //Vererbung geschieht durch ":"
    {
        //Methode
        public void BewacheHaus()
        {
            Console.WriteLine("Der Hund " + Name + " bewacht das Haus!");
        }
    }
}
