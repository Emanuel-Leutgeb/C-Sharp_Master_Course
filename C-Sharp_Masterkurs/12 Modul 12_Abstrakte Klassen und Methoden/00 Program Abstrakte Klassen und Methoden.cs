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
    
}
