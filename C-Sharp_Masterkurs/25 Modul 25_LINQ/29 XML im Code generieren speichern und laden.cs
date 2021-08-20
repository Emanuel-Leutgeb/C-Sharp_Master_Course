using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;                                                          //using Klasse hinzufügen beim Erstellen von XML Dateien

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class XML_im_Code_generieren_speichern_und_laden
    {
        public XML_im_Code_generieren_speichern_und_laden()
        {
            /*
            //Generieren und Speichern einer XML Datei
            XDocument customers = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "yes"),
                                        new XElement("Kunden",
                                            new XElement("KundenID", 1),
                                            new XElement("Vorname", "Emanuel"),
                                            new XElement("Nachname", "Leutgeb"),
                                            new XElement("Adresse", new XAttribute("Ort", "Wels"), new XAttribute("Straße", "Birkenstraße 6"))));

            customers.Save("customers.xml");
            Console.WriteLine(customers.ToString());
            */

            //Laden einer XML Datei
            XDocument customers = XDocument.Load("customers.xml");
            Console.WriteLine(customers.ToString());
        }
    }
}
