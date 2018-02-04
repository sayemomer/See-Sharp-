using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.set_name("durjoy");
            s.set_id("16");
            s.set_cgpa(4.00);
            Console.WriteLine(s.get_name());
            Console.WriteLine(s.get_id());
            Console.WriteLine(s.get_cgpa());
        }
    }
}
