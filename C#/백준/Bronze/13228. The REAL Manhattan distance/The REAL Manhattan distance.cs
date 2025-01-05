using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s = aa[2]+aa[5]+Math.Abs(aa[3]-aa[0])+Math.Abs(aa[4]-aa[1]);
            Console.WriteLine(s);
                }
        }
    }
}