using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Einfache_Aggregationsoperatoren
    {
        public Einfache_Aggregationsoperatoren()
        {
            int[] numbers = { 10, 20, 30, 40, 5, 50, 32, 10, 340, 44 };


            
            var result1 = numbers.Average();
            var result2 = numbers.Min();
            var result3 = numbers.Max();
            var result4 = numbers.Sum();
            var result5 = numbers.Count();
 
            Console.WriteLine($"{result1} {result2} {result3} {result4} {result5}");

            //------------------------------------------------------------------

            List<Person> personList = new List<Person>();
            personList.Add(new Person("Emanuel", "Leutgeb", 24, "Programmer"));
            personList.Add(new Person("Miriam", "Leutgeb", 20, "Programmer"));
            personList.Add(new Person("Herbert", "Mascherbauer", 26, "Production"));
            personList.Add(new Person("Michael", "Huber", 28, "Office"));
            personList.Add(new Person("Sandra", "Huemer", 44, "Farmer"));
            personList.Add(new Person("Mario", "Forstinger", 54, "Farmer"));
            personList.Add(new Person("Manuel", "Mühlböck", 23, "Production"));
            personList.Add(new Person("Johanna", "Aigenberger", 21, "Office"));

            var res1 = personList.Average((person) => person.Age);
            var res2 = personList.Min((person) => person.Age);
            var res3 = personList.Max((person) => person.Age);
            var res4 = personList.Sum((person) => person.Age);
            var res5 = personList.Count();
            var res6 = personList.Where(person => person.Job == "Programmer").Count();


            Console.WriteLine($"{res1} {res2} {res3} {res4} {res5} {res6}");
        }
    }


    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        //Constructor
        public Person(string firstName, string lastName, int age, string job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
        }

        //Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) - {Job}";

        }
    }
}
*/