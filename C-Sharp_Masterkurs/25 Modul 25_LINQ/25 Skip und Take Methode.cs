using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Skip_und_Take_Methode
    {
        public Skip_und_Take_Methode()
        {
            /*
            //Skip
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var newNumbers = numbers.Skip(4);

            foreach(int number in newNumbers)
            {
                Console.WriteLine(number);
            }
            */
            //------------------------------------------------------------------
            /*
            //SkipWhile
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var newNumbers = numbers.SkipWhile(number => number < 6);

            foreach (int number in newNumbers)
            {
                Console.WriteLine(number);
            }
            */
            //------------------------------------------------------------------
            /*
            //Take
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var newNumbers = numbers.Take(4);

            foreach(int number in newNumbers)
            {
                Console.WriteLine(number);
            }
            */
            //------------------------------------------------------------------
            /*
            //TakeWhile
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var newNumbers = numbers.TakeWhile(number => number < 6);

            foreach (int number in newNumbers)
            {
                Console.WriteLine(number);
            }
            */
            //------------------------------------------------------------------
        }
    }
}
