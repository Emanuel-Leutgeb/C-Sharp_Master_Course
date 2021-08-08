using System;
namespace C_Sharp_Masterkurs.Modul10_OOP
{
    public class Student : School
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void ListenToTeacher()
        {
            Console.WriteLine("Der/Die Schüler/in " +FirstName + " " + LastName + " hört dem Lehrer zu!");
            Console.WriteLine();
        }
    }
}
