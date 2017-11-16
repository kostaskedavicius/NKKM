using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatai
{
    class Calculator
    {

        //private delegate double MyOperation(double x, double y);
       // private Dictionary<string, MyOperation> operations = new Dictionary<string, MyOperation>();
       Dictionary<string,Func<double,double,double>> operations = new Dictionary<string, Func<double, double, double>>();

        public Calculator()
        {
            operations.Add("+", AddNumbers);
            operations.Add("-", delegate (double x, double y) { return x - y; });
            operations.Add("*", (x, y) => { return x * y; });
            operations.Add("/", (x, y) => { return x / y; });
        }

        public double PerformOperation(double num1, double num2, string sign)
        {
            if (!operations.Keys.Contains(sign))
            {
                throw new ArgumentException("Operation not valid");
            }
            return operations[sign](num1, num2);

        }

        private double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public bool OperationExists(string sign)
        {
            if (operations.Keys.Contains(sign))
            {
                return true;
            }
            return false;
        }

        public void AddOperation(string sign, Func<double,double,double> body)
        {
            operations.Add(sign, body);
        }
    }
}
