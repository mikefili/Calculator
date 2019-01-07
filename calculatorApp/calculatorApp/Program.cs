using System;

namespace calculatorApp
{
    class Program
    {
        // declare global variables
        private static decimal answer;
        private static decimal num1;
        private static decimal num2;
        private static string operation;

        // Main method
        public static void Main(string[] args)
        {
            // request first number from user & convert to decimal
            Console.WriteLine("Pick a number: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // request second number from user & convert to decimal
            Console.WriteLine("Pick another number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // request operand from user
            Console.WriteLine("+, -, /, or *?: ");
            operation = Console.ReadLine();

            // switch statement utilizing different operands by case
            switch (operation)
            {
                case "+":
                    Add();
                    break;

                case "-":
                    Subtract();
                    break;

                case "*":
                    Multiply();
                    break;

                case "/":
                    Divide();
                    break;

                default:
                    answer = 0;
                    break;
            }

            // print result to console
            Console.WriteLine("Result: " + answer.ToString());
            // press any key to close console app
            Console.ReadLine();
        }

        // addition method
        public static void Add()
        {
            answer = num1 + num2;
        }

        // subtraction method
        public static void Subtract()
        {
            answer = num1 - num2;
        }

        // multiplication method
        public static void Multiply()
        {
            answer = num1 * num2;
        }

        // division method
        public static void Divide()
        {
            answer = num1 / num2;
        }
    }
}
