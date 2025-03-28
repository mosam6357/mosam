using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1];
            while(true){
                b+=a;
                if (b>=5){
                    Console.WriteLine("yt");
                    break;
                }
                a+=b;
                if (a>=5){
                    Console.WriteLine("yj");
                    break;
                }
            }
        }
    }
}