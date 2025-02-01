using System;

namespace q{
    class w{
        static void Main(){
           long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
           Console.WriteLine(aa[0]*(aa[1]+1));
        }
    }
}