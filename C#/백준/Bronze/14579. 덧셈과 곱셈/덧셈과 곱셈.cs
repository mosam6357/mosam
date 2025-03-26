using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int n = 1;
            for (int i=aa[0];i<=aa[1];i++){
                n*=(i*(i+1))/2;
                n%=14579;
            }
            Console.WriteLine(n);
        }
    }
}