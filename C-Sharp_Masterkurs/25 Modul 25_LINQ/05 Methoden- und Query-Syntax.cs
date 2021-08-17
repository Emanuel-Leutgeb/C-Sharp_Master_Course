using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Methoden_und_Query_Syntax
    {
        public Methoden_und_Query_Syntax()
        {
            string[] names =
            {
                "Emanuel",
                "Miriam",
                "Sandra",
                "Mario",
                "Renate"
            };

            var testQvery1 = from name in names                                 //Query Syntax
                             where name.Contains('e')
                             select name;

            var testQvery2 = names.Where((name) => name.Contains('a'));         //Methoden Synatx

                
            foreach(string name in testQvery2)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
