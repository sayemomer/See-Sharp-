using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_30172_2_MT_A1
{
    class Flight
    {
        private int id;
        private string name;
        private int capacity;
        private Employee pilot;
        private Airport from;
        private Airport to;
        private Schedule departure;
        private Schedule arrival;

        public int Id
        {

            get;
            set;

        }


        public string Name
        {

            get;
            set;

        }


        public int Capacity
        {

            get;
            set;

        }


        public Employee Pilot
        {

            get;
            set;

        }


        public Airport From
        {

            get;
            set;

        }


        public Airport To
        {

            get;
            set;

        }

        

        public Schedule Depurture
        {

            get;
            set;

        }


        public Schedule Arrival
        {

            get;
            set;

        }



    }
}
