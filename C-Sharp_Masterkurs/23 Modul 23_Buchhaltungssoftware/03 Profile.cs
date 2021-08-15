using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Masterkurs.Modul23_Buchhaltungssoftware
{
    [Serializable]

    public class Profile
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Profile(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            Transactions = new List<Transaction>();
        }
    }
}