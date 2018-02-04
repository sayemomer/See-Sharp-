using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Account obj = new Account();

            obj.setAccountID(123);
            obj.setAccountHolderName("omer sayem");
            obj.setBalance(500);


            Console.WriteLine( obj.getAccountID() );
            Console.WriteLine( obj.getAccounHolderName() );
            Console.WriteLine( obj.getBalance() );


        }
    }
}
