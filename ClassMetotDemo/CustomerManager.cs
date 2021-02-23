using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added:"+customer.Ad+""+customer.Soyad);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted:"+customer.Ad+""+customer.Soyad);
        }
       public void List(List<Customer>customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id:"+customer.Id);
                Console.WriteLine("Ad:"+customer.Ad);
                Console.WriteLine("Soyad:"+customer.Soyad);
                Console.WriteLine("Telefon Numarası:"+customer.TelefonNumarası);
            }
        }
    }
}
