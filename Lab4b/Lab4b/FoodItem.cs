using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4b
{
    class FoodItem
    {
        private double price;
        private string name;


        public FoodItem()
        {

            Console.WriteLine("Empty Constructor");
        }
        public FoodItem(double price, string name)
        {

            this.price = price;
            this.name = name;

        }


        public double Price
        {

            set { this.price = value; }
            get { return price; }


        }


        public string Name
        {

            set { this.name = value; }
            get { return name; }
        }

        public string getDetails()
        {


            string result = Price + Name;

            return result;
        }


    }

     
}
