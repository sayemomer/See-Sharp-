using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab61
{
    abstract class MyBasicCalculator : IBasicCalcInterface
    {
        protected double value1 ;
        protected  double value2;
        protected  double result;

        public MyBasicCalculator()
        {
        }


        public MyBasicCalculator(double v1, double v2)
        {
            this.value1 = v1;
            this.value2 = v2;
        }


        public double add()
        {
            return value1 + value2;
        }
        public double subtract()
        {
            return value1 - value2;
        }
        public double multiply()
        {
            return value1 * value2;

        }
        public double divide()
        {
            return value1 / value2;
        }

    }
}
