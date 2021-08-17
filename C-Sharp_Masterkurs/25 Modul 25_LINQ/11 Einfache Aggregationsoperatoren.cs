using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Einfache_Aggregationsoperatoren
    {
        public Einfache_Aggregationsoperatoren()
        {
            int[] numbers = { 10, 20, 30, 40, 5, 50, 32, 10, 340, 44 };


            var result1 = numbers.Min();
            var result2 = numbers.Average();
            Console.WriteLine(result2);

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Emanuel", "Leutgeb", "Engineering", 24));
            studentList.Add(new Student("Miriam", "Leutgeb", "IT", 20));
            studentList.Add(new Student("Herbert", "Mascherbauer", "Engineering", 26));
            studentList.Add(new Student("Michael", "Huber", "IT", 28));
            studentList.Add(new Student("Sandra", "Huemer", "Art", 44));
            studentList.Add(new Student("Mario", "Forstinger", "Art", 54));
            studentList.Add(new Student("Manuel", "Mühlböck", "Engineering", 23));
            studentList.Add(new Student("Johanna", "Aigenberger", "IT", 21));

            var result3 = studentList.Max((student) => student.Age);
            Console.WriteLine(result3);

            var result = studentList.Average((student) => student.Age);
            Console.WriteLine(result);
        }
    }


    public class Student
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }

        //Constructor
        public Student(string firstName, string lastName, string job, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Job = job;
            Age = age;
        }

        //Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) - {Job}";

        }
    }
}