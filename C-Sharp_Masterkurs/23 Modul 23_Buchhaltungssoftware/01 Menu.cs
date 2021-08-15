using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul23_Buchhaltungssoftware
{
    public abstract class Menu
    {
        public Menu()
        {
            Console.Clear();
            DisplayMenu();
        }

        public abstract void DisplayMenu();   
    }
}
