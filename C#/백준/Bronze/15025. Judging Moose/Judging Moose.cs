using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            if(a==b){
                if(a==0){
                    Console.WriteLine("Not a moose");
                }
                else{
                    Console.WriteLine($"Even {a*2}");
                }
            }
            else{
                int c = a>b?a:b;
                Console.WriteLine($"Odd {c*2}");
            }
        }
    }
}