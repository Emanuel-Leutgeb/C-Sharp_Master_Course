using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class Program_OOP
    {
        public Program_OOP()
        {
        }
        public void Modul10()
        {
            /*                                                                  //KlassenBeispiel (class)
            Bankkonto konto1 = new Bankkonto();
            Bankkonto konto2 = new Bankkonto();

            konto1.Kontostand = 2500;
            konto2.Kontostand = 3000;

            konto1.Besitzer = "Sandra Müller";
            konto2.Besitzer = "Emanuel Leutgeb";

            konto1.Einzahlen(250);
            konto2.Einzahlen(400);

            konto1.Auszahlen(325.25M);
            konto2.Auszahlen(230.99M);

            Console.WriteLine("Kontostand 1: " + konto1.Kontostand + " und gehört " + konto1.Besitzer);
            Console.WriteLine("Kontostand 2: " + konto2.Kontostand + " und gehört " + konto2.Besitzer);
            */


            /*                                                                  //Eigenschaften
            Auto auto = new Auto();

            auto.Marke = "BMW";
            Console.WriteLine(auto.Marke);

            auto.AnzahlTüren = 0;
            Console.WriteLine(auto.AnzahlTüren);
            */


            /*                                                                  //ZugriffsebenenVonMembern
            public                  //Keine Zugriffsbeschränkung
            private                 //Zugriff auf die Klasse beschränkt
            protected               //Zugriff auf die Klasse und davon abgeleitete Typen beschränkt
            internal                //Zugriff auf die Assembly beschränkt
            protected internal      //Zugriff auf die Assembly oder die von der enthaltenen Klasse abgeleiteten Typen beschränkt
            */


            /*                                                                  //Wertetypen
            int zahl1 = 10;
            int zahl2 = zahl1;              //zahl2 kopiert zahl1
            Console.WriteLine(zahl1);
            Console.WriteLine(zahl2);
            Console.WriteLine();

            zahl2 = 3;
            Console.WriteLine(zahl1);
            Console.WriteLine(zahl2);
            Console.WriteLine();
            */


            /*                                                                  //Referenztypen
            Person person1 = new Person();
            Person person2 = person1;       //person1 und person2 zeigen (pointer) auf das selbe Objekt

            person1.Vorname = "Emanuel";
            person1.Nachname = "Leutgeb";

            Console.WriteLine(person1.Vorname + " " + person1.Nachname);
            Console.WriteLine(person2.Vorname + " " + person2.Nachname);
            */

            //Konstruktor
            //Person person = new Person();      //new = Konstruktoraufruf  //Konstruktor mit Parameter
            //Person person = new Person("Emanuel", "Leutgeb", 24);         //Konstruktor ohne Parameter

            //Console.WriteLine(person.Vorname + " " + person.Nachname + " " + person.Alter);


            /*
            Hund hund1 = new Hund(3, "Kathie", "Emanuel");

            Console.WriteLine("Mein Hund heißt " + hund1.Name + " und ist " + hund1.Alter + " Jahre alt!");
            Console.WriteLine("Der Hund gehört " + hund1.Besitzer + "!");
            */

            /*                                                                  //StatischeKlassen
            double fläche = Mathe.RechteckFläche(10, 15);
            Console.WriteLine(fläche + Mathe.RechteckFläche(12, 34));
            */

            /*
            double squareRoot = Math.Sqrt(50);
            Console.WriteLine(squareRoot);
            */


            /*                                                                  //Namespaces
            //using C_Sharp_Masterkurs.Modul10_OOP      //.Modul10_OOP wird automatisch gemacht, da dies sich in einem eigenen Ordner befindet. "using" muss ich im Hauptprogramm oben hinzufügen, wenn ich darauf zugreifen will. -siehe Programm Main und Modul 10 OOP 
            */


            /*                                                                  //Vererbung
            Hund2 coco = new Hund2();
            coco.Name = "Coco";
            coco.Alter = 11;
            coco.Rasse = "Weißer Schäferhund";
            coco.Fressen();
            coco.Bellen();

            Wachhund jil = new Wachhund();
            jil.Name = "Jil";
            jil.Alter = 8;
            jil.Rasse = "Rothweiler";
            jil.BewacheHaus();
            jil.Fressen();
            jil.Bellen();
            */


            /*                                                                  //Vererben Konstruktor
            ErbendeKlasse objekt = new ErbendeKlasse("Peter", 34);
            */


            /*                                                                  //is & as
            Console.WriteLine(coco is Hund2);
            Console.WriteLine(coco is Wachhund);
            Console.WriteLine(coco is Object);
            Console.WriteLine(23 is string);
            Console.WriteLine(23 is int);
            Console.WriteLine(23 is Object);
            Console.WriteLine("Emanuel" is string);
            Console.WriteLine("Emanuel" is Object);

            object[] objects = new object[4];

            objects[0] = "Hallo Welt";
            objects[1] = "Hello World";
            objects[2] = 23;
            objects[3] = false;

            foreach(object o in objects)
            {
                string text = o as string;

                if (text != null)
                {
                    Console.WriteLine(text);
                }
                
                else
                {
                    Console.WriteLine("Das Objekt ist kein String!");
                }
                
            }
            */


            /*
            //Aufgabe1
            Dog kathie = new Dog();
            kathie.Name = "Kathie";
            kathie.Age = 12;
            kathie.Race = "Schäferhund";
            kathie.Gender = "female";
            kathie.Bellen();
            kathie.Fressen();
            */

            /*
            //Aufgabe2
            Dog tibi = new Dog("Tibi", 19, "Goldie", "male");

            Console.WriteLine(tibi.Name + " " + tibi.Age + " " + tibi.Race + " " + tibi.Gender);
            tibi.Fressen();
            tibi.Bellen();
            */

            /*
            //Aufgabe3
            Console.WriteLine("Rechteck: "  + AreaCalculator.GetRectangleArea(10, 4));
            Console.WriteLine("Quadrat: "   + AreaCalculator.GetSquareArea(4));
            Console.WriteLine("Circle: "    + AreaCalculator.GetCircleArea(10));
            Console.WriteLine("Dreieck: "   + AreaCalculator.GetTriangleArea(5, 12));
            */

            /*
            //Aufgabe4
            School[] peopleInClass =
            {
                new Teacher("John", "Smith", 32),
                new Student("Sabrina", "Müller", 18),
                new Student("Anna", "Matt", 18),
                new Student("Peter", "Fredl", 18),
                new Student("Mathias", "Maier", 18)
            };

            foreach (School member in peopleInClass)
            {
                if (member is Teacher)
                {
                    member.PrintSchool();
                    (member as Teacher).Teach();
                }
                else if (member is Student)
                {
                    member.PrintSchool();
                    (member as Student).ListenToTeacher();
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
            */
        }   
    }
}