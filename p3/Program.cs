using System;

namespace p3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[k*4];
            int[] b = new int[k*2];
            int[] c = new int[k*2];
            int[] sum = new int[k*2];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < k*4; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Initial array: ");
            for (int i = 0; i < k*4; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
            for(int i = 0; i < k*2; i++)
            {
                for (int j = k * 4 - k * 3; j < k * 3; j++)
                {
                    b[i] = a[j];
                    i++;
                }
            }
            Console.Write("Initial array1: ");
            for (int i = 0; i < k * 2; i++)
                Console.Write(b[i] + " ");

            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                for (int j = k * 4 - k * 3 - 1; j >=0; j--)
                {
                        c[i] = a[j];
                    i++;
                }
            }
            for (int i = k; i < k * 2; i++)
            {
                for (int j = k * 4 - 1; j >= k * 3; j--)
                {
                    c[i] = a[j];
                    i++;
                }
            }
            Console.Write("Initial array2: ");
            for (int i = 0; i < k * 2; i++)
                Console.Write(c[i] + " ");

            Console.WriteLine();
            Console.Write("Sum: ");
            for (int i = 0; i < k * 2; i++)
            {
                sum[i] = b[i] + c[i];
                Console.Write(sum[i] + " ");
            }
        }
    }
}
