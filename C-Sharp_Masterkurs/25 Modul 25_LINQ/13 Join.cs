using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Modul25_LINQ
{
    public class Join
    {
        public Join()
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

            var orderQuery = from order in orderList
                             join customer in customerList
                             on order.CustomerID equals customer.CustomerID
                             select new
                             {
                                 Product = order.ProductName,
                                 CustomerName = customer.Name
                             };

            foreach(var order in orderQuery)
            {
                Console.WriteLine(order.CustomerName + " bought " + order.Product);
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