using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1]; int c = aa[2]; int d = aa[3];
                if(a==b && b==c && c==d && d==0){
                    break;
                }
                int t = c*60+d-(a*60+b);
                t = t<0?t+1440:t;
                Console.WriteLine(t);
            }
        }
    }
}