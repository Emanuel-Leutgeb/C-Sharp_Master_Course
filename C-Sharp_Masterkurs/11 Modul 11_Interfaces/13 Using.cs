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
            Mechatroniker dominik = new Mechatroniker("Dominik", 2500);
            dominik.PrintInformation();
            dominik.ArbeitVerrichten();
        }
    }
/*
}

//---

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenundMethoden
{
*/
    abstract class Arbeiter
    {
        public string Name { get; set; }
        public decimal Gehalt { get; set; }

        public Arbeiter(string name, decimal gehalt)
        {
            Name = name;
            Gehalt = gehalt;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gehalt: " + Gehalt);
        }

        public abstract void ArbeitVerrichten();
    }
/*
}

//---

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenundMethoden
{
*/
    class Mechatroniker : Arbeiter
    {
        public Mechatroniker(string name, decimal gehalt) : base(name, gehalt)
        {
        }
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Mechatroniker " + Name + " betritt die Werkstatt.");
            Console.WriteLine("Er arbeitet dort mit Autos");
        }
    }
}

//---