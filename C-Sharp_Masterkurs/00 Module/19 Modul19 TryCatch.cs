using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul19
    {
        public Modul19()
        {
        }
        public void TryCatch()
        {
            while (true)
            {
                int alter = 0;
                try
                {
                    //Gebe dein Alter ein
                    Console.Write("Gebe dein Alter ein: ");
                    alter = Convert.ToInt32(Console.ReadLine());
                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Du musst eine gültige Zahl eingeben!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Du musst ein normales Alter eingeben!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                //finally
                //{
                    // dieser beefehl wird immer ausgefüht auch wenn return beim letzten catch steht.
                //}
            
            
                if (alter >= 18)
                {
                    Console.WriteLine("Du bist volljährig");
                }
                else
                {
                    Console.WriteLine("Du bist minderjährig");
                }
            }
        }
    }
}