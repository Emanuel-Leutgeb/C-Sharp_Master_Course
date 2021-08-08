using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul07
    {
        public Modul07 ()
        {
        }
        public void Schleifen()
        {
            /*
            //While Schleife
            int zahl = 0;

            while(zahl < 5)
            {
                zahl ++;
                Console.WriteLine(zahl);
            }
            */

            /*
            //Do While Schleifen
            int zahl = 0;

            do
            {
                zahl++;
                Console.WriteLine(zahl);
            }
            while (zahl < 5);
            */

            /*
            //While
            Console.WriteLine("Give me Integer 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me Integer 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            while (num1 <= num2)
            {
                Console.WriteLine(num1);
                num1 ++;
     
            }
            */

            /*
            //Do While
            string password = "HelloWorld";
            string input = "";
            do
            {
                Console.WriteLine("Give me the Password: ");
                input = Console.ReadLine();
            }
            while (password != input);

            Console.WriteLine("Du hast das Passwort erraten!");
            */

            /*
            //For Schleifen
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //for if
            string[] names = new string[]
            {
                "Emanuel",
                "Miriam",
                "Gott",
                "Jesus",
                "Renate",
                "Sandra",
                "Mario"
            };

            for (int i = 3; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                if (names[i] == "Sandra")
                {
                    break;
                }
            }
            */

            /*
            //for for
            string[,] prod = new string[,]
            {
                {
                    "Apfel",
                    "Smartphone",
                    "Schokoladentafel"
                },
                {
                    "Lebensmittel",
                    "Elektronik",
                    "Lebensmittel"
                }
            };

            for(int zeile = 0; zeile < prod.GetLength(1); zeile++)
            {
                for (int spalte = 0; spalte < prod.GetLength(0); spalte++)
                {
                    Console.Write(prod[spalte, zeile]);

                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            */

            /*
            //foreach
            string[] names = new string[]
            {
                "Emanuel",
                "Miriam",
                "Gott",
                "Jesus",
                "Renate",
                "Sandra",
                "Mario"
            };

            foreach(string name in names)
            {
                Console.WriteLine(name);

            }
            */

            /*
            //break

            int zahl = 1;

            while(zahl <= 10)
            {
                Console.WriteLine(zahl);

                if (zahl == 5)
                {
                    break;
                }

                zahl++;
            }
            */

            /*
            //continue

            int zahl = 0;

            while (zahl < 10)
            {
                zahl++;

                if (zahl == 5)
                //{
                    continue;
                //}
                Console.WriteLine(zahl);
            }
            */

            /*
             * Aufgabe1.1
            int zahl = 0;

            while (zahl < 10)
            {
                zahl++;

                if (zahl == 1)
                {
                    continue;
                }
                if (zahl == 3)
                {
                    continue;
                }
                if (zahl == 5)
                {
                    continue;
                }
                if (zahl == 7)
                {
                    continue;
                }
                if (zahl == 9)
                {
                    continue;
                }

                Console.WriteLine(zahl);
            }
            */

            /*
             * Aufgabe 1.1
            double sum = 0;

            while (sum != 1000)
            {
                string input1;
                do
                {
                    Console.Write("Give me the first Number: ");
                    input1 = Console.ReadLine();
                }
                while (input1 == "");

                double num1 = Convert.ToDouble(input1);


                Console.Write("Give me an Operator: ");
                string op = Convert.ToString(Console.ReadLine());


                string input2;
                do
                {
                    Console.Write("Give me the secound Number: ");
                    input2 = Console.ReadLine();
                }
                while (input2 == "");

                double num2 = Convert.ToDouble(input1);


                sum = num1 + num2;


                switch (op)
                {
                    case "+":
                        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + num1 + num2);
                        break;

                    case "-":
                        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + (num1 - num2));
                        break;

                    case "*":
                        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + num1 * num2);
                        break;

                    case "/":

                        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + num1 / num2);
                        break;

                    case "%":
                        Console.WriteLine(num1 + " " + op + " " + num2 + " = " + num1 % num2);
                        break;

                    default:
                        Console.WriteLine("No Valid Operator");
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
            */

            /*
            //Aufgabe2
            Console.Write("Give me a Number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(i + " * " + x + " " + " = " + (i * x));
            }
            */

            /*
            //Aufgabe3
            string[,] rec = new string[,]
            {
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10"
                },
                {
                    "2",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10"
                },
                {
                    "3",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10"
                },
                {
                    "4",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10"
                
                },
                {
                    "5",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10"
                }
            };
            
            for (int zeile = 0; zeile < rec.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < rec.GetLength(1); spalte++)
                {
                    Console.Write(rec[zeile, spalte]); //zeile zuerst ausgeben dannach die spalte sonst fehler
                }

                Console.WriteLine();
            }
            */

            /*
            Aufgabe4
            while (true)
            {
                int num1 = 1;

                int num2 = 2;

                
                    
                        Console.WriteLine(num1 + " * " + num2 + " = " + num1 * num2);
                      

                   

                Console.ReadKey();
                Console.Clear();
            }

            for (int spalte = 0; spalte <= 10; spalte++)
            {
                for (int zeile = 0; zeile <= 10; zeile++)
                {
                    Console.WriteLine(x[spalte, zeile]);
                }
            }
            */

            /*
            //Aufgabe5.1
            for (int num1 = 1; num1 <= 10; num1++)
            {
                for (int num2 = 1; num2 <= 10; num2++)
                {
                    Console.Write(num2 + " * " + num1 + " = " + num2 * num1 + "     |");    //Console.Write("{0}*{1}={2}  |", num2, num1, num2 * num2);             
                }
               Console.WriteLine();
            }
            */

            /*
            //Aufgabe5.2
            for (int num1 = 1; num1 <= 10; num1++)
            {
                for (int num2 = 1; num2 <= 10; num2++)
                {
                    Console.Write(num2 + " * " + num1 + " = " + num2 * num1);


                    int spaces = (num2 * 20) - Console.CursorLeft;

                    for (int s = 0; s < spaces; s++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */

            /*
            //Aufgabe6 FAIL
            string HW = "Hello World";
            char d = 'd';
            int i;
            for (int i; i < d; i++)

                i = Convert.ToChar(HW);

            switch(HW)
            {
                case "H":
                    Console.WriteLine("H");
                    break;

                case "e":
                    Console.WriteLine("e");
                    break;

                case "l":
                    Console.WriteLine("l");
                    break;

                case "o":
                    Console.WriteLine("o");
                    break;

                case " ":
                    Console.WriteLine(" ");
                    break;

                case "W":
                    Console.WriteLine("W");
                    break;

                case "r":
                    Console.WriteLine("r");
                    break;

                case "d":
                    Console.WriteLine("d");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
                    
            }
            //*/

            /*
            //Aufgabe6.2 Live
            string HW = "Hello World";

            for (int i = 0; i < HW.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(HW);
                }
                else
                {
                    Console.WriteLine(HW[i]);
                }
            }
            */

            /*
            //Aufgabe7
            Console.Write("Give me a Word: ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine(text + " ist ein Palindrom!");
            }
            else
            {
                Console.WriteLine(text + " ist kein Palindrom!");
            }

        }
        static bool IsPalindrome(string text)
        {
            string reversed = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed.ToLower() == text.ToLower();
        } // geschweifte Klammer auskommentieren unten!
            */

            ///*
            //Aufgabe8
            Console.Write("Gebe einen Text ein: ");
            string text = Console.ReadLine();
            string newText = "";

            foreach(char c in text)
            {
                if (char.IsLetter(c))
                {
                    newText += c;
                }
            }

            Console.WriteLine("Der neue Text: " + newText);
            //*/
        }
    }
}