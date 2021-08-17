using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class OfType_Methode
    {
        public OfType_Methode()
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog("Coco"));
            animalList.Add(new Dog("Tibi"));
            animalList.Add(new Dog("Kathie"));
            animalList.Add(new Cat("Pussy"));
            animalList.Add(new Cat("Timi"));
            animalList.Add(new Cat("Roxy"));
            animalList.Add(new Lion());
            animalList.Add(new Lion());
            animalList.Add(new Lion());

            var dogQuvery = from animal in animalList.OfType<Dog>()
                            select animal;

            var catQuvery = animalList.OfType<Cat>();

            foreach(Dog dog in dogQuvery)
            {
                dog.Eat();
            }

            foreach (Cat cat in catQuvery)
            {
                cat.Drink();
            }
        }
    }

    public abstract class Animal
    {
        //Methods
        public abstract void Eat();
        public abstract void Drink();
    }

    public class Dog : Animal
    {
        //Properties
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }
        public override void Drink()
        {
            Console.WriteLine($"The Dog {Name} is eating");
        }

        public override void Eat()
        {
            Console.WriteLine($"The Dog {Name} is drinking");
        }
    }

    public class Cat : Animal
    {
        //Properties
        public string Name { get; set; }

        //Constructor
        public Cat(string name)
        {
            Name = name;
        }

        //Methods
        public override void Drink()
        {
            Console.WriteLine($"The Cat {Name} is eating");
        }

        public override void Eat()
        {
            Console.WriteLine($"The Cat {Name} is drinking");
        }
    }

    public class Lion : Animal
    {
        //Methods
        public override void Drink()
        {
            Console.WriteLine($"The Lion is eating");
        }

        public override void Eat()
        {
            Console.WriteLine($"The Lion is drinking");
        }
    }
}
