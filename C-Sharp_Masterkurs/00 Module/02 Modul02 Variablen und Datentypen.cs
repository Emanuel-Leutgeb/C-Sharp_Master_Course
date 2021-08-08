using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul02
    {
        public Modul02()
        {
        }
        public void VariablenUndDatentypen()
        {
            /*
            //1_Deklaration & Initialisieren

            //Deklaration
            string username;

            //Initialisierung
            username = "Emanuel";

            //oder

            //deklaration & initialisieren zugleich
            string username1 = "Emanuel";
            int age = 24;
            //Ausgabe
            Console.WriteLine("Name: " + username);
            Console.WriteLine("Alter: " + age);

            username = "Miriam";

            Console.WriteLine(username);


            //2_Datentypen für Ganzzahlen
            byte zahl1 = 200;
            short zahl2 = -20000;
            int zahl3 = -2000000;
            long zahl4 = 2000000000;
            sbyte zahl5 = 127;
            ushort Zahl6 = 30000;
            //usw.
            Console.WriteLine(zahl3);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);


            //3_Datentypen für Fließkommerzahlen
            float zahl1 = 2.25F;
            double zahl2 = 2.2680;
            decimal zahl3 = 12.34M;

            Console.WriteLine(zahl2);


            //4_Datentypen für Textwerte
            string text = "Hallo Welt";
            char character = 'B';

            bool wahrheitswert = false;

            Console.WriteLine(wahrheitswert);


            //5_Consoleneingabe
            Console.Write("Gebe deinen Namen ein: ");
            string name = Console.ReadLine();

            Console.Write("Gebe dein Alter ein: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hallo {0} du bist {1} Jahre alt!", name, age);
            Console.WriteLine("Hallo " + name + " du bist " + age + " Jahre alt!");
            */

            /*
            //6_Aufgabe1

            Console.Write("Gib dein Alter ein: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Du bist {0} Jahre alt!", age);


            long cash = 185000000000;
            Console.WriteLine("Das Vermögen des reichsten Menschen ist {0} Dollar!", cash);
            Console.ReadKey();

            //bool verheiratet = true
            Console.Write("Hallo sind Sie verheiratet? Ja oder Nein: ");
            string antwort = Console.ReadLine();
            string Ja = "bereits";
            string Nein = "nicht";
            Console.WriteLine("Sie sind {0} {1} verheiratet", Ja, Nein);


            Console.WriteLine("Wie lautet Ihr Name?: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hallo " + Name);


            Console.WriteLine("Wie lautet Ihr Name?: ");
            string Name = Console.ReadLine();
            char letter = Name[0];
            Console.WriteLine(letter);
    

            decimal Müsli = 4.98M;
            Console.WriteLine("Das Müsli kostet " + Müsli + "€");
            */

            /*
            //7_Aufgabe2
            Console.WriteLine("Hallo!");
            Console.Write("Wie heißen Sie? ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Hallo " + firstname);
            Console.Write("Wie lautet ihr Nachname? ");
            string lastname = Console.ReadLine();

            Console.Write("Wie alt sind Sie? ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(age);

            Console.WriteLine(" ");
            Console.WriteLine("Hallo {0} {1}, willkommen zurück!", firstname, lastname);
            */
        }
    }
}