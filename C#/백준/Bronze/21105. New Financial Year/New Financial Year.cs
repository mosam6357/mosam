using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                double[] aa = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
                double p = aa[0];
                double c = aa[1];
                Console.WriteLine(100*p/(c+100));
            }
        }
    }
}