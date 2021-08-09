using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class Program_Interfaces
    {
        public Program_Interfaces()
        {
        }
        public void Modul11()
        {
            /*
            Auto auto = new Auto();
            auto.Producer = "SuperCars";
            auto.MaxSpeed = 300;

            EAuto eauto = new EAuto();
            eauto.Producer = "ECars";
            eauto.MaxSpeed = 340;

            Motorrad motorrad = new Motorrad();
            motorrad.Producer = "BMW";
            motorrad.MaxSpeed = 380;

            IKraftfahrzeug[] fahrzeuge = new IKraftfahrzeug[3];
            fahrzeuge[0] = auto;
            fahrzeuge[1] = eauto;
            fahrzeuge[2] = motorrad;

            foreach(IKraftfahrzeug fahrzeug in fahrzeuge)
            {
                Console.WriteLine(fahrzeug.Producer);
                Console.WriteLine(fahrzeug.MaxSpeed);
                fahrzeug.Drive();
                fahrzeug.Break();
                Console.WriteLine();
            }
            */

            /*
            //Aufgabe1
            Hund hund = new Hund();
            hund.Gender = "Male";
            hund.Age = 10;

            Katze katze = new Katze();
            katze.Gender = "Female";
            katze.Age = 13;

            Maus maus = new Maus();
            maus.Gender = "Female";
            maus.Age = 3;

            ITier[] tier = new ITier[3];
            tier[0] = hund;
            tier[1] = katze;
            tier[2] = maus;

            foreach(ITier tiere in tier)
            {
                Console.WriteLine(tiere.Gender);
                Console.WriteLine(tiere.Age);
                tiere.Fressen();
                tiere.Trinken();
                Console.WriteLine();
            }
            */

            ///*
            //Aufgabe2
            Person person = new Person();
            person.Name = "Gustaf";
            Console.WriteLine(person.Name);

        }    
    }
}
