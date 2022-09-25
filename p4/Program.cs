using System;

namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Sieve of Eratosthenes: ");
            for (int i = 1; i < n; i++)
            {
                int k = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % 2 == 0 || (i % 3 == 0 && i / 3 != 1) || (i % 5 == 0 && i / 5 != 1) || (i % 7 == 0 && i / 7 != 1))
                    {
                        k++;
                    }
                }

                if (k == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
