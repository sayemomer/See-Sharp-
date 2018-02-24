using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTypeArray
{
    class Account
    {
        internal string accountHolderName ;
        internal string accountId ;
        internal double balance;

        public Account()
        {
            Console.WriteLine("Empty constructor\n -------------------------------");

        }

        public Account(string accountHolderName, string accountId, double balance)
        {
            Console.WriteLine("Peramiterised constructor \n -------------------------------");

            this.accountHolderName = accountHolderName;
            this.accountId = accountId;
            this.balance = balance;
        }


        public string AccountHolderName
        {
            set { this.accountHolderName = value; }
            get { return accountHolderName; }
        }


          public string AccountId
        {
            set { this.AccountId = value; }
            get { return accountId; }
        }


          public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }



        public void depositCash(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Amount Deposited ! :) \n ------------------------------- ");
            Console.WriteLine("Account Holder :{0}", accountHolderName);
            Console.WriteLine("Updated Amount :{0}\n", this.balance);
            
        }
        


        public double withdrawCash(double amount)
         {
           
             this.balance = this.balance - amount;
             Console.WriteLine("Amount withdrawed ! :) \n ------------------------------- ");
             Console.WriteLine("Account Holder :{0}", accountHolderName);
             Console.WriteLine("Updated Amount :{0}\n", this.balance);
             return amount;
             
         }



        public void transferCash(Account a, double amount)
         {
             a.balance += amount;
             Console.WriteLine("Amount transfered ! :) \n ------------------------------- ");
             Console.WriteLine("Account Holder :{0}", a.accountHolderName);
             Console.WriteLine("Updated Amount :{0}\n", a.balance);

         }



        public void showDetails()
        {
            Console.WriteLine("Account Holder :{0}\nAccountId :{1}\nBalace:{2}\n", accountHolderName, accountId, balance); 
        }


    }
}
