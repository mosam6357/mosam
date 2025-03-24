using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1];
            int total = a;
            while(a>=b){
                a/=b;
                total+=a;
            }
            Console.WriteLine(total);
        }
    }
}