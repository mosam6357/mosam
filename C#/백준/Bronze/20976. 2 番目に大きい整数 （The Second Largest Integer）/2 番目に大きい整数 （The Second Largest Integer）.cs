using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int min = aa.Sum()-aa.Max()-aa.Min();
            Console.WriteLine(min);
        }
    }
}