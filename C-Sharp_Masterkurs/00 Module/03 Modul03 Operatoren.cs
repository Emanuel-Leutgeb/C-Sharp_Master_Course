using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul03
    {
        public Modul03()
        {
        }
        public void Operatoren()
        {
            /*
            //1_Grundrechenarten + - * /
            int zahl1 = 0;
            zahl1 -= 1;
            zahl1++;

            Console.WriteLine(zahl1);

            //2_Modulo Operator (Restwert Operator)
            //int zahl = 6 / 4  // 1 REST : 2

            int zahl = 6 % 4;
            int zahl2 = 10 % 7;

            Console.WriteLine(zahl2);
            */

            /*
            //3_Aufgabe1
            Console.WriteLine("Hallo!");
            Console.Write("Bitte gib eine Zahl von 1 bis 100 ein: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib erneut eine Zahl zwischen 1 und 100 ein: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result1 = num1 + num2;
            int result2 = num1 - num2;
            int result3 = num1 * num2;
            int result4 = num1 / num2;
            int result5 = num1 % num2;

            Console.WriteLine("Addieren " + num1 + " + " + num2 + " = " + result1);
            Console.WriteLine("Subtrahieren " + num1 + " - " + num2 + " = " + result2);
            Console.WriteLine("Multiplizieren " + num1 + " * " + num2 + " = " + result3);
            Console.WriteLine("Dividieren " + num1 + " / " + num2 + " = " + result4);
            Console.WriteLine("Restwert " + num1 + " % " + num2 + " = " + result5);
            */

            /*
            //4_Aufgabe1.1
            Console.WriteLine("Hallo!");
            Console.Write("Bitte gib eine Zahl von 1 bis 100 ein: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte gib erneut eine Zahl zwischen 1 und 100 ein: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 % num2);
            */
        }
    }
}