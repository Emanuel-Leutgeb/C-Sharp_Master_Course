using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Anonyme_Methoden_und_Lambda_Ausdrücke
    {
        public delegate void TestDelegate(string str, int i);

        public delegate double Calculate(double x, double y);


        public Anonyme_Methoden_und_Lambda_Ausdrücke()
        {
            //Anonyme Methode ist aber ALT
            TestDelegate testDelegate1 = delegate (string s, int a)
            {
                Console.WriteLine("Hello " + s + "!");
                Console.WriteLine("You are {0} Years old", a);
            };

            testDelegate1("Emanuel", 24);


            //Lambda Expression
            TestDelegate testDelegate2 = (name, age) =>
            {
                Console.WriteLine("Hello " + name + "!");
                Console.WriteLine("You are {0} Years old", age);
            };

            testDelegate2("Miriam", 20);



            Calculate calc = (num1, num2) => num1 + num2;

            double result = calc(10, 2);
            Console.WriteLine(result);
        }
    }
}
