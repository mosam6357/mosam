using System;

namespace q{
    class w{
        static int gcd(int a,int b){
            if(b==0){
                return a; 
            }
            return gcd(b,a%b);
        }
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa[1]>aa[0]){
                int temp = aa[1];
                aa[1] = aa[0];
                aa[0] = temp;
            }
            int d = gcd(aa[0],aa[1]);
            int m = (aa[0]*aa[1])/d;
            Console.WriteLine($"{d}\n{m}");
        }
    }
}