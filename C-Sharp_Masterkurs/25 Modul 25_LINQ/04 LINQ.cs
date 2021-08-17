using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class LINQ
    {
        public LINQ()
        {
            string[] names =
            {
                "Emanuel",
                "Miriam",
                "Sandra",
                "Mario"
            };

            var exampleQvery = from name in names
                               where name.Length < 6
                               select name;

            foreach(string name in exampleQvery)
            {
                Console.WriteLine(name);
            }

        }
    }
}
