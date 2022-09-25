using System;

namespace p5
{
    internal class Program
    {
        static void Main()
        {
            string[] arr1, arr2;
            arr1 = Console.ReadLine().Split(' ');
            arr2 = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < arr1.Length; i++)
            {
                int x = string.Compare(arr1[i], arr2[i]);
                if (x == -1)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    break;
                }
                else if(x == 1)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    break ;
                }
                else
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        Console.Write(arr1[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        Console.Write(arr2[j]);
                    }
                    break;
                }
            }
        }
    }
}
