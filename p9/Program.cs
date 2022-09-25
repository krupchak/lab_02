using System;

namespace p9
{
    internal class Program
    {
        static void Main()
        {
            string[] arr;
            arr = Console.ReadLine().Split(' ');
            Console.WriteLine();

            for(int i = 0; i < 25; i++)
            {
                switch(arr[i])
                {
                    case "a": Console.WriteLine($"{arr[i]} -> 0");break;
                    case "b": Console.WriteLine($"{arr[i]} -> 1"); break;
                    case "c": Console.WriteLine($"{arr[i]} -> 2"); break;
                    case "d": Console.WriteLine($"{arr[i]} -> 3"); break;
                    case "e": Console.WriteLine($"{arr[i]} -> 4"); break;
                    case "f": Console.WriteLine($"{arr[i]} -> 5"); break;
                    case "g": Console.WriteLine($"{arr[i]} -> 6"); break;
                    case "h": Console.WriteLine($"{arr[i]} -> 7"); break;
                    case "i": Console.WriteLine($"{arr[i]} -> 8"); break;
                    case "j": Console.WriteLine($"{arr[i]} -> 9"); break;
                    case "k": Console.WriteLine($"{arr[i]} -> 10"); break;
                    case "l": Console.WriteLine($"{arr[i]} -> 11"); break;
                    case "m": Console.WriteLine($"{arr[i]} -> 12"); break;
                    case "n": Console.WriteLine($"{arr[i]} -> 13"); break;
                    case "o": Console.WriteLine($"{arr[i]} -> 14"); break;
                    case "p": Console.WriteLine($"{arr[i]} -> 15"); break;
                    case "q": Console.WriteLine($"{arr[i]} -> 16"); break;
                    case "r": Console.WriteLine($"{arr[i]} -> 17"); break;
                    case "s": Console.WriteLine($"{arr[i]} -> 18"); break;
                    case "t": Console.WriteLine($"{arr[i]} -> 19"); break;
                    case "u": Console.WriteLine($"{arr[i]} -> 20"); break;
                    case "v": Console.WriteLine($"{arr[i]} -> 21"); break;
                    case "w": Console.WriteLine($"{arr[i]} -> 22"); break;
                    case "x": Console.WriteLine($"{arr[i]} -> 23"); break;
                    case "y": Console.WriteLine($"{arr[i]} -> 24"); break;
                    case "z": Console.WriteLine($"{arr[i]} -> 25"); break;
                        default:Console.WriteLine("-");break;
                }
            }
        }
    }
}
