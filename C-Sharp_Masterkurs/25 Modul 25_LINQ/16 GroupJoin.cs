using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class GroupJoin
    {
        public GroupJoin()
        {
            //Customers
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(1, 1, "Emanuel Leutgeb"));
            customerList.Add(new Customer(2, 1, "Miriam Leutgeb"));
            customerList.Add(new Customer(3, 2, "Sandra Forstinger"));
            customerList.Add(new Customer(4, 3, "Rebekka Karl"));

            //Orders
            List<Order> orderList = new List<Order>();
            orderList.Add(new Order(2, 1, "PC Game"));
            orderList.Add(new Order(2, 1, "Flower"));
            orderList.Add(new Order(4, 3, "Socks"));
            orderList.Add(new Order(1, 1, "T-Shirt"));

            //Adresses
            List<Adress> adressList = new List<Adress>();
            adressList.Add(new Adress(1, "Leutgeb Street"));
            adressList.Add(new Adress(2, "Forstinger Street"));
            adressList.Add(new Adress(3, "Karl Street"));
            /*
            var ordersByAdress1 = from adress in adressList
                                 join order in orderList
                                 on adress.AdressID equals order.AdressID
                                 into adressGroup
                                 select new
                                 {
                                     Orders = adressGroup,
                                     AdressLine = adress.AdressLine
                                 };
            */
            /*
            var ordersByAdress2 = adressList.GroupJoin(orderList, adress => adress.AdressID, order => order.AdressID, (adress, adressGroup) => new { Orders = adressGroup, AdressLine = adress.AdressLine });

            foreach (var adress in ordersByAdress2)
            {
                Console.WriteLine(adress.AdressLine);
                Console.WriteLine("---------------");

                foreach(var order in adress.Orders)
                {
                    Console.WriteLine(order.ProductName);
                }
                    Console.WriteLine();
            }


        }
    }

    class Customer
    {
        //Properties
        public int CustomerID { get; set; }
        public int AdressID { get; set; }
        public string Name { get; set; }

        //Constructor
        public Customer(int customerID, int adressID, string name)
        {
            CustomerID = customerID;
            AdressID = adressID;
            Name = name;
        }
    }

    class Order
    {
        //Properties
        public int CustomerID { get; set; }
        public int AdressID { get; set; }
        public string ProductName { get; set; }

        //Constructor
        public Order(int customerID, int adressID, string productName)
        {
            CustomerID = customerID;
            AdressID = adressID;
            ProductName = productName;
        }
    }

    class Adress
    {
        //Properties
        public int AdressID { get; set; }
        public string AdressLine { get; set; }

        //Constructor
        public Adress(int adressID, string adressLine)
        {
            AdressID = adressID;
            AdressLine = adressLine;
        }
    }
}
*/