using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Masterkurs.Modul23_Buchhaltungssoftware
{
    public class LoadProfileMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Wähle ein Profil aus:");
            Console.WriteLine("---------------------");
            ShowProfiles();
            Console.WriteLine();
            string profilePath = InputProfileName();

            if (profilePath != "cancle")
            {
                ProfileManager.LoadProfile(profilePath);
                Menu nextMenu = new MainMenu();
            }
            else
            {
                Menu nextMenu = new StartMenu();
            }


        }

        private void ShowProfiles()
        {
            string[] profileFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.prof");

            foreach(string file in profileFiles)
            {
                Console.WriteLine("- " + Path.GetFileName(file));
            }
        }

        private string InputProfileName()
        {
            string input = "";

            while(true)
            {
                Console.Write("Zu ladendes Profil [\"cancle\" zum abbrechen]: ");
                input = Console.ReadLine();
                string[] profileFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.prof");
                bool correctInput = false;

                if (input == "cancle")
                {
                    correctInput = true;
                }
                else
                {
                    for (int i = 0; i < profileFiles.Length; i++)
                    {
                        profileFiles[i] = Path.GetFileName(profileFiles[i]);

                        if(input == profileFiles[i])
                        {
                            correctInput = true;
                            input = AppContext.BaseDirectory + input;
                            break;
                        }
                    }
                }

                if (correctInput)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fehler: Ungültiges Profil");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            return input;
        }
    }
}
