using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

        Console.WriteLine($"{a[0]} + {a[1]} = {a.Sum()}");
    }
}