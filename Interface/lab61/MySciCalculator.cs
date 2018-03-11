using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab61
{
    class MySciCalculator :MyBasicCalculator,  ISciCalcInterface
    {
        public MySciCalculator()
        
        {
        }



        public MySciCalculator(double v1, double v2): base( v1 ,v2)
        {

            
        }

        public double toThePower()
        {
            return Math.Pow(value1, value2);
        }

    }
}
