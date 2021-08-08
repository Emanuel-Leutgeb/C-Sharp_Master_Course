using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    public class Dog 
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }

        //Konstruktor
        public Dog(string name, int age, string race, string gender)
        {
            Name = name;
            Age = age;
            Race = race;
            Gender = gender;
        }

        //Methoden
        public void Bellen()
        {
            Console.WriteLine(Name + " bellt!");
        }
        public void Fressen()
        {
            Console.WriteLine(Name + " frisst!");
        }
    }
}
