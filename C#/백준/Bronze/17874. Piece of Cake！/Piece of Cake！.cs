using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            a[1] = a[1]>a[0]-a[1]?a[1]:a[0]-a[1];
            a[2] = a[2]>a[0]-a[2]?a[2]:a[0]-a[2];
            Console.WriteLine(a[1]*a[2]*4);
        }
    }
}