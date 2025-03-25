using System;

namespace q{
    class w{
        static void Main(String[] args){
            long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
            long k = aa[0]; long n = aa[1];
            if (n==1){
                Console.WriteLine(-1);
            }
            else{
                long x = (n*k)/(n-1);
                if ((x-k)*n>=x){
                    Console.WriteLine(x);
                }
                else{
                    Console.WriteLine(x+1);
                }
            }
        }
    }
}