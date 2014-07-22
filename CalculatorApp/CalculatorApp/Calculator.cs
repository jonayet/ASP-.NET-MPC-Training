using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        private double firstNumber;
        private double secondNumber;
        private double result;

        public string Add(string num1, string num2)
        {
            try
            {
                firstNumber = Convert.ToDouble(num1);
            }
            catch
            {
                return "First Number is invalid";

            }

            try
            {
                secondNumber = Convert.ToDouble(num2);
            }
            catch
            {
                return "Second Number is invalid";

            }
            result = firstNumber + secondNumber;
            return result.ToString();

        }
        //for substract
        public string sub(string num1, string num2)
        {
            try
            {
                firstNumber = Convert.ToDouble(num1);
            }
            catch
            {
                return "First Number is invalid";

            }

            try
            {
                secondNumber = Convert.ToDouble(num2);
            }
            catch
            {
                return "Second Number is invalid";

            }
            result = firstNumber - secondNumber;
            return result.ToString();

        }
        //Multiply
        public string multi(string num1, string num2)
        {
            try
            {
                firstNumber = Convert.ToDouble(num1);
            }
            catch
            {
                return "First Number is invalid";

            }

            try
            {
                secondNumber = Convert.ToDouble(num2);
            }
            catch
            {
                return "Second Number is invalid";

            }
            result = firstNumber * secondNumber;
            return result.ToString();

        }
        //divison
        public string div(string num1, string num2)
        {
            try
            {
                firstNumber = Convert.ToDouble(num1);
            }
            catch
            {
                return "First Number is invalid";

            }

            try
            {
                secondNumber = Convert.ToDouble(num2);
            }
            catch
            {
                return "Second Number is invalid";

            }

            if (secondNumber == 0) return "second number cannot be Zero";


            result = firstNumber / secondNumber;
            return result.ToString();

        }
    }
}
