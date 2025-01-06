using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s1 = aa[0]*6+aa[1]*3+aa[2]*2+aa[3]*1+aa[4]*2;
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s2 = bb[0]*6+bb[1]*3+bb[2]*2+bb[3]*1+bb[4]*2;
            Console.WriteLine($"{s1} {s2}");
        }
    }
}