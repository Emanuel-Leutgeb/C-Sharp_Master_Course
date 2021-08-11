using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul15_Collections
{
    public class Stacks
    {
        public Stacks()
        {
            //Push  = hinzufügen 
            //Pop   = nehmen & ausgeben & löschen
            //Peek  = nehmen & ausgeben & zurückgeben
            Stack<int> num = new Stack<int>();

            num.Push(1);
            num.Push(2);
            num.Push(3);
            num.Push(4);
            num.Push(5);
            num.Push(6);
            num.Push(7);
            num.Push(8);
            num.Push(9);
            num.Push(10);

            Console.WriteLine(num.Pop());
            Console.WriteLine(num.Pop());
            Console.WriteLine(num.Pop());

            Console.WriteLine(num.Peek());
            Console.WriteLine(num.Peek());
        }
    }
}
