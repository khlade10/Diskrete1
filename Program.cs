using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the lower and upper bounds of the range
            Console.Write("Enter the lower bound of the range: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the upper bound of the range: ");
            int n2 = int.Parse(Console.ReadLine());

            // Find and print the perfect numbers in the range
            Console.WriteLine("Perfect numbers in the range {0} to {1}:", n1, n2);
            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Returns true if the given number is a perfect number, false otherwise
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}