using System;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            // take the FirstNumber and SecondNumber from the user
            Console.WriteLine("Please Enter the FirstNumber: ");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the SecondNumber: ");

            int n2 = int.Parse(Console.ReadLine());

            // Find and print the perfect numbers from FirstNumber SecondNumber
            Console.WriteLine("Perfect numbers from " + n1 + " to " + n2 + ": ");

            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Returns true if the given number is a perfect number, false otherwise
        static bool IsPerfectNumber(int n)
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
        
    
    
