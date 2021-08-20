using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Parallel_LINQ
    {
        public Parallel_LINQ()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            var allEvenNumbers = from num in numbers.AsParallel().AsOrdered()
                                 where num % 2 == 0
                                 select num;

            foreach(int number in allEvenNumbers)
                Console.WriteLine(number);
        }
    }
}
