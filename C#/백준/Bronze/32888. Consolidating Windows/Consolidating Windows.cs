using System;

namespace q{
    class w{
        static void Main(){
            double[] aa = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
            double a = aa[0]*aa[0]; double b = aa[1]*aa[1];
            Console.WriteLine(Math.Pow(a+b,0.5));
        }
    }
}