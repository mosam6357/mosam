using System;
using System.Numerics;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(a*b);
        }
    }
}