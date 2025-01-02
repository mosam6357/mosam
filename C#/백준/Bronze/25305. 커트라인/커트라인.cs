using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Array.Sort(aa);
            Array.Reverse(aa);
            Console.WriteLine(aa[a[1]-1]);
        }
    }
}