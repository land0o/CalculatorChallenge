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
            Console.ReadLine();

            //handle user input
            int UserSelection = int.Parse(Console.ReadLine());
            int MathSelection = UserSelection;
            int a = 0;
            int b = 0;
            Console.Write("Please enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            b = int.Parse(Console.ReadLine());
            int addResults = Calculate.AddNumbers(a, b);
            Console.WriteLine($"the results of adding {a} + {b} are {addResults}");

            if (MathSelection == 0)
            {



            }
            else if (MathSelection == 1)
            {

            }
            else if (MathSelection == 2)
            {

            }
            else if (MathSelection == 3)
            {

            }
            else if (MathSelection == 4)
            {

            }

        }
    }
}
