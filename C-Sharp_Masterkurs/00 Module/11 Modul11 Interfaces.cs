using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Masterkurs.Modul11_Interfaces;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul11
    {
        public Modul11()
        {
        }
        public void Interfaces()                //Interfaces sind Schnittstellen (en -> de)
        {
            Program_Interfaces program_Interfaces = new Program_Interfaces();
            program_Interfaces.Modul11();
        }
    }
    /*
    interface ITier //I steht für Interface und soll mitgeschrieben werden.
    {
        //Eigenschaften
        string Name { get; set; }
        string Geschlecht { get; set; }

        //Methoden
        void Essen();
        void Trinken();
    }

    class Löwe : ITier
    {
        //Eigenschaften                     // auf public setzen
        public string Name { get; set; }
        public string Geschlecht { get; set; }
       
        //Methoden                          // auf public setzen
        public void Essen()
        {
            Console.WriteLine("Der Löwe isst.");
        }
        public void Trinken()
        {
            Console.WriteLine("Der Löwe trinkst.");
        }
        public void Jagen()
        {
            Console.WriteLine("Der Löwe jagt.");
        }
    }
    */
}