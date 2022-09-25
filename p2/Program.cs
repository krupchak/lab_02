using System;

namespace p2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int k;

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Initial array: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
            Console.Write("Enter the number of times to rotate the array: ");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    Console.Write(a[n + i - k] + " ");
                }
                else
                {
                    Console.Write(a[i - k] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
