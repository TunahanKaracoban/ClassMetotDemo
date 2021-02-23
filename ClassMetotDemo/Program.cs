using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Ad = "Tunahan";
            customer1.Soyad = "Karaçoban";
            customer1.TelefonNumarası = "05356543210";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Ad = "Mustafa";
            customer2.Soyad = "Çelik";
            customer2.TelefonNumarası = "05457893645";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Ad = "Ayşe";
            customer3.Soyad = "Yılmaz";
            customer3.TelefonNumarası = "05443694127";

            List<Customer> customers = new List<Customer>() { customer1, customer2, customer3 };
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.List(customers);
        }
    }
}
