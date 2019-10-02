using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyCustomers = new ArrayList();

            Customer c = new Customer() { FirstName = "Kalle", LastName = "Anka" };
            MyCustomers.Add(c);

            MyCustomers.Add(new Customer() { FirstName = "Arne", LastName = "Anka" });
            MyCustomers.Add(new Customer() { FirstName = "Musse", LastName = "Pigg" });

            Console.WriteLine("Du har {0} kunder", MyCustomers.Count);

            foreach (Customer anka in MyCustomers)
            {
                Console.WriteLine("{0} {1}", anka.FirstName, anka.LastName);
            }

            Console.ReadLine();
        }
    }
}
