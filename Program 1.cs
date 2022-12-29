using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read n1 and n2 from the user
            Console.WriteLine("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());

            // Print the prime numbers from n1 to n2
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int n)
        {
            // Check if n is less than 2
            if (n < 2)
            {
                return false;
            }

            // Check if n is a multiple of 2
            if (n % 2 == 0)
            {
                return n == 2;
            }

            // Check if n is divisible by any odd number between 3 and the square root of n
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}