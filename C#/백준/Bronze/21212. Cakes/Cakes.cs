using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            for (int i=0;i<a;i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                aa[i] = bb[1]/bb[0];
            }
            Console.WriteLine(aa.Min());
        }
    }
}