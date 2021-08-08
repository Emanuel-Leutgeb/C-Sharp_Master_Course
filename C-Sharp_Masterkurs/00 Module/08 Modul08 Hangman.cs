using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul08
    {
        public Modul08()
        {
        }

        public void Hangman()
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {

                Console.WriteLine("### HANGMAN ###");
                Console.WriteLine("###############");
                Console.WriteLine();

                Console.WriteLine("Wähle eine Aktion aus:");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[1] Spielen");
                Console.WriteLine("[2] Beenden");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Aktion: ");
                int action = 0;
                try
                {
                    action = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                }
                

                bool end = false;

                switch (action)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        end = true;
                        break;
                }

                if (end)
                {
                    break;
                }

                Console.Clear();
            }
            
        }

        static void StartGame()
        {
            string[] words = new string[]
            {
                "Apfelkuchen",
                "Gemüsesuppe",
                "Kraftfahrzeug",
                "Penis",
                "Videospiel",
                "Emanuel",
                "Alarmanlage",
                "ProgrammierenStarten",
                "Vollkornbrot",
                "Miriam",
                "Peter,",
                "Julia,",
                "David",
                "Agilox",
                "AMS",
                "SEX",
                "Hallo"
            };

            Random rnd = new Random();
            int index = rnd.Next(0, words.Length);
            string word = words[index].ToLower();
            GameLoop(word);
           
        }

        static void GameLoop(string word)
        {
            int lives = 10;
            string hiddenWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += "_";
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gesuchtes Wort: " + hiddenWord);
                Console.Write("Noch übrige Versuche: ");

                for (int i = 0; i < lives; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("X");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.Write("Buchstabe: ");
                char character = ' ';
                try
                {
                    character = Convert.ToChar(Console.ReadLine().ToLower());
                }
                catch (Exception)
                {
                }

                bool foundCharacterInWord = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == character)
                    {
                        foundCharacterInWord = true;
                        break;
                    }
                }
                string tempHiddenWord = hiddenWord;
                hiddenWord = "";

                if (foundCharacterInWord)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == character)
                        {
                            hiddenWord += character;
                        }
                        else if (tempHiddenWord[i] != '_')
                        {
                            hiddenWord += tempHiddenWord[i];
                        }
                        else
                        {
                            hiddenWord += '_';
                        }
                    }

                    if (hiddenWord == word)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("GEWONNEN!!!");
                        Console.WriteLine("Das Wort war: " + word);
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    }
                }
                else
                {
                    hiddenWord = tempHiddenWord;

                    if (lives > 0)
                    {
                        lives -= 1;
                    }
                    else
                    {
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("                   !!!GAME OVER!!!   ");
                        Console.WriteLine("                     ___________     ");
                        Console.WriteLine("                    | /         |    ");
                        Console.WriteLine("                    |/          |    ");
                        Console.WriteLine("                    |         (°_°)  <-- That`s YOU!");
                        Console.WriteLine("                    |          _|_/  ");
                        Console.WriteLine("                   /|         / |    ");
                        Console.WriteLine("                  / |          _|_   ");
                        Console.WriteLine("                 /  |          | |   ");
                        Console.WriteLine("                /___|____            ");
                        Console.WriteLine("               |         |           ");
                        Console.WriteLine("               |_________|           ");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}