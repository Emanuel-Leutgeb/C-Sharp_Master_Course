using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul13
    {
        public Modul13()
        {
        }
        public void Polymorphie()
        {
            /*
            Person emanuel = new Person("Emanuel", "Leutgeb");
            Person miriam = new Person("Miriam", "Forstinger");

            emanuel.Greet(miriam);                                              //Überlagerung von Methoden (personToGreet) // statische Polymorphie
            */

            /*
            //Aufgabe1
            Sum sum = new Sum(5, 6);
            Console.WriteLine(Sum.SummeDouble());
            Console.WriteLine();
            
            double[] numbers = new double[4];
            numbers[0] = 00.10;
            numbers[1] = 10.20;
            numbers[2] = 20.30;
            numbers[3] = 30.40;

            Console.WriteLine(Sum.SummeDouble(numbers));
            */

            //*
            //Aufgabe2
            Dog tibi = new Dog("Tibi", 10, "Emanuel");
            
            Dog kathie = new Dog("Kathie", 10);
        }
    }
    /*
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }

        public void Greet()
        {
            Console.WriteLine("{0} {1} says: Hello!", FirstName, LastName);
        }

        public void Greet(Person personToGreet)
        {
            Console.WriteLine("{0} {1} says: Hello {2} {3}", FirstName, LastName, personToGreet.FirstName, personToGreet.LastName);
        }
    }
    */

    /*
    public class Sum
    {
        public static double A { get; set; }
        public static double B { get; set; }

        public Sum(double a, double b)
        {
            A = a;
            B = b;
        }

        public static double SummeDouble()
        {
            return A + B; 
        }

        public static double SummeDouble(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
            //ODER Einfacher
            //foreach(double result in numbers)
            //{
            //    result += numbers;
            //}
        }
    }
    */

    //*
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Owner { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
            Owner = "No owner";

            Console.WriteLine("Der Hund heist {0} und ist {1} Jahre Alt.", Name, Age);
            Console.WriteLine();
        }

        public Dog(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;

            Console.WriteLine("Der Hund heist {0} und ist {1} Jahre Alt.", Name, Age);
            Console.WriteLine("Der Hund gehört {0}.", Owner);
            Console.WriteLine();
        }
    }
}