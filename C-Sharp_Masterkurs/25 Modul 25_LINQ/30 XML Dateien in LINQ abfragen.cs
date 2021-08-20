using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class XML_Dateien_in_LINQ_abfragen
    {
        public XML_Dateien_in_LINQ_abfragen()
        {
            XDocument customers = XDocument.Load(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");

            /*
            foreach (var element in customers.Descendants("Kunde"))
            {
                Console.WriteLine(element.Name);  
            }
            */

            /*
            var vornameQuery = from customer in customers.Descendants("Kunde")
                               select customer.Element("Vorname").Value;

            foreach (string name in vornameQuery)
            {
                Console.WriteLine(name);
            }
            */

            /*
            var customersinWels = from customer in customers.Descendants("Kunde")
                                  where customer.Element("Adresse").Attribute("Ort").Value == "Wels"
                                  select customer;

            Console.WriteLine("Alle Kunden aus Wels");

            foreach (var customer in customersinWels)
            {
                Console.WriteLine(customer.Element("Vorname").Value + " " + customer.Element("Nachname").Value);
            }
            */
        }
    }
}
