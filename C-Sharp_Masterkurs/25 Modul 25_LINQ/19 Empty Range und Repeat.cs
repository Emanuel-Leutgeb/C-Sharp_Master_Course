using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Empty_Range_und_Repeat
    {
        public Empty_Range_und_Repeat()
        {
            //Empty

            var emptyCollection = Enumerable.Empty<string>();

            Console.WriteLine(emptyCollection.Count());
            Console.WriteLine(emptyCollection.GetType());

            Console.WriteLine();
            //Range

            var numbers1 = Enumerable.Range(10, 10);

            for (int i = 0; i < numbers1.Count(); i++)
            {
                Console.WriteLine("Index[{0}] = {1}", i, numbers1.ElementAt(i));
            }

            Console.WriteLine();
            //Repeat

            var numbers2 = Enumerable.Repeat<string>("Hallo Welt", 10);

            for (int i = 0; i < numbers2.Count(); i++)
            {
                Console.WriteLine("Index[{0}] = {1}", i, numbers2.ElementAt(i));
            }
        }
    }
}
