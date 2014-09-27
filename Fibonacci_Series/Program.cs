using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks args for path to input file, otherwise ask user
            string[] lines;
            if (args.Length > 0)
            {
                lines = System.IO.File.ReadAllLines(args[0]);
            }
            else
            {
                Console.WriteLine("Please enter the path to your input file:");
                string input_file = Console.ReadLine();
                lines = System.IO.File.ReadAllLines(@input_file);
            }
            foreach (var line in lines)
            {
                // Ignore white space and negative numbers
                if (line == "" || Convert.ToInt32(line) < 0)
                {
                    continue;
                }
                int number = Convert.ToInt32(line);
                Console.WriteLine(Fibonacci(ref number));
            }
        }

        // Calculates the nth Fibonacci number using Binet's Fibonacci number formula
        static public int Fibonacci(ref int n)
        {
            double sqrt_of_5 = Math.Sqrt(5);
            double numerator = Math.Pow((1 + sqrt_of_5), n) - Math.Pow((1 - sqrt_of_5), n);
            double denominator = Math.Pow(2, n) * sqrt_of_5;
            double Fibonacci_number = numerator / denominator;
            return (int)Fibonacci_number;
        }
    }
}
