using System;
using System.Numerics;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            if (a<=1){
                Console.WriteLine(a);
            }
            else{
                BigInteger n1 = 0;
                BigInteger n2 = 1;
                BigInteger ans = 0;
                for (int i=0;i<a-1;i++){
                    ans = n1+n2;
                    n1 = n2;
                    n2 = ans;
                }
                Console.WriteLine(ans);
            }
        }
    }
}