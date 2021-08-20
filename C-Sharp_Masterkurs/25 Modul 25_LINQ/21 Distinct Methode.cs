using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Distinct_Methode
    {
        public Distinct_Methode()
        {
            /*
            string[] names =
            {
                "Alina",
                "Emanuel",
                "Miriam",
                "Alina",
            };

            int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3 };

            var distinctNames = names.Distinct();

            var distinctNumbers = numbers.Distinct();


            foreach (string name in distinctNames)
            {
                Console.WriteLine(name);
            }


            foreach(int number in distinctNumbers)
            {
                Console.WriteLine(number);
            }
            */
            //------------------------------------------------------------------
            /*
            //Customers
            List<Customer> customerList = new List<Customer>();

            customerList.Add(new Customer(1, "Emanuel Leutgeb"));
            customerList.Add(new Customer(1, "Emanuel Leutgeb"));
            customerList.Add(new Customer(2, "Sandra Forstinger"));
            customerList.Add(new Customer(3, "Rebekka Karl"));

            var distinctCustomers = customerList.Distinct(new CustomerComparer());

            foreach(Customer customer in distinctCustomers)
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