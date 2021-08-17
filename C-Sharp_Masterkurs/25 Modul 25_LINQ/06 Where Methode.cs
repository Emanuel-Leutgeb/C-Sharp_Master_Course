using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Where_Methode
    {
        public Where_Methode()
        {
            
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Emanuel", "Leutgeb", Courses.Engineering, 24));
            studentList.Add(new Student("Miriam", "Leutgeb", Courses.IT, 20));
            studentList.Add(new Student("Herbert", "Mascherbauer", Courses.Maths, 26));
            studentList.Add(new Student("Michael", "Huber", Courses.Biology, 28));
            studentList.Add(new Student("Sandra", "Huemer", Courses.Art, 44));
            studentList.Add(new Student("Mario", "Forstinger", Courses.Construction, 54));
            studentList.Add(new Student("Manuel", "Mühlböck", Courses.Physic, 23));
            studentList.Add(new Student("Johanna", "Aigenberger", Courses.Dance, 21));

            var engineeringStudents = from student in studentList
                                      where student.Course == Courses.Engineering && student.Age < 25
                                      select student;

            var artStudents = studentList.Where((student) => student.Course == Courses.Art && student.Age > 20);

            foreach(Student student in artStudents)
            {
                Console.WriteLine(student.ToString());
            }

        }
    }

    public enum Courses
    {
        Art,
        Biology,
        Maths,
        Engineering,
        Physic,
        Dance,
        Construction,
        IT
    }
    public class Student
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Courses Course { get; set; }
        public int Age { get; set; }

        //Constructor
        public Student(string firstName, string lastName, Courses course, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Age = age;
        }

        //Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) - {Course}";

        }
    }
}
*/