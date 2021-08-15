using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul23_Buchhaltungssoftware
{
    public class StartMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Willkommen zu Buchhaltungs-Software!");
            Console.WriteLine();
            Console.WriteLine("       Was möchtest du tun?         ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("   [1]   Profil erstellen           ");
            Console.WriteLine("   [2]   Profil laden               ");
            Console.WriteLine();

            InputOption();
        }

        private void InputOption()
        {
            string input;
            Menu nextMenu;

            while(true)
            {
                Console.Write("Eingabe: ");
                input = Console.ReadLine();

                bool correctInput = true;

                switch (input)
                {
                    case "1":
                        nextMenu = new CreateProfileMenu();
                        break;

                    case "2":
                        nextMenu = new LoadProfileMenu();
                        break;

                    default:
                        correctInput = false;

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ungültige Eingabe!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                if (correctInput)
                    break;
            }
        }
    }
}
