using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class CalculationEngine
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Divide(double number1, double number2)
        {
            double answer = number1 / number2;

            if (double.IsPositiveInfinity(answer))
            {
                //throw new Exception("Division med noll, inte ok");
                throw new DivideByZeroException();
            }

            return answer;
        }

    }
}
