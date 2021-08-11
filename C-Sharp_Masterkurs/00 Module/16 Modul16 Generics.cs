using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul16
    {
        public Modul16()
        {
        }
        public void Generics()
        {
            /*
            WerteBehählter<string> behälter = new WerteBehählter<string>("Emanuel");
            behälter.WertAusgabe();
            */

            List<string> namensListe = new List<string>();
            AddMultiple<string>(namensListe, 20, "Sabine");

            foreach(string name in namensListe)
                Console.WriteLine(name);
        }

        static void AddMultiple<T>(List<T> list, int amount, T value)
        {
            for(int i = 0; i < amount; i++)
            {
                list.Add(value);
            }
        }
    }

    /*
    public class WerteBehählter<T>                                              //T = Platzhalter für Wertetypen
    {
        public T MeinWert { get; set; }

        public WerteBehählter(T wert)
        {
            MeinWert = wert;
        }

        public void WertAusgabe()
        {
            Console.WriteLine(MeinWert.ToString());
        }
    }
    */
}