using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class calc
    {
        public static double Plus(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static double Minus(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        public static double Multiplication(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
        public static double Division(double FirstNumber, double SecondNumber)
        {
            if (SecondNumber == 0) return 0;
            return FirstNumber / SecondNumber;
        }
    }
}
