using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class Hund
    {
        //Eigenschaften
        public int Alter { get; set; }

        public string Name { get; set; }

        public string Besitzer { get; set; }

        //Konstruktor
        public Hund(int alter, string name, string besitzer)
        {
            Alter = alter;
            Name = name;
            Besitzer = besitzer;
        }

    }
}