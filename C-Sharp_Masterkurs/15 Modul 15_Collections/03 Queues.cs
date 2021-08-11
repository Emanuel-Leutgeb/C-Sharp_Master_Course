using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul15_Collections
{
    public class Queues
    {
        public Queues()
        {
            //Enqueue   = hinzufügen
            //Dequeue   = löschen des 1. Wertes in der Warteschlange
            //Peek      = lesen des 1. Wertes in der Warteschlange

            Queue<string> personQueue = new Queue<string>();

            personQueue.Enqueue("Emanuel");
            personQueue.Enqueue("Miriam");
            personQueue.Enqueue("Herbert");
            personQueue.Enqueue("Manuel");

            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());

            Console.WriteLine(personQueue.Peek());
            Console.WriteLine(personQueue.Peek());
        }
    }
}
