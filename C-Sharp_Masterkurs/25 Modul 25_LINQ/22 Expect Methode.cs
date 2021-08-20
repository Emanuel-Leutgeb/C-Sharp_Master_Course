using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Expect_Methode
    {
        public Expect_Methode()
        {
            string[] names1 =
            {
                "Emanuel",
                "Miriam",
                "Hendrik",
                "Peter"
            };

            string[] names2 =
            {
                "Miriam",
                "Sandra",
                "Alina",
                "Nadine"
            };

            var names3 = names1.Except(names2);

            foreach(string name in names3)
            {
                Console.WriteLine(name);
            }
        }
    }
}
*/

/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Expect_Methode
    {
        public Expect_Methode()
        {
            //Customers
            List<Customer> customerList1 = new List<Customer>();

            customerList1.Add(new Customer(1, "Miriam Forstinger"));
            customerList1.Add(new Customer(2, "Emanuel Leutgeb"));
            customerList1.Add(new Customer(3, "Sandra Forstinger"));

            List<Customer> customerList2 = new List<Customer>();

            customerList2.Add(new Customer(2, "Emanuel Leutgeb"));
            customerList2.Add(new Customer(4, "Herbert Mascherbauer"));
            customerList2.Add(new Customer(5, "Mario Forstinger"));


            var customerList3 = customerList1.Except(customerList2, new CustomerComparer());

            foreach (Customer customer in customerList3)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }

    public class Customer
    {
        //Properties
        public int CustomerID { get; set; }
        public string Name { get; set; }

        //Constructor
        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
        }
    }

    public class CustomerComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            if (x.CustomerID == y.CustomerID &&
                x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Customer obj)
        {
            return obj.CustomerID.GetHashCode();
        }
    }
}
*/