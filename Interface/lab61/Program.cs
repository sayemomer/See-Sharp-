using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab61
{
    class Program
    {
        static void Main(string[] args)
        {
            MySciCalculator sci1 = new MySciCalculator(10, 2);

            Console.WriteLine(sci1.toThePower());
            Console.WriteLine(sci1.add() );
            Console.WriteLine(sci1.subtract() );
            Console.WriteLine(sci1.multiply() );
            Console.WriteLine(sci1.divide() );

            MySciCalculator sci2 = new MySciCalculator(10, 5);

            Console.WriteLine(sci2.toThePower());
            Console.WriteLine(sci2.add());
            Console.WriteLine(sci2.subtract());
            Console.WriteLine(sci2.multiply());
            Console.WriteLine(sci2.divide());


        }
    }
}
