using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int b = int.Parse(Console.ReadLine());
                int cnt = 0;
                int[] aa =Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int[] bb =Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                for (int j=0;j<b;j++){
                    if (aa[j]!=bb[j]){cnt++;}
                }
                Console.WriteLine(cnt);
            }
        }
    }
}