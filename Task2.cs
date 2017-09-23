using System;
using System.Collections.Generic;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input the natural n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                List<int> a = new List<int>();
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0) a.Add(i); // add to list all divisor
                Console.WriteLine("Divisor of " + n + ":");
                for (int i = 0; i < a.Count; i++)
                    Console.Write(a[i] + " ");
            }
            catch
            {
                Console.WriteLine("\nOoops! Sth is wrong or you input incorrect data");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
