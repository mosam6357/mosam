using System;
using System.Numerics;

namespace q{
    class w{
        static void Main(){
            BigInteger q = BigInteger.Parse(Console.ReadLine());
            if(q>=6){
                Console.WriteLine("Love is open door");
            }
            else{
                int w = int.Parse(Console.ReadLine());
                if(w==0){
                    for (int i=0; i<q-1; i++){
                        Console.WriteLine(1-i%2);
                    }
                }
                else{
                    for (int i =0; i<q-1; i++){
                        Console.WriteLine(i%2);
                    }
                }
            }
        }
    }
}