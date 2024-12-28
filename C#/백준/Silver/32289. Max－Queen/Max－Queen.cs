using System;

namespace q{
    class w{
        static void Main(){
            long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long a = aa[0]; long b = aa[1];
            long s1 = b-1; long s2 = (a-1)*2; long s3 = (a-1)*3; long s4 = (a-1)*(b-2)*4;
            Console.WriteLine(s1+s2+s3+s4);
        }
    }
}