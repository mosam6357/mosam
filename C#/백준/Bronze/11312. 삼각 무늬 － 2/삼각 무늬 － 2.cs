using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                long[] aa = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
                Console.WriteLine((aa[0]*aa[0])/(aa[1]*aa[1]));
            }
        }
    }
}