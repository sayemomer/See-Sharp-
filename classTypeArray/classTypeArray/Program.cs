using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTypeArray
{
    class Program
    {
        static void Main(string[] args){

            Account account1 = new Account("Omer Sayem", "15b6", 1000);
                account1.showDetails();

            Account account2 = new Account("Sharifa Akhter", "16b6", 0);
                account2.showDetails();



            account1.depositCash(1000);
            double transferAmmount = account1.withdrawCash(500);
            account1.transferCash(account2, transferAmmount);


            Bank bank = new Bank("Dutch Bangla Bank", "Basundora Branch");
                bank.addAccount(account1);
                bank.addAccount(account2);
                bank.showDetails();


        }
    }
}
