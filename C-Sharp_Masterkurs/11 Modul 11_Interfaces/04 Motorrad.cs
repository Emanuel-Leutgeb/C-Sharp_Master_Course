using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public class Motorrad : IKraftfahrzeug
    {
        public string Producer { get; set; }
        public int MaxSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("Das Motorrad fährt");
        }

        public void Break()
        {
            Console.WriteLine("Das Motorrad bremst");
        }
    }
}
