using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c;
            c = new Car();

            c.Make = "Volvo";
            c.Model = "V70";

            Console.WriteLine("Tack, nu finns din {0} {1} klar för uthyrning", c.Make, c.Model);

            Car d = new Car()
            {
                Make = "Skoda",
                Model = "Octavia"
            };

            Console.WriteLine("Tack, nu finns din {0} {1} klar för uthyrning", d.Make, d.Model);

        }
    }


    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }
    }


}
