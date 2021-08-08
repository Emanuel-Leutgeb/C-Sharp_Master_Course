using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul06
    {
        public Modul06()
        {
        }
        public void Arrays()
        {
            /*
            //1D Array
            //string[] names = new string[4] { "Miriam", "Emanuel", "Jesus", "Gott" };
            string[] names = new string[4] { "Emanuel", "Miriam", "Gott", "Jesus" };
            
            //names[0] = "Gott";
            //names[1] = "Jesus";
            //names[2] = "Emanuel";
            //names[3] = "Miriam";
            
            {
                "Jesus",
                "Gott",
                "Miriam",
                "Emanuel"

            }

            Console.WriteLine(names[1]);

            //2D Array
            string[,] products = new string[4, 2];

            //Produkt 1
            products[0, 0] = "Senf";
            products[1, 0] = "1€";

            //Produkt 2
            products[0, 1] = "iPhone12";
            products[1, 1] = "Ausverkauft";
            */

            /*
            //Aufgabe1.1
            string[] products = new string[4];

            products[0] = "Wasserflasche";
            products[1] = "Kaugummi";
            products[2] = "Nudeln";
            products[3] = "Kartoffeln";

            Console.WriteLine(products[1]);
            */

            /*
            //Aufgabe1.2
            string[] products = new string[4] { "Wasserflasche", "Kaugummi", "Nudeln", "Kartoffeln" };
            Console.WriteLine(products[2]);
            */

            /*
            //Aufgabe2.1
            string[,] names = new string[2, 4];

            names[0, 0] = "Sabine";
            names[1, 0] = "Müller";
            names[0, 1] = "Sandra";
            names[1, 1] = "Maier";
            names[0, 2] = "Klaus";
            names[1, 2] = "Schmied";
            names[0, 3] = "Max";
            names[1, 3] = "Mustermann";

            Console.WriteLine(names[0, 3] + " " + names[1, 3]);
            */

            /*
            //Aufgabe2.2
            string[,] names = new string[,]
            {
                {
                "Sabine",
                "Sandra",
                "Klaus",
                "Max"
                },

                {
                "Müller",
                "Maier",
                "Schmied",
                "Mustermann"
                },
            };

            Console.WriteLine(names[0, 2] + " " + names[1, 2]);
            */
        }
    }
}