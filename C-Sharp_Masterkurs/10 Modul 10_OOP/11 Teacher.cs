using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    public class Teacher : School
    {

        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Herr/Frau " + LastName + " unterrichtet die Klasse!");
            Console.WriteLine();
        }
    }
}
