using System;

namespace CG_5_2_methodCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sandra's calculator");

            Console.Write("Please type the operation you would like to perform. (+, -, *, or /)   ");
            string operation = Console.ReadLine();

            Console.Write("Now type the first number.  ");
            string x = Console.ReadLine();

            Console.Write("Now type the second number.  ");
            string y = Console.ReadLine();

            decimal a = Convert.ToDecimal(x);
            decimal b = Convert.ToDecimal(y);

            if (operation == "+")
            {
                string message = AddResult(a, b);
                Console.WriteLine(message);
            }
            
            if (operation == "-")
            {
                string message = SubResult(a, b);
                Console.WriteLine(message);
            }

            if (operation == "*")
            {
                string message = MultResult(a, b);
                Console.WriteLine(message);
            }

            if (operation == "/")
            {
                string message = DivResult(a, b);
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// This method finds the sum of two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>This method returns the sum within a string</returns>
        public static string AddResult(decimal firstNum, decimal secondNum)
        {
            decimal addResult = firstNum + secondNum;
            string message = ($"Your answer is {addResult} ");
            return message;
        }

        /// <summary>
        /// This message finds the difference of two numbers.
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>This method returns the difference within a string</returns>
        public static string SubResult(decimal firstNum, decimal secondNum)
        {
            decimal subResult = firstNum - secondNum;
            string message = ($"Your answer is {subResult}");
            return message;
        }

        /// <summary>
        /// This method finds the product of two numbers.
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>This method returns the product within a string</returns>
        public static string  MultResult(decimal firstNum, decimal secondNum)
        {
            decimal multResult = firstNum * secondNum;
            string message = ($"Your answer is {multResult}");
            return message;
        }
        /// <summary>
        /// This method finds the quotient of two numbers.
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>This method returns the quotient within a string</returns>
        public static string DivResult(decimal firstNum, decimal secondNum)
        {
            decimal multResult = firstNum / secondNum;
            string message = ($"Your answer is {multResult}");
            return message;
        }
    }
}
