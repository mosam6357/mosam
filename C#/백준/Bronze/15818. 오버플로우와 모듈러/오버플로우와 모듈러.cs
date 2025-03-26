using System;

namespace q{
    class w{
        static void Main(String[] args){
            long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long[] bb = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long a = aa[0]; long b = aa[1]; long n = 1;
            for (int i=0;i<a;i++){
                n*=(bb[i]%b);
                n = n%b;
            }
            Console.WriteLine(n%b);
        }
    }
}