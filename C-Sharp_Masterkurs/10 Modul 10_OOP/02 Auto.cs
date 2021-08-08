using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class Auto
    {
        //Eigenschaften
        public string Marke { get; set; }   //Automatische Implementierung      //get = lesen set = schreiben

        private int anzahlTüren;            //Manuelle Implementierung          //get & set voll ausgeschrieben
        public int AnzahlTüren
        {
            get
            {
                return anzahlTüren;
            }
            set
            {
                if (value < 1)
                {
                    anzahlTüren = 1;
                }
                else
                {
                    anzahlTüren = value;
                }
            }
        }
    }
}