using System;
using MultiPurposeDLL;

namespace HappyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's happy (lan's twist):"); // Dấu ấn cá nhân
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                HappyNumberChecker checker = new HappyNumberChecker();
                checker.Number = number;
                string result = checker.Check();
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadKey();
        }
    }
}