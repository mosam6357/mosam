using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int s = 0;
            int[] bb = new int[a];
            bb[0] = 0;
            for (int i=1;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                s += aa[1]-aa[0];
                bb[i] = s;
            }
            Console.WriteLine(bb.Max());
        }
    }
}