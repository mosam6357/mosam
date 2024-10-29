using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(a[0]>a[1]?a[0]:a[1]);
        }
    }
}