using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int n = aa[0]; int c = aa[1]; int t = aa[2];
            for (int i=0;i<t;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = bb[0]; int b = bb[1];
                if (c==a){
                    c=b;
                }
                else if(c==b){
                    c=a;
                }
            }
            Console.WriteLine(c);
        }
    }
}