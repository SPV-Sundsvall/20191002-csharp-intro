using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //detta är en kommentar
            int x = 5; 
            int y;

            y = x;
            x = 10; 

            Console.WriteLine("x={0} y={1}", x, y);

            Customer c = new Customer();
            c.Name = "Kalle";

            Customer d;
            d = c;
            d.Name = "Arne";

            Console.WriteLine("c.Name={0} d.Name={1}", c.Name, d.Name);
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }
}
