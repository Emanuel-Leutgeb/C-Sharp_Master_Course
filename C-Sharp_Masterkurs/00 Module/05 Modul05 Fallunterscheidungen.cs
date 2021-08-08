using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul05
    {
        public Modul05()
        {
        }
        public void Fallunterscheidungen()
        {
            /*
            //1_if-Abfragen
            int age = 17;
            bool withParents = true;

            if (age >= 18)
            {
                Console.WriteLine("Du darfst den Film sehen!");
            }
            else if (withParents == true)
            {
                Console.WriteLine("Du darfst den Film dank deiner Elten sehen!");
            }
            else
            {
                Console.WriteLine("Du darfst den Film NICHT sehen!");
            }

            //2_Boolesche Ausdruck
            int alter = 18;
            bool mobil = true;
            bool qualifiziert = true;
            bool testBestanden = false;
            bool schüchtern = false;

            if ((alter >= 18) && (mobil) && (qualifiziert || testBestanden) && !schüchtern)
            {
                Console.WriteLine("Du bekommst den Job!");
            }
            else
            {
                Console.WriteLine("Du bekommst den Job leider nicht!");
            }

            //3_Switch-Blöcke
            Console.Write("Command: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "SayHello":
                    Console.WriteLine("Hello!");
                    break;

                case "SayGoodbye":
                    Console.WriteLine("Goodbye!");
                    break;

                case "Smile":
                    Console.WriteLine(":D");
                    break;

                default:
                    Console.WriteLine("unexpected error!");
                    break;
            }
            */

            /*
            //4_Aufgabe1
            double BodyWeight;
            double BodySize;
            double BMI;

            //BMI
            //0-18.4        Untergewicht
            //18,5 - 24.9   Normalgewicht
            //25 - 29.9     Übergewicht
            //30 - 34.9     Adipositas Grad 1
            //35 - 39.9     Adipositas Grad 2
            //40            Adipositas Grad 3


            Console.WriteLine("Hello we are Checking your BMI");
            Console.Write("Please type your Body Weight in kg: ");
            BodyWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please type your Body Size in meter: ");
            BodySize = Convert.ToDouble(Console.ReadLine());

            BMI = (BodyWeight / (BodySize * BodySize));

            Console.WriteLine("Your BMI is {0}!", BMI);

            if (BMI <= 18.4)
            {
                Console.WriteLine("underweight");
            }
            if ((BMI >= 18.5) && (BMI <= 24.9))
            {
                Console.WriteLine("standartweight");
            }
            if ((BMI >= 25) && (BMI <= 29.9))
            {
                Console.WriteLine("overweight");
            }
            if ((BMI >= 30) && (BMI <= 34.9))
            {
                Console.WriteLine("obesity grade 1");
            }
            if ((BMI >= 35) && (BMI <= 39.9))
            {
                Console.WriteLine("obesity grade 2");
            }
            //else
            //{
            //    Console.WriteLine("unexpected error!");
            //}
            */

            /*
            //4_Aufgabe2
            Console.WriteLine("Hello you again");
            Console.Write("Please enter any Year, i´ll show you something!: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int result1 = year % 4;
            int result2 = year % 100;
            int result3 = year % 400;

            if ((result1 == 0) || (result2 == 0) || (result3 == 0))
            {
                Console.WriteLine("Schaltjahr");
            }

            else if ((result1 != 0) && (result2 != 0) && (result3 != 0))
            {
                Console.WriteLine("Kein Schaltjahr");
            }
            */

            /*
            //4_Aufgabe2.1
            Console.WriteLine("Hello you again");
            Console.Write("Please enter any Year, i´ll show you something!: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine(year + " ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine(year + " ist kein Schaltjahr");
            }

        }

        static bool IsLeapYear(int year)

        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            */

            /*
            //4_Aufgabe3.1
            Console.WriteLine("Rechner");
            Console.WriteLine("Give me a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give me a Operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Give me a secound Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, num1 + num2);
                    break;

                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, num1 - num2);
                    break;

                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, num1 * num2);
                    break;

                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, num1 / num2);
                    break;

                case '%':
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, num1 % num2);
                    break;

                default:
                    Console.WriteLine("Expected Error");
                    break;

            }
            */
        }
    }
}