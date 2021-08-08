using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul11_Interfaces
{
    public interface ITier
    {
        string Gender { get; set; }
        int Age { get; set; }

        void Fressen();
        void Trinken();
    }
}
