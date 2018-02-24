using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTypeArray
{
    class Bank
    {
       private string bankName ;
       private string address ;
       private Account[] account=new Account[5];

       public Bank()
       {
           Console.WriteLine("Empty Constructor \n -------------------------------");
          
       }
       public Bank( string bankName , string address )
       {
           
           Console.WriteLine("Peramiterised Constructor \n -------------------------------");
           this.bankName = bankName;
           this.address = address;

       }

       public string BankName
       {
           set { this.bankName = value; }
           get { return bankName; }
       }


       public string Address
       {
           set { this.address = value; }
           get { return address ; }
       }



       public void addAccount(Account a)
       {

           for (int i = 0; i < account.Length; i++)
           {
               if (account[i] == null)
               {
                   account[i] = a;
                   break;  
               }
             
           }

       }



       public void deleteAccount(Account a)
       {

          

       }

       public void showDetails()
       {
           Console.WriteLine("Bank name :{0}\nAddress :{1}\n", bankName, address);

           Console.WriteLine("---------- Bank Account holders ----------");
          

           for (int i = 0; i< account.Length; i++)
           {
               if (account[i] != null)
               {

                   Console.WriteLine("Account Holder :{0}\nAccountId :{1}\nBalace:{2}\n", account[i].accountHolderName, account[i].accountId, account[i].balance);
               }
          }
           
       }

    }
}
