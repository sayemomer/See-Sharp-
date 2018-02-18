using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4b
{
    class Program
    {
        static void Main(string[] args)
        {

            Burger ob1 = new Burger();
            ob1.Price = 100;
            ob1.Name = "cheese Burger";
            ob1.NumberOfPatties = 2;

              Console.WriteLine(ob1.getDetails() );

              Pizza ob2 = new Pizza();
              ob2.Price = 100;
              ob2.Name = "cheese pizza ";
              ob2.Size = "big";

              Console.WriteLine(ob2.getDetails());


        }
    }
}
