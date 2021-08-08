using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class EAuto : IKraftfahrzeug
    {
        public string Producer { get; set; }
        public int MaxSpeed { get; set; }
        public string Elektromotor { get; set; }

        public void Drive()
        {
            Console.WriteLine("Das E-Auto fährt");
        }

        public void Break()
        {
            Console.WriteLine("Das E-Auto bremst");
        }
    }
}
