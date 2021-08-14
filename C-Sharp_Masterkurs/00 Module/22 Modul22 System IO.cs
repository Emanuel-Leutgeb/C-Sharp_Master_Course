using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Masterkurs.Module
{
    public class Modul22
    {
        public Modul22()
        {
        }
        public void SystemIO()
        {
            //DirectoryAndDirectoryInfo();

            //FileAndFileInfo();

            Streams();

        }
        
        public void DirectoryAndDirectoryInfo()
        {
            //Verzeichnisse (Directory / DirectoryInfo)

            //Erstelle DirectoryInfo-Objekt
            string pfad1 = @"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/Modul22_TestOrdner";
            DirectoryInfo verzeichnis = new DirectoryInfo(pfad1);

            /*
            Console.WriteLine(verzeichnis.Name);
            Console.WriteLine(verzeichnis.FullName);
            Console.WriteLine(verzeichnis.Root);
            Console.WriteLine(verzeichnis.CreationTime);
            */

            /*
            //Anzeige der Verzeichnisse (Unterordner)
            DirectoryInfo[] verzeichnisse = verzeichnis.GetDirectories();

            foreach(DirectoryInfo dir in verzeichnisse)
            {
                Console.WriteLine(dir.Name);
            }
            */

            /*
            //Anzeige der Dateien (Dateien in Ordner)
            FileInfo[] datas = verzeichnis.GetFiles();

            foreach (FileInfo data in datas)
            {
                Console.WriteLine(data);
            }
            */

            string pfad2 = @"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/Modul22_TestOrdner/MeinOrdner";
            DirectoryInfo verzeichnisneu = new DirectoryInfo(pfad2);

            //verzeichnisneu.Create();
            ////(verzeichnisneu.Delete(true);)                                  //DELETE MIT VORSICHT ZU GENIEßEN
        }
        
        public void FileAndFileInfo()
        {
            string pfad3 = @"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/Modul22_TestOrdner/TestDatei.txt";
            FileInfo file1 = new FileInfo(pfad3);

            //Datei Erstellen
            //file1.Create();

            //Datei Info
            //Console.WriteLine(file1.Name);
            //Console.WriteLine(file1.FullName);
            //Console.WriteLine(file1.Directory);
            //Console.WriteLine(file1.DirectoryName);
            //Console.WriteLine(file1.Extension);

            //Console.WriteLine(file1.Exists);

            //Datei Löschen
            //file1.Delete();

            //Console.WriteLine(file1.Exists);
        }

        public void Streams()
        {
            string pfad4 = @"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/Modul22_TestOrdner/CostumerList.txt";

            /*
            StreamReader sr = new StreamReader(pfad4);

            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadToEnd());
            
            sr.Close();
            */


            StreamWriter sw1 = new StreamWriter(pfad4, true);

            sw1.WriteLine("");
            sw1.WriteLine("since 2018");
            sw1.Close();

            StreamReader sr1 = new StreamReader(pfad4);

            Console.WriteLine(sr1.ReadToEnd());

            sr1.Close();
            

            //using Statement um den Stream automatisch zu schließen
            using (StreamWriter sw2 = new StreamWriter(pfad4, true))
            {
                sw2.WriteLine("");
                sw2.WriteLine("till end 2019");
            }
            using (StreamReader sr2 = new StreamReader(pfad4))
            { 
                Console.WriteLine(sr2.ReadToEnd());
            }
            
        }
    }
}