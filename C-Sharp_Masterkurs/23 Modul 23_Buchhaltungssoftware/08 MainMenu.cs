using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul23_Buchhaltungssoftware
{
    public class MainMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Profile: " + ProfileManager.CurrentProfile.Name);
            Console.WriteLine("Aktueller Kontostand: " + ProfileManager.CurrentProfile.Balance + "€");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("[1]   Neue Transaktion");
            Console.WriteLine("[2]   Zeige Transaktion");
            Console.WriteLine("[3]   Zurück ins Startmenü");
            Console.WriteLine();

            InputOption();
        }

        private void InputOption()
        {
            string input;
            Menu nextMenu;

            while (true)
            {
                Console.Write("Eingabe: ");
                input = Console.ReadLine();

                bool correctInput = true;

                switch (input)
                {
                    case "1":
                        nextMenu = new TransactionMenu();
                        break;

                    case "2":
                        //nextMenu = new ShowTransactionMenu();
                        break;

                    case "3":
                        nextMenu = new StartMenu();
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