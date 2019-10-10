using System;

namespace CalculatorChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // display user menu
            Console.WriteLine("**Welcome to Calculatron 3000!**");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Select a number from the options below...");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
            Console.Write("> ");

            //handle user input
            int MathSelection;
            //do while
            do
            {
                Console.WriteLine("Make Choice");
                int userChoice = int.Parse(Console.ReadLine());
                MathSelection = userChoice;
                Calculate Calculate = new Calculate();
                if (MathSelection == 1)
                {
                    Console.Write("Please enter the first number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number:");
                    int b = int.Parse(Console.ReadLine());

                    int addResults = Calculate.AddNumbers(a, b);
                    Console.WriteLine($"the results of adding {a} + {b} is {addResults}");

                }
                if (MathSelection == 2)
                {
                    Console.Write("Please enter the first number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number:");
                    int b = int.Parse(Console.ReadLine());

                    int SubtractResults = Calculate.SubtractNumbers(a, b);
                    Console.WriteLine($"the results of Subtracting {a} - {b} is {SubtractResults}");
                }
                if (MathSelection == 3)
                {
                    Console.Write("Please enter the first number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number:");
                    int b = int.Parse(Console.ReadLine());

                    int MultiplyResults = Calculate.MultiplyNumbers(a, b);
                    Console.WriteLine($"the results of Multiplying {a} X {b} is {MultiplyResults}");
                }
                if (MathSelection == 4)
                {
                    Console.Write("Please enter the first number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number:");
                    int b = int.Parse(Console.ReadLine());

                    int DivideResults = Calculate.DivideNumbers(a, b);
                    Console.WriteLine($"the results of Dividing {a} / {b} is {DivideResults}");
                }
            }
            while (MathSelection != 0);

        }
    }
}
