using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {

        private string name;
        private int id;
        private char gender;
        private string phoneNo;
        private string address;
       

        public Person(){

            Console.WriteLine("Empty Constructor");
    }
        public Person(string name, int id, char gender, string phoneNo, string address)
        {

            this.name = name;
            this.id = id;
            this.gender = gender;
            this.phoneNo = phoneNo;
            this.address = address;
        }


        public string Name
        {

            set { this.name= value; }
            get { return name; }


        }


        public int Id
        {

            set { this.id = value; }
            get { return id; }
        }


        public char Gender
        {

            set { this.gender = value; }
            get { return gender; }
        }



        public string PhoneNo
        {
            set { this.phoneNo = value; }
            get { return phoneNo; }

        }



        public string Address
        {
            set { this.address = value; }
            get { return address; }

        }

        public void showInfo()
        {

            Console.WriteLine("{0},{1},{2},{3},{4}", name, id, gender, phoneNo, address);

        }



        
    }
}
