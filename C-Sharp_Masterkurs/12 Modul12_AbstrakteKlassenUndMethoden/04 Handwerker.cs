using System;
namespace C_Sharp_Masterkurs.Modul12_AbstrakteKlassenUndMethoden
{
    public class Handwerker : Arbeiter
    {
        public Handwerker(string name, decimal gehalt) : base(name, gehalt)
        {
        }
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Handwerker " + Name + " betritt die Garage.");
            Console.WriteLine("Er arbeitet dort mit Holz");
        }
    }
}
