using System;

namespace p1
{
    internal class Program
    {
        static int LCE(string X, string Y, int m, int n)
    {
        int[,] array = new int[m + 1, n + 1];
        int result = 0;

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    array[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                {
                    array[i, j]
                        = array[i - 1, j - 1] + 1;

                    result
                        = Math.Max(result, array[i, j]);
                }
                else
                    array[i, j] = 0;
            }
        }

        return result;
    }


    public static void Main()
    {
        String X = Console.ReadLine();
        String Y = Console.ReadLine();

        int m = X.Length;
        int n = Y.Length;

        Console.Write(LCE(X, Y, m, n));
    }
    }
}
