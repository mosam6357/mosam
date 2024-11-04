using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(aa[1]*(aa[2]+1));
        }
    }
}