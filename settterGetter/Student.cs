using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string name;
        private string id;
        private double cgpa;
        public void set_name(string n)
        {
            name = n;
        }
        public void set_id(string i)
        {
            id = i;
        }
        public void set_cgpa(double cg)
        {
            cgpa = cg                                                                                                                                                                                                                                                                     ;
        }
        public string get_name()
        {
            return name;
        }
        public string get_id()
        {
            return id;
        }
        public double get_cgpa()
        {
            return cgpa;
        }


    }
}
