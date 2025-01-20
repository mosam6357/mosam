using System;

namespace q{
    class w{
        static void Main(){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1]; int c = aa[2];
                if(a==0 && b==0 && c==0)
                    break;
                else if(a==0)
                    Console.WriteLine($"{c/b} {b} {c}");
                else if(b==0)
                    Console.WriteLine($"{a} {c/a} {c}");
                else
                    Console.WriteLine($"{a} {b} {a*b}");
            }
        }
    }
}