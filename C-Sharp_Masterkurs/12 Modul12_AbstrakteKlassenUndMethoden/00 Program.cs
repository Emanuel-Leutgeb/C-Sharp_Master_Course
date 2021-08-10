using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenUndMethoden
{
    class Program_AbstrakteKlassenUndMethoden
    {

        public Program_AbstrakteKlassenUndMethoden()
        {

        }
        public void Modul12()
        {
            /*
                                                                                // Abstrakte Klassen
            Mechatroniker dominik = new Mechatroniker("Dominik", 2500);
            dominik.PrintInformation();
            dominik.ArbeitVerrichten();

            Console.WriteLine();

            Handwerker emanuel = new Handwerker("Emanuel", 3000);
            emanuel.PrintInformation();
            emanuel.ArbeitVerrichten();

            Console.WriteLine();

            //oder

            Arbeiter[] arbeiter = new Arbeiter[2];
            arbeiter[0] = dominik;
            arbeiter[1] = emanuel;
         
            foreach (Arbeiter arbeiterList in arbeiter)
            {
                //Console.WriteLine(arbeiterList.Name);
                //Console.WriteLine(arbeiterList.Gehalt);
                arbeiterList.PrintInformation();
                arbeiterList.ArbeitVerrichten();

                Console.WriteLine();
            }
            */

            
            Mechatroniker jens = new Mechatroniker("Jens", 2000);
            Console.WriteLine(jens.ToString());                                 //repräsentiert von welchen Typ die Instanz
            jens.ArbeitVerrichten();
            jens.ArbeitMachen();
            

            
            //Aufgabe1
            Rectangle rectangle = new Rectangle(10, 3);
            Circle circle = new Circle(30);
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(circle.GetArea());
            Console.WriteLine();
            //Aufgabe2 
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(circle.ToString());
            
        }
    }
}