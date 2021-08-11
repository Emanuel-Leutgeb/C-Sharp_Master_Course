using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul15_Collections
{
    public class Program_Collections
    {
        public Program_Collections()
        {
        }

        public void Modul15()
        {
            //Aufgabe1
            List<string> names = new List<string>()
            {
                "Peter",
                "Alina",
                "Sabine",
                "Florian"
            };
           
            Console.WriteLine("Unsortiert!");
            Console.WriteLine("-----------");

            foreach (string namesUnsort in names)
            {
                Console.WriteLine(namesUnsort);
            }

            Console.WriteLine();
            Console.WriteLine("Sortiert!");
            Console.WriteLine("-----------");

            names.Sort();

            foreach (string namesUnsort in names)
            {
                Console.WriteLine(namesUnsort);
            }
        }
    }
}