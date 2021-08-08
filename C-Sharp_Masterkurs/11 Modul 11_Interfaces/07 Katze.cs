using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class Katze : ITier
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Die Katze frisst.");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Katze trinkt.");
        }

    }
}
