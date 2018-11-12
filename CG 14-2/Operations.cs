using System;
using System.Collections.Generic;
using System.Text;

namespace CalcAssign14_1
{
    class Operators
    {
        /// <summary>
        /// Multiplies 2 numbers
        /// </summary>
        /// <param name="num1">first number to be multiplied</param>
        /// <param name="num2">second number to be multiplied</param>
        /// <returns>num1 multiplied by num2</returns>
        public static double Multiply(double num1, double num2)
        {
            return (num1 * num2);

        }
        /// <summary>
        /// Divides 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is divided by num2</returns>
        public static double Divide(double num1, double num2)
        {
            return (num1 / num2);

        }
        /// <summary>
        /// Adds 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is added to num2</returns>
        public static double Addition(double num1, double num2)
        {
            return (num1 + num2);

        }
        /// <summary>
        /// Subtracts num2 from num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num2 is subtracted from num1</returns>
        public static double Minus(double num1, double num2)
        {
            return (num1 - num2);

        }
    }
}