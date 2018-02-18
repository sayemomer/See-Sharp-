using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student : Person
    {

        private double cgpa;
        private string department;
        private int creditCompleted;
       

        public Student(){

            Console.WriteLine("Empty Constructor");
    }
        public Student(double cgpa,string department,int creditCompleted,string name,int id, char gender,string phoneNo,string address):base(name,id,gender,phoneNo,address)
        {

            this.cgpa = cgpa;
            this.department = department;
            this.creditCompleted = creditCompleted;
          
        }


        public double Cgpa
        {

            set { this.cgpa= value; }
            get { return cgpa; }


        }


        public string Department
        {

            set { this.department = value; }
            get { return department; }
        }


        public int CreditCompleted
        {

            set { this.creditCompleted = value; }
            get { return creditCompleted; }
        }



       

        public void showInfo()
        {

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", Name, Id, Gender, PhoneNo, Address);
            Console.WriteLine("{0}\n{1}\n{2}\n\n",cgpa,department,creditCompleted);
          



        }



    }
}
