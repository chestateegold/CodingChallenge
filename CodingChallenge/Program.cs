using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number. Enter a negative number to quit");

            int input = GetInput();
            while (input >= 0)
            {
                List<int> results = Calculate(input);

                foreach (int i in results)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                input = GetInput();
            }
        }

        static List<int> Calculate(int number)
        {
            List<int> results = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    results.Add(i);
                }
            }

            return results;
        }

        static int GetInput()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }

            return x;
        }
    }
}
