using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public interface IKraftfahrzeug
    {
        string Producer { get; set; }
        int MaxSpeed { get; set; }

        void Drive();
        void Break();
    }
}
