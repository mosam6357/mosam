using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine($"{aa[1]+1} {aa[0]*aa[1]+1}");
        }
    }
}