using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s = 0;
            for (int i=0;i<aa[1];i++){
                s+=(bb[i]+1)/2;
            }
            Console.WriteLine((s>=aa[0])?"YES":"NO");
        }
    }
}