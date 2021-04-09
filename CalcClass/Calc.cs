using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    class Calc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public string selectedSymbol { get; set; }

        public double Add (double num1, double num2)
        {
            return num1 + num2;
        }

        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public string[] loadSymbols()
        {
            string[] ComboBoxItems = new[] { "Choose an Operation", "+", "-", "*", "/" };
            return ComboBoxItems;
        }

        public double selectedOperation()
        {
            double result = 0;

            switch (selectedSymbol)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}
