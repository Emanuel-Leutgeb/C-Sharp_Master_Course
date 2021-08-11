using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
                                                                                //Delegaten
    //public delegate bool FilterDelegate(string str);                          

                                                                                //Multicast Delegaten
    public delegate void AusgabeDelegate(string strA);                          


    public class Modul17
    {
        public Modul17()
        {
        }
        public void Delegaten()
        {
            /*
            List<string> namen = new List<string>()
            {
                "Horst",
                "Alina",
                "Emanuel",
                "Sabine",
                "Miriam",
                "Hubert",
                "Herbert"
            };
            */

            /*                                                                  //Delegaten mit Methoden
            List<string> newList1 = ReturnNewList(namen, StartsWithH);

            foreach(string name in newList1)
                Console.WriteLine(name);

            Console.WriteLine();

            List<string> newList2 = ReturnNewList(namen, LongerThanFive);

            foreach (string name in newList2)
                Console.WriteLine(name);
            */

            /*
                                                                                //Anonyme Methoden, ist aber ALT!!
            //List<string> newList3 = ReturnNewList(namen, delegate (string name) { return name[0] == 'H' || name[0] == 'h'; });
            foreach (string name in newList3)
                Console.WriteLine(name);
            */

            /*
                                                                                //Lamda Ausdrücke, ist NEU!!
            List<string> newList4 = ReturnNewList(namen, (name) => { return name[0] == 'A' || name[0] == 'a'; });

            foreach (string name in newList4)
                Console.WriteLine(name);
            */

            ///*                                                                  //Multicast Delgaten
            AusgabeDelegate ausgabe = new AusgabeDelegate(SayHello);
            ausgabe += SayGoodBye;

            ausgabe ("Emanuel");
            ausgabe ("Miriam");
            
        }

        /*
        public static List<string> ReturnNewList(List<string> original, FilterDelegate filterMethode)
        {
            List<string> newList = new List<string>();

            foreach (string str in original)
            {
                if (filterMethode(str) == true)
                    newList.Add(str);
            }

            return newList;
        }
        */

        /*                                                                      //Methoden
        public static bool StartsWithH(string str)
        {
            return (str[0] == 'H' || str[0] == 'h');
        }

        public static bool LongerThanFive(string str)
        {
            return str.Length > 5; 
        }
        */

        ///*                                                                      //Multicast Delegaten
        static void SayHello(string name)
        {
            Console.WriteLine(name + " says hello!");
        }

        static void SayGoodBye(string name)
        {
            Console.WriteLine(name + " says GoodBye!");
        }
    }
}