using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Dauer_einer_Query_messen
    {
        public Dauer_einer_Query_messen()
        {
            //Erstelle Stoppuhr und das Array
            Stopwatch sw = new Stopwatch();
            var numbers = Enumerable.Range(1, 1999999999);

            //Zwei Beispiel-Queries mit Modulo Operator
            var query1 = from num in numbers
                        where num % 135798642 == 0
                        select num;

            var query2 = from num in numbers.AsParallel()
                         where num % 135798642 == 0
                         select num;

            Console.WriteLine("Loading...");

            //Query ohne Parallelisierung
            sw.Start();

            foreach(int num in query1)
                Console.WriteLine(num);

            sw.Stop();
            Console.WriteLine("Without PLINQ: " + sw.ElapsedMilliseconds + "ms");
            Console.WriteLine("----------------------");
            sw.Reset();

            //Query mit Parallelisierung                                        //nur bei mehereren Sekunden Abfagen benutzen.
            sw.Start();

            foreach (int num in query2)
                Console.WriteLine(num);

            sw.Stop();
            Console.WriteLine("With PLINQ: " + sw.ElapsedMilliseconds + "ms");
            Console.WriteLine("----------------------");
            sw.Reset();
        }
    }
}
