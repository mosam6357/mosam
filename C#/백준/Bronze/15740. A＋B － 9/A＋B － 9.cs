using System;
using System.Numerics;


namespace q{
    class w{
        static void Main(){
            String[] aa = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(aa[0]);
            BigInteger b = BigInteger.Parse(aa[1]);
            Console.WriteLine(a+b);
        }
    }
}