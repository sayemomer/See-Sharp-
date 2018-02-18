using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4b
{
    class Burger : FoodItem
    {

        private int numberOfPatties;


        public Burger()
        {

            Console.WriteLine("Empty Constructor");
        }
        public Burger(int numberOfPatties)
        {

            this.numberOfPatties = numberOfPatties;

        }


        public int NumberOfPatties
        {

            set { this.numberOfPatties = value; }
            get { return numberOfPatties; }


        }


       
    }
}
