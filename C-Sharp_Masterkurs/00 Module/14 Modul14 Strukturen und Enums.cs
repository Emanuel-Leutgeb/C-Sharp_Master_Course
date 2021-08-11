using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul14
    {
        public Modul14()
        {
        }
        public void StrukturenUndEnums()
        {
            /*
            Point point;
            point.x = 10;
            point.y = 5;

            Console.WriteLine(point.x + ", " + point.y);
            */

            /*
            Point point = new Point(10, 5);
            Point point1 = point;
            point.MovePosition(3, 6);
            point1.x = 15;
            point1.y = 13;
            Console.WriteLine(point.x + ", " + point.y);
            Console.WriteLine(point1.x + ", " + point1.y);
            */

            /*
            Stopwatch sw = new Stopwatch();

            Point[] points = new Point[500000000];

            sw.Start();

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, i);
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].MovePosition(1, 1);
            }

            sw.Stop();

            Console.WriteLine("Fertig!");
            Console.WriteLine("Verstrichene Zeit: " + sw.ElapsedMilliseconds);
            */

            Person person = new Person("Emanuel", Geschlecht.Männlich);
            Console.WriteLine(person.Geschlecht);
            Console.WriteLine((int)person.Geschlecht);
        }
    }

    /*
    public struct Point                                                         // struct um 95% schneller (MacBook Pro) bei dieser Aufgabe
    {
        public int x;
        public int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void MovePosition(int x_movement, int y_movement)
        {
            x += x_movement;
            y += y_movement;
        }

    }
    */

    public enum Geschlecht
    {
        //Männlich = 0,
        //Weiblich = 1,
        //Divers = 2
        //Oder (ist das gleiche)
        Männlich,
        Weiblich,
        Divers
    }

    public class Person
    {
        public string Name { get; set; }
        public Geschlecht Geschlecht { get; set; }

        public Person(string name, Geschlecht geschlecht)
        {
            Name = name;
            Geschlecht = geschlecht;
        }
    }
}