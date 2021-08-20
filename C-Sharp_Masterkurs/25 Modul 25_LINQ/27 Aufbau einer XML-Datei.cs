using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Aufbau_einer_XML_Datei
    {
        public Aufbau_einer_XML_Datei()
        {
            /*
             * <?xml version="1.0" encoding="utf-8" ?>                          //<ABC> = Öffnungs Tag <>  
             *                                                                  //</ABC> = Schließungs Tag /
             * <!--Kundenliste-->                                               //<!--ABC--> Kommentare <!---->
             * <Kunden>                                                         //Öffnung des Wurzelstocks
             *  <Kunde>                                                         //Öffnung des Element 1
             *      <KundenID>1</KundenID>
             *      <Vorname>Emanuel</Vorname>                                  
             *      <Nachname>Leutgeb</Nachname>
             *      <Adresse Ort="Wels" Straße="Birkenstraße 6" />
             *  </Kunde>                                                        //Schließen des Element 2
             *  
             *  <Kunde>                                                         //Öffnung des Element 2
             *      <KundenID>2</KundenID>
             *      <Vorname>Miriam</Vorname>
             *      <Nachname>Forstinger</Nachname>
             *      <Adresse Ort="Bad Wimsbach-Neydharting" Straße="Kößlwang 6"/> //Ort und Straße sind Attribute //Kein Schließungs Tag nötig da kein einzelner Wert steht.
             *  </Kunde>                                                        //Schließen des Element 2
             * </Kunden>                                                        //Schließung des Wurzelstocks
         
            */
        }
    }
}
