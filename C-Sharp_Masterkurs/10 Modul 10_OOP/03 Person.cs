using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    public class Person
    {
        /*                                      //WertetypenUndReferenztypen
        public string Vorname { get; set; }

        public string Nachname { get; set; }
        */

                                                //Konstruktor
        //Eigenschaften
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public int Alter { get; set; }

        //Konstruktor
        public Person(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }
        
    }
}
