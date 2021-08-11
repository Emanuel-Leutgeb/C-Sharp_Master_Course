using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul15_Collections
{
    public class Lists
    {
        public Lists()
        {
            List<string> namensListe = new List<string>()
            {
                "Emanuel",
                "Miriam",
                "Herbert",
                "Markus"
            };
            //Oder
            /*
            namensListe.Add("Emanuel");
            namensListe.Add("Emil");
            namensListe.Add("Miriam");
            namensListe.Add("Georg");
            namensListe.Add("Sabrina");
            namensListe.Add("Katharina");

            namensListe.Remove("Miriam");
            namensListe.RemoveAt(5);
            */

            /*
            foreach (string name in namensListe)
            {
                Console.WriteLine(name);
            }
            */
            Console.WriteLine(namensListe[3]);
        }
    }
}
