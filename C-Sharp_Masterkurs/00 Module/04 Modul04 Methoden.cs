using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul04
    {
        public Modul04()
        {
        }
        public void Methoden()
        {
            /*
            //1_Methode OHNE Rückgabewert
            SayHello("Emanuel", 24);
            SayHello("Miriam", 20);

        }
        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hello {0}, you are {1} Year old!", name, age);


            //2_Methode MIT Rückgabewert
            int num = Addition(10, 5);
            Console.WriteLine(num);
            Console.WriteLine(Addition(10, 5));
        }
        static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
            */

            /*
            //3_Aufgabe1 FAIL
            GetTextInput(string Emanuel, string Leutgeb);
            Console.WriteLine("Hello {0} {1}.", firstname, lastname);


        }
            static string GetTextInput(string firstname, string lastname);
            Console.Write("What´s your firstname: ");
                string firstname = Console.ReadLine();
            Console.Write("What`s your lastname: ");
                string lastname = Console.ReadLine();
            */

            /*
            //3_Aufgabe1.1 FAIL 

            string firstName = GetTextInput("Gebe deinen Vornamen ein: ");
            string lastName = GetTextInput("Gebe deinen Nachnamen ein: ");
            Console.WriteLine("Hallo {0} {1}!", firstName, lastName);
                
        }
            static string GetTextInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();

            double radius = GetCircleArea("Get radius here: ");
            double PI = Math.PI;
            double surface = PI * radius * radius;

            Console.WriteLine("The surface of the circle is {0}cm and has {1}cm²", radius, surface);

        }
        static double GetCircleArea(double getradius)
        {
            Console.Write(getradius);
            return Convert.ToDouble(Console.ReadLine());
            */

            /*
            //3_Aufgabe1.2 mit Miriam
            string output = "Get radius here: ";
            double radius = GetCircleArea(output);
            double PI = Math.PI;
            double surface = PI * radius * radius;

            Console.WriteLine("The surface of the circle is {0}cm and has {1}cm²", radius, surface);
        
        static double GetCircleArea(string getradius)
        {
            Console.Write(getradius);
            return Convert.ToDouble(Console.ReadLine());
        }
            */

            /*
            // 3_Aufgabe1.3 Live
            Console.Write("Gebe einen Radius ein ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = GetCircleArea(radius);

            Console.WriteLine("Die Fläche des Kreises mit dem Radius {0}cm beträgt {1}cm²!", radius, area);
                
            static double GetCircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }
            */
        }
    }
}