using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

             Student ob1 = new Student();
               ob1.Name = "fbijnsdg";
               ob1.Id = 123;
               ob1.Gender = 'm';
               ob1.PhoneNo = "21324324";
               ob1.Address = "Basundhora";
               ob1.Cgpa = 3.9;
               ob1.Department = "csse";
               ob1.CreditCompleted = 120;

               ob1.showInfo();

               Student ob2 = new Student(3.9, "csse", 120, "uihfifds", 123, 'm', "2313213","Basundhora");

               ob2.showInfo();
               


        }
    }
}
