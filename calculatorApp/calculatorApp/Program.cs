using System;

namespace calculatorApp
{
    class Program
    {
        private static int answer;
        private static int num1;
        private static int num2;
        private static string operation;

        public static void Main(string[] args)
        {
            Console.Write("Pick a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("+, -, /, or *?: ");
            operation = Console.ReadLine();

            Console.Write("Pick another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Result: " + answer.ToString());
            Console.ReadLine();
        }

        public static void Add()
        {
            answer = num1 + num2;
        }

        public static void Subtract()
        {
            answer = num1 - num2;
        }

        public static void Multiply()
        {
            answer = num1 * num2;
        }

        public static void Divide()
        {
            answer = num1 / num2;
        }
    }
}
