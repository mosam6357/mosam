using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(a[2]-a[0]);
        }
    }
}