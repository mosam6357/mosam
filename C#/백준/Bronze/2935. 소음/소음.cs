using System;
using System.Numerics;

namespace q{
    class w{
        static void Main(){
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            if (s=="*"){
                Console.WriteLine(a*b);
            }
            else{
                Console.WriteLine(a+b);
            }
        }
    }
}