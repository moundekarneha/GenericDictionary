using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            Dictionary<string, String> d2 = new Dictionary<string, string>();
            Dictionary<string, Object> d3 = new Dictionary<string, Object>();
            d3.Add("a", 1);
            d3.Add("b", "Neha");
            d3.Add("c", 1452635241);


            foreach (var item in d3.Keys)
            {
                Console.WriteLine("Keys = "+item+" Value = " + d3[item]);
            }

            //customer
            
            List<Customer> l1 = new List<Customer>();
            Customer c1 = new Customer { Id = 101, Name= "Neha", Address = "Nagpur" };
            Customer c2 = new Customer { Id = 101, Name= "Pranita", Address = "Nagpur" };
            Customer c3 = new Customer { Id = 101, Name= "Payal", Address = "Nagpur" };
            Customer c4 = new Customer { Id = 101, Name = "Pranita", Address = "Nagpur" };
            Customer c5 = new Customer { Id = 101, Name = "Payal", Address = "Nagpur" };

            l1.Add(c1);
            l1.Add(c2);
            l1.Add(c3);

            foreach (var item in l1)
            {
                Console.WriteLine("Id = " + item.Id+ " Name = "+item.Name+ " Add ="+item.Address);
            }

            Console.ReadLine();
        }
    }
}
