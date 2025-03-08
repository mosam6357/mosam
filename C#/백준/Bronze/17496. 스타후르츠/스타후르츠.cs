using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1]; int c = aa[2]; int d = aa[3];
            int total = 0;
            for (int i=b+1;i<a+1;i+=b){
                total+=c*d;
            }
            Console.WriteLine(total);
        }
    }
}