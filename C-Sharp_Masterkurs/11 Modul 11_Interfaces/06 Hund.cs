using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class Hund : ITier
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst.");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt.");
        }
    }
}
