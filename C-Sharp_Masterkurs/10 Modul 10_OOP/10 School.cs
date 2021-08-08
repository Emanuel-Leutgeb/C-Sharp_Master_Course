using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul10_OOP
{
    public class School
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public School(string firstName, string lastName, int age )
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintSchool()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
            Console.WriteLine("Alter: " + Age);
        }
    }
}
