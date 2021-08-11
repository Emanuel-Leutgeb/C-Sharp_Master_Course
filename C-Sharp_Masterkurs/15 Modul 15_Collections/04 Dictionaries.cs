using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul15_Collections
{
    public class Dictionaries
    {
        public Dictionaries()
        {
            Dictionary<int, string> kunden = new Dictionary<int, string>();

            kunden.Add(001, "Emanuel");
            kunden.Add(002, "Miriam");
            kunden.Add(003, "Herbert");
            kunden.Add(004, "Michael");

            /*
            kunden.Remove(001);

            if (kunden.ContainsKey(002))

                Console.WriteLine(kunden[002]);
            */

            foreach (KeyValuePair<int, string> kundeninfo in kunden)
            {
                Console.WriteLine("Der Schlüssel {0} gehört zum Kunden {1}.", kundeninfo.Key, kundeninfo.Value);
            }
        }
    }
}
