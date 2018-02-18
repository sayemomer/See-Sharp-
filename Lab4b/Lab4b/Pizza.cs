using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4b
{
    class Pizza : FoodItem
    {

         
        private string size;


        public Pizza()
        {

            Console.WriteLine("Empty Constructor");
        }
        public Pizza(string size)
        {

            this.size = size;

        }


        public string Size
        {

            set { this.size = value; }
            get { return size; }


        }



    }
}
