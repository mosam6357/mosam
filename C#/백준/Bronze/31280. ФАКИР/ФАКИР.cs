using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(a.Sum()-a.Min()+1);
        }
    }
}