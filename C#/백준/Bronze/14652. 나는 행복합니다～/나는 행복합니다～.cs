using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int[] bb = Array.ConvertAll(aa,int.Parse);
            Console.WriteLine($"{bb[2]/bb[1]} {bb[2]%bb[1]}");
        }
    }
}