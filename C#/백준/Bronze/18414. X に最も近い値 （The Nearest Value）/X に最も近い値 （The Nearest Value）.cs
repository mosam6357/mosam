using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(aa.Sum()-aa.Max()-aa.Min());
        }
    }
}