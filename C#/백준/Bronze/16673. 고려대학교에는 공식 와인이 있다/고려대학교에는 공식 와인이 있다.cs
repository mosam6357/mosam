using System;

namespace q{
    class w{
        static void Main(){
            String[] a = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(a,int.Parse);
            int q = aa[0]; int w = aa[1]; int e = aa[2];
            Console.WriteLine((q*(q+1))/2*w+(q*(q+1)*(2*q+1))/6*e);
        }
    }
}