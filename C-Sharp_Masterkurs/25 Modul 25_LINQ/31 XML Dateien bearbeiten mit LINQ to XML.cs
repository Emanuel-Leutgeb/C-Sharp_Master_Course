using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class XML_Dateien_bearbeiten_mit_LINQ_to_XML
    {
        public XML_Dateien_bearbeiten_mit_LINQ_to_XML()
        {
            XDocument customers = XDocument.Load(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");

            var customersinWels = from customer in customers.Descendants("Kunde")
                                  where customer.Element("Adresse").Attribute("Ort").Value == "Wels"
                                  select customer;
            
            //Element bearbeiten
            foreach (var customer in customersinWels)
            {
                customer.SetElementValue("Vorname", "Zweiter neuer Name");
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
            

            /* 
            //Element hinzufügen
            foreach(var customer in customersinWels)
            {
                customer.SetElementValue("NeuesElement", "Hallo Welt");
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
            */

            /*
            //Element löschen
            foreach (var customer in customersinWels)
            {
                customer.SetElementValue("NeuesElement", null);
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
            */

            /* Attribute hinzufügen
            foreach (var customer in customersinWels)
            {
                customer.SetAttributeValue("Test", 10);
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
            */

            /*
            //Attribute löschen
            foreach (var customer in customersinWels)
            {
                customer.SetAttributeValue("Test", null);
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
            */

            /*
            //Kunden löschen
            foreach (var customer in customersinWels)
            {
                customer.RemoveAll();
            }

            customers.Save(@"/Users/emanuelleutgeb/Projects/C-Sharp_Masterkurs_GitHub/30_Kundenliste.xml");
auskommentieren hier            
        }
    }
}

/*
--------------------------------------------------
<Kunde>
    <KundenID>1</KundenID>
    <Vorname>Emanuel</Vorname>
    <Nachname>Leutgeb</Nachname>
    <Adresse Ort="Wels" Straße="Birkenstraße 6" />
</Kunde>
--------------------------------------------------
*/