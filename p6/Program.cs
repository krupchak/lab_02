using System;

namespace p6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];  

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Initial array: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            int start = 1, last = 1, array = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    start++;
                }
                else
                {
                    start = 1;
                }

                if (start > last)
                {
                    last = start;
                    array = a[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Max Sequence of Equal Elements:");
            for (int i = 0; i < last; i++)
            {
                Console.Write(array + " ");
            }
        }
    }
}
