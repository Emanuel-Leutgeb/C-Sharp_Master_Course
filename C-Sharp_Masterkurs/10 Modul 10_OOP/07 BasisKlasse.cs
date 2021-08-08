using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    class BasisKlasse
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public BasisKlasse(string name, int age)
        {
            Name = name;
            Age = age;
            
            Console.WriteLine("Basis Klassen Konstruktor wird ausgeführt...");
        }
    }
    class ErbendeKlasse : BasisKlasse
    {
        public ErbendeKlasse(string name, int age) : base(name, age)
        {
            Console.WriteLine("Erbende Klasse Konstruktor wir ausgeführt...");
            Console.WriteLine(name + age);
        }
    }
}
