using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul21
    {
        public Modul21()
        {
        }
        public void RandomKlassen()
        {
            /*
            //Random

            //Erzeuge Random-Objekt
            Random rnd1 = new Random();

            //Erzeuge Zufallszahl
            int zahl1 = rnd1.Next();

            //Erzeuge Zufallszahl im definierten Bereich
            int zahl2 = rnd1.Next(1, 10000);

            //Ausgabe
            Console.WriteLine(zahl2);
            */

            /*
            //Random.Next

            string[] städte = new string[]
            {
                "Wien",
                "Linz",
                "Wels",
                "Graz",
                "Innsbruck",
                "Bregenz",
            };

            //Erzeuge Random-Objekt
            Random rnd2 = new Random();

            //Erzeuge zufälligen Index
            int index = rnd2.Next(0, städte.Length);

            //Ausgabe
            Console.WriteLine(städte[index]);
            */

            /*
            //Random.NextDouble

            //Erzeuge Random-Objekt
            Random rnd3 = new Random();

            //Erzeuge Zufallsdouble
            double zahl3 = rnd3.NextDouble();

            //Ausgabe
            Console.WriteLine(zahl3);
            */

            /*
            //Random.NextBytes

            byte[] zahlenReihe = new byte[20];

            //Erzeuge Random-Objekt
            Random rnd4 = new Random();

            //Erzeuge Zufallsarray
            rnd4.NextBytes(zahlenReihe);

            //Ausgabe
            foreach(byte zahl5 in zahlenReihe)
                Console.WriteLine(zahl5);
            */

            /*
            //Random mit Seed

            //Erzeuge Random-Objekt
            Random rnd5 = new Random(1235756);

            //Ausgabe der Zufallszahlen mit Seed bleibt immer gleich
            Console.WriteLine(rnd5.Next(1, 10));
            Console.WriteLine(rnd5.Next(1, 10));
            Console.WriteLine(rnd5.Next(1, 10));
            Console.WriteLine(rnd5.Next(1, 10));
            Console.WriteLine(rnd5.Next(1, 10));
            */
        }
    }
}