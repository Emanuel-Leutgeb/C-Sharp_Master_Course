using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class OrderBy_und_ThenBy
    {
        public OrderBy_und_ThenBy()
        {
            List<Person> studentList = new List<Person>();
            studentList.Add(new Person("Emanuel", "Leutgeb", 24));
            studentList.Add(new Person("Miriam", "Leutgeb", 20));
            studentList.Add(new Person("Herbert", "Mascherbauer", 26));
            studentList.Add(new Person("Michael", "Huber", 28));
            studentList.Add(new Person("Sandra", "Huemer", 44));
            studentList.Add(new Person("Mario", "Forstinger", 54));
            studentList.Add(new Person("Manuel", "Mühlböck", 23));
            studentList.Add(new Person("Johanna", "Aigenberger", 21));

            var personQuery = from person in studentList
                              orderby person.LastName descending, person.FirstName ascending
                              select person;

            var personQuery1 = studentList.OrderByDescending((person) => person.FirstName).ThenByDescending((person) => person.LastName);

            var personQuery2 = from person in studentList
                              orderby person.Age descending
                              select person;


            foreach (Person person in personQuery2)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
*/