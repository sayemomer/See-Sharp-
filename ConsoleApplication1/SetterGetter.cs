using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Account
    {
        private int accountID;
        private string accountHolderName;
        private double balance;


        public void setAccountID(int accountID)
        {
            this.accountID = accountID;
        }

        public void setAccountHolderName(string accountHolderName)
        {
            this.accountHolderName = accountHolderName;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }



        public int getAccountID()
        {

            return this.accountID;

        }


        public string getAccounHolderName()
        {

            return this.accountHolderName;

        }


        public double getBalance()
        {

            return this.balance;

        }

    }
}
