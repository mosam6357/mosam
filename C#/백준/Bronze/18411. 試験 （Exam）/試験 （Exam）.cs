using System;

namespace q{
    class w{
        static void Main(){
            string[] aaa = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(aaa,int.Parse);
            Console.WriteLine(aa.Sum()-aa.Min());
        }
    }
}