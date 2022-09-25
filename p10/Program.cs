using System;

namespace p10
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int k = 0;

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Initial array: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            Console.Write("Enter the difference: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                for(int j =0; j < n; j++)
                {
                    if (a[i] - a[j] == x)
                        k++;
                }
            }
            Console.WriteLine(k);
        }
    }
}
